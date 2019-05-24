using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
	public float maxSpeed_h = 9.0f;	// max horizontal speed
    public float maxSpeed_v = 10.0f;

    /*NEW*/
    public float jumpSpeed = 18.0f;  // jump speed impulse
                                     
    public float jetpackPropulsion = 5.0f;

    // Current state of the player
	private bool facingRight = true;	// facing direction of the player
/*NEW*/
    private bool m_grounded;    // true if player is considered grounded

    public bool arms = false;
    public bool has_jetpack = false;
    private bool jetpackON = false;
    private bool jetpackToCloseToGround = true;
    protected Joystick joystick;
    protected buttonX bouttonX;
    protected buttonCarre bouttonCarre;


    private bool jump;    // save jump button status for fixed update
/**/

    // store Component of the Player GameObject that need to be used in the script
    private SpriteRenderer m_SpriteRenderer;
	public Rigidbody2D m_Rigidbody;
	private Animator m_Animator;
/*NEW*/
    private CapsuleCollider2D m_Capsule;
    public Transform m_ShootStartPoint;
/**/ 

    // HashId to manage the animation (faster than sting based approach)
	protected readonly int m_HashSpeedPara = Animator.StringToHash("maxSpeed_h");
/*NEW*/
    protected readonly int m_HashVerticalSpeedPara = Animator.StringToHash("maxSpeed_v");
    protected readonly int m_HashGroundedPara = Animator.StringToHash("grounded");
    protected readonly int m_HashArmsPara = Animator.StringToHash("arms");
    protected readonly int m_HashHasJetpackPara = Animator.StringToHash("has_jetpack");
    protected readonly int m_HashJetpackONPara = Animator.StringToHash("jetpackON");

    // Jump related 

    protected bool airControl = false;    // whether control is allowed during jump phase
    public LayerMask groundLayers;    // layer used to test for the ground, should be defined through the inspector

    // Contacts (we do not want to re-affects memory at every frame)
    public float groundedRaycastDistance = 0.1f;
    ContactFilter2D m_ContactFilter;
    RaycastHit2D[] m_HitBuffer = new RaycastHit2D[5];

    
/**/

    // ---------------------------------

    private void Awake ()
	{
        // get the component that will be used at each Update/FixedUpdate
		m_Animator = GetComponent<Animator> ();
		m_Rigidbody = GetComponent<Rigidbody2D> ();
/*NEW*/
        m_Capsule = GetComponent<CapsuleCollider2D>();

        bouttonX = FindObjectOfType<buttonX>();
        bouttonCarre = FindObjectOfType<buttonCarre>();


        joystick = FindObjectOfType<Joystick>();

        // define behavior for raycasting
        //        m_ContactFilter.layerMask = groundLayers;
        m_ContactFilter.layerMask = LayerMask.GetMask("Ground");
        m_ContactFilter.useLayerMask = true;
        m_ContactFilter.useTriggers = false;
        Physics2D.queriesStartInColliders = false; // do not take into account collider within which we are starting the raycast
                                                   /**/
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
	}
    	
	// Update is called once per frame
	void Update ()
	{
/*NEW*/        
        if (!jump)
        {
            // Read the jump input in Update so button presses aren't missed.
            jump = Input.GetButtonDown("Jump");

        }
        if (has_jetpack && arms)
            //utilisation du jetpack conditionnee par le fait d'avoir des bras et un jetpack
        {
            if (!jetpackON)
                //si jetpack eteint on regarde si le joueur l'utilise
            {
                jetpackON = Input.GetButtonDown("Jetpack");
                airControl = jetpackON; //on autorise le déplacement en l'air seulement si jetpack allume
            }
            else
                //sinon (il est allume) on regarde si le robot est trop pres du sol
            {
                CheckIfToCloseToGround();
                if (jetpackToCloseToGround && (m_Rigidbody.velocity.y < 0))
                {
                    jetpackON = false;
                    airControl = false;
                }
            }
        }


        if (!arms)
        {

            arms = Input.GetButtonDown("Arms") || bouttonCarre.Pressed;
        }
/**/
	}

    // Fixed Update emulate constant time steps for physic engine
    // Everything that is related to RigidBody velocity should be performed in this method
	private void FixedUpdate ()
	{
/*NEW*/
        // read continous inputs to obtain smooth motions
        float h = Input.GetAxis("Horizontal") + joystick.Horizontal;
        float v = Input.GetAxis("Vertical") + joystick.Vertical;


        // read continous inputs to obtain smooth motions from joysticks
        //float h = joystick.Horizontal;
        //float v = joystick.Vertical;

        // check whether we are grounded or not, and update player status accordingly
        CheckIfGrounded();


        // pass movement parameters to function that manage actual movement
        Move(h, v, jump);
        jump = false;

        // update the state of the animation state machine
        m_Animator.SetBool(m_HashGroundedPara, m_grounded);
        m_Animator.SetBool(m_HashArmsPara, arms);
        m_Animator.SetBool(m_HashHasJetpackPara, has_jetpack);
        m_Animator.SetBool(m_HashJetpackONPara, jetpackON);
        m_Animator.SetFloat(m_HashSpeedPara, Mathf.Abs(h));
        // we handle both fall and jump animation based on the same animation
        // that is parametrized by the vertical speed (see blend tree in Player Animator)
        m_Animator.SetFloat(m_HashVerticalSpeedPara, m_Rigidbody.velocity.y);

/**/
	}

    /*************************/ 
    /* Managment of movement */
    /*************************/ 

/*NEW*/
    public void Move(float move_h, float move_v, bool jump)
    {
        if (m_grounded || airControl)
        {
            if (airControl)
            {
                m_Rigidbody.velocity = new Vector2(move_h * maxSpeed_h, move_v * maxSpeed_v);
            }
            else
            {
                m_Rigidbody.velocity = new Vector2(move_h * maxSpeed_h, m_Rigidbody.velocity.y);
            }

            // update facing of the player using the sprite to simplify the Animator
            if ((move_h > 0 && !facingRight) || (move_h < 0 && facingRight))
            {
                Flip();
                Debug.Log("coucou");
            }

            if (m_grounded && jetpackON)
            {
                m_grounded = false;
                m_Rigidbody.velocity = new Vector2(m_Rigidbody.velocity.x / 1.5f, 10 * jetpackPropulsion);
                jetpackToCloseToGround = false;

            }
        }
    }

    public void CheckIfGrounded()
    {
        // Compute raycast starting point and direction, such that the ray
        // is directed toward the ground and have a length of groundedRaycastDistance outside
        // the capsule collider of the character

        Vector2 raycastDirection = Vector2.down;
        Vector2 raycastStart = m_Rigidbody.position + m_Capsule.offset;
        raycastStart = raycastStart + Vector2.down * (m_Capsule.size.y * 0.5f - m_Capsule.size.x * 0.5f);
        float raycastDistance = m_Capsule.size.x * 0.3f + groundedRaycastDistance * 0.25f;

        //Debug.DrawLine(raycastStart, raycastStart + raycastDirection * raycastDistance);

        int count = Physics2D.Raycast(raycastStart, raycastDirection, m_ContactFilter, m_HitBuffer, raycastDistance);

        // We can check the ray that will be sent in the scene for debugging
        Debug.DrawRay (raycastStart, raycastDirection*raycastDistance); // * raycastDistance

        m_grounded = (count > 0);
        //m_HitBuffer[0] contains informations on the closest collider
        //free memory
        for (int i = 0; i < m_HitBuffer.Length; i++)
        {
            m_HitBuffer[i] = new RaycastHit2D();
        }
    }


    public void CheckIfToCloseToGround()
    {
        // Compute raycast starting point and direction, such that the ray
        // is directed toward the ground and have a length of groundedRaycastDistance outside
        // the capsule collider of the character

        Vector2 raycastDirection = Vector2.down;
        Vector2 raycastStart = m_Rigidbody.position + m_Capsule.offset;
        raycastStart = raycastStart + Vector2.down * (m_Capsule.size.y * 0.5f - m_Capsule.size.x * 0.5f);
        float raycastDistance = m_Capsule.size.x * 0.4f + groundedRaycastDistance * 0.4f;

        //Debug.DrawLine(raycastStart, raycastStart + raycastDirection * raycastDistance);

        int count = Physics2D.Raycast(raycastStart, raycastDirection, m_ContactFilter, m_HitBuffer, raycastDistance);

        // We can check the ray that will be sent in the scene for debugging
        Debug.DrawRay(raycastStart, raycastDirection * 1.5f); // * raycastDistance

        jetpackToCloseToGround = (count > 0);

        //m_HitBuffer[0] contains informations on the closest collider
        //free memory
        for (int i = 0; i < m_HitBuffer.Length; i++)
        {
            m_HitBuffer[i] = new RaycastHit2D();
        }
    }
    



    /**/


    private void Flip ()
	{
		facingRight = !facingRight;

        // use negative scaling to reverse the sprite when the player is facing left
		Vector3 s = transform.localScale;
		s.x *= -1;        
		transform.localScale = s;
	}



}

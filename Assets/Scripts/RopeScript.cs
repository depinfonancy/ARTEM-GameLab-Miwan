using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RopeScript : MonoBehaviour
{
    private bool canClimb = false;

    //climbing speed of the player
    private float climbingSpeed = 3.0f;

    // define variable but can not assign them yet because Unity wont accept it
    public GameObject playerObject;
    private Rigidbody2D p_rigidbody;
    private Animator anim;
    private bool arms;


    void Start()
    { 
        
    }

    public void OnCollisionEnter2D(Collision2D coll)

        // enable the player to climb when there is a collision between rope and player
    {
        playerObject = GameObject.Find("Player");
        anim = playerObject.GetComponent<Animator>();

        if (coll.gameObject == playerObject && anim.GetBool("arms"))
        {
            canClimb = true;
            Debug.Log("on grimpe \n");

            // display climbing animation
            anim.SetBool("climbing", true);
        }

    }

    void OnCollisionExit2D(Collision2D coll2)

        // disable the player to climb when the contact is over
    {
        playerObject = GameObject.Find("Player");
        anim = playerObject.GetComponent<Animator>();

        if (coll2.gameObject == playerObject )
        {
            canClimb = false;
            Debug.Log("stop climbing. \n");

            // stop climbing animation
            anim.SetBool("climbing", false);
        }
        
    }

    void Update()

        // manage player movement when it is in contact with the rope
    {
        p_rigidbody = GameObject.Find("Player").GetComponent<Rigidbody2D>();

        if (canClimb)
        {   
            //up movement
            if (Input.GetKey(KeyCode.UpArrow))
            {
                p_rigidbody.velocity = new Vector2(0, climbingSpeed);
            }

            //down movement
            if (Input.GetKey(KeyCode.DownArrow))
            {
                p_rigidbody.velocity = new Vector2(0, climbingSpeed);
            }
        }
    }


}
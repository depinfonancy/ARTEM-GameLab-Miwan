using UnityEngine;

/// <summary>
/// Contrôleur du joueur
/// </summary>
public class PlayerScript : MonoBehaviour
{
  /// <summary>
  /// 1 - La vitesse de déplacement
  /// </summary>
  public Vector2 speed = new Vector2(50, 50);
    // store Component of the Player GameObject that need to be used in the script
    private SpriteRenderer m_SpriteRenderer;
    private Rigidbody2D m_Rigidbody;
    private Animator m_Animator;
    private CapsuleCollider2D m_Capsule;

    // 2 - Stockage du mouvement
    private Vector2 movement;

    private void Awake()
    {
        // get the component that will be used at each Update/FixedUpdate
        m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody2D>();
        /*NEW*/
        m_Capsule = GetComponent<CapsuleCollider2D>();
    }

        void Update()
  {
    // 3 - Récupérer les informations du clavier/manette
    float inputX = Input.GetAxis("Horizontal");
    float inputY = Input.GetAxis("Vertical");

    // 4 - Calcul du mouvement
    movement = new Vector2(
      speed.x * inputX,
      speed.y * inputY);

  }

  void FixedUpdate()
  {
    // 5 - Déplacement
    m_Rigidbody.velocity = movement;
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contrôleur du joueur
/// </summary>
public class PlayerScript : MonoBehaviour
{
    /// <summary>
    /// 1 - La vitesse de déplacement
    /// </summary>
    public Vector2 speed = new Vector2(10, 10);
    private Rigidbody2D m_Rigidbody;

    // 2 - Stockage du mouvement
    private Vector2 movement;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();

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

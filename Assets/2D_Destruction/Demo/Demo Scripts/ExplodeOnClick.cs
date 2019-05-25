using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Explodable))]
public class ExplodeOnClick : MonoBehaviour
{

    private Explodable _explodable;
    private Rigidbody2D m_Rigidbody;
    //private Vector2 nullvector = new Vector2((float)0.5, (float)0.5);

    void Start()
    {
        _explodable = GetComponent<Explodable>();
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (m_Rigidbody.velocity[0] > 5) { 
        _explodable.explode();
        //ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
        //ef.doExplosion(transform.position);
        }
    }

}

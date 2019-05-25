using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentScript : MonoBehaviour
{
    public Rigidbody2D m_Rigidbody;

    private void Awake()
    {
        // get the component that will be used at each Update/FixedUpdate
        //m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody2D>();
        /*NEW*/
        //m_Capsule = GetComponent<CapsuleCollider2D>();


        // define behavior for raycasting
        //        m_ContactFilter.layerMask = groundLayers;
        m_Rigidbody.velocity = new Vector2(1 * 4.0f, 1*1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

    }
}
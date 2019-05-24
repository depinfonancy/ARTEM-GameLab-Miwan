using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRope : MonoBehaviour
{
    
    // define variable but can not assign them yet because Unity wont accept it
    public GameObject playerObject;
    private RopeScript rope;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D coll)

    // enable the player to climb when there is a collision between rope and player
    {
        playerObject = GameObject.Find("Player");
        anim = playerObject.GetComponent<Animator>();

        if (coll.gameObject == playerObject)
        {
            anim.SetBool("climbing", false);

            Debug.Log("on descend \n");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

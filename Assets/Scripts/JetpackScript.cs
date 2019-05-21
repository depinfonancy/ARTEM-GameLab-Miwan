using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackScript : MonoBehaviour
{
    // define variable but can not assign them yet because Unity wont accept it
    public GameObject playerObject;
    private Rigidbody2D p_rigidbody;

    void Start()
    {

    }

    void OnCollisionEnter(Collision coll)

    // enable the player to climb when there is a collision between rope and player
    {
        playerObject = GameObject.Find("Player");

        if (coll.gameObject == playerObject)
        {
            playerObject.GetComponent<PlayerControler>().has_jetpack = true;
            Debug.Log("bouuuum");
        }

    }

    void OnCollisionExit(Collision coll2)

    // disable the player to climb when the contact is over
    {
        playerObject = GameObject.Find("Player");

        if (coll2.gameObject == playerObject)
        {
            Debug.Log("stop boum");
        }

    }

    void Update()

    // manage player movement when it is in contact with the rope
    {
    }


}
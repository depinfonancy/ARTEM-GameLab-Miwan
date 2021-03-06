﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsScript : MonoBehaviour
{
    // define variable but can not assign them yet because Unity wont accept it
    public GameObject playerObject;
    private Rigidbody2D p_rigidbody;


    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)

    {
        playerObject = GameObject.Find("Player");


        if (coll.gameObject == playerObject)
        {
            playerObject.GetComponent<PlayerControler>().arms = true;
        }

    }

    void OnCollisionExit2D(Collision2D coll2)

    // 2 seconds after the end of the collision, the arms sprite disappears
    {
        playerObject = GameObject.Find("Player");


        if (coll2.gameObject == playerObject)
        {
            //start co-routine in order to wait 2 seconds and desactivate the sprite
            //StartCoroutine(GreenYellowRed());


            this.gameObject.SetActive(false);

        }
    }



    IEnumerator GreenYellowRed()
    // why this name ? I had no inspirations ... sorry for that
    {
        yield return new WaitForSeconds(2.0f);
        this.gameObject.SetActive(false);
    }


    void Update()

    // manage player movement when it is in contact with the arms
    {
    }


}
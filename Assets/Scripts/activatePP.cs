using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatePP : MonoBehaviour
{
    private bool postprocessing = false;

    public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnCollisionEnter2D(Collision2D coll)

    // enable the player to climb when there is a collision between rope and player
    {
        playerObject = GameObject.Find("Player");
        light = GameObject.Find("Light");
        if (coll.gameObject == playerObject)
        {
            light.SetActive(false);
            lightoff = true;
            Debug.Log("light turned off \n");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
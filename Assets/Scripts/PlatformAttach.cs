using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        playerObject = GameObject.Find("Player");

        if (other.gameObject == playerObject)
        {
            //When the platform is moving, the player will be moving as weel
            playerObject.transform.parent = transform;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject == playerObject)
        {
            //We remove the parent
            playerObject.transform.parent = null;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}

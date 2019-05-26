using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public GameObject playerObject;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(playerObject.transform.position.y > 19)
        {
            Vector3 tmp = new Vector3(0.2f, 0,0);
            rb.transform.position += tmp;
            
        }
    }

}
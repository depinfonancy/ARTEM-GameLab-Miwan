using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public GameObject Jetpack;
    public GameObject playerObject;
    public GameObject message;
    private Animator anim;
    public Rigidbody2D boxRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        boxRigidbody = GetComponent<Rigidbody2D>();

        //desactivate jetpack sprite
        Jetpack = GameObject.Find("JetPack");
        Jetpack.gameObject.SetActive(false);

        //desactivate message sprite
        message = GameObject.Find("MessageJetpack");
        message.gameObject.SetActive(false);
    }


    public void OnCollisionEnter2D(Collision2D coll)

    // enable the player to climb when there is a collision between rope and player
    {
        playerObject = GameObject.Find("Player");
        anim = playerObject.GetComponent<Animator>();

        //if collision with the robot
        if (coll.gameObject == playerObject && anim.GetBool("arms"))
        {   
            //activate jetpack sprite
            Jetpack.gameObject.SetActive(true);

            //activate message of explanations sprite
            message.gameObject.SetActive(true);

            //desactivate box sprite
            this.gameObject.SetActive(false);

        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

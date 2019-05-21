using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public GameObject Jetpack;
    public GameObject playerObject;
    private Animator anim;
    public Rigidbody2D boxRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        boxRigidbody = GetComponent<Rigidbody2D>();
        Jetpack = GameObject.Find("JetPack");
        Jetpack.gameObject.SetActive(false);
    }


    public void OnCollisionEnter2D(Collision2D coll)

    // enable the player to climb when there is a collision between rope and player
    {
        playerObject = GameObject.Find("Player");
        anim = playerObject.GetComponent<Animator>();

        if (coll.gameObject == playerObject && anim.GetBool("arms"))
        {
            boxRigidbody.velocity = new Vector2(100f, 100f);
            Jetpack.gameObject.SetActive(true);

            this.gameObject.SetActive(false);
        }

    }

        // Update is called once per frame
        void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepOutScript : MonoBehaviour
{
    private bool canCut = false;
    public GameObject playerObject;
    private Rigidbody2D p_rigidbody;
    private Animator anim;
    private bool arms;
    // Start is called before the first frame update
    void Start()
    {

        GetComponent(this.transform.Find("keepout1_1").gameObject).enabled = false;
        GetComponent(this.transform.Find("keepout1_2").gameObject).enabled = false;
    }
    public void OnCollisionEnter2D(Collision2D coll)

    // enable the player to climb when there is a collision between rope and player
    {
        playerObject = GameObject.Find("Player");
        anim = playerObject.GetComponent<Animator>();

        if (coll.gameObject == playerObject && anim.GetBool("arms"))
        {
            canCut = true;
            Debug.Log("on découpe l'obj si la touche C est pressée\n");
            if (Input.GetKeyDown("C")) {
                // display climbing animation
                anim.SetBool("cut", true);
                // display morceaux coupés
                Destroy(this.transform.Find("keepout1_contour").gameObject);
                GetComponent(this.transform.Find("keepout1_1").gameObject).enabled = true;
                GetComponent(this.transform.Find("keepout1_2").gameObject).enabled = true;

            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

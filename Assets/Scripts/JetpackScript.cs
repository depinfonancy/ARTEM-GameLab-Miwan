using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class JetpackScript : MonoBehaviour
{
    // define variable but can not assign them yet because Unity wont accept it
    public GameObject playerObject;
    private Rigidbody2D p_rigidbody;
    //public GUIText winText;
    public string stringToEdit;


    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)

    // enable the player to climb when there is a collision between rope and player
    {
        playerObject = GameObject.Find("Player");


        if (coll.gameObject == playerObject)
        {
            playerObject.GetComponent<PlayerControler>().has_jetpack = true;
        }

    }

    void OnCollisionExit2D(Collision2D coll2)

    // disable the player to climb when the contact is over
    {
        playerObject = GameObject.Find("Player");
        stringToEdit = "Hello World";


    if (coll2.gameObject == playerObject)
    {
        StartCoroutine(GreenYellowRed());
    }
}

    

    IEnumerator GreenYellowRed()
    {
        yield return new WaitForSeconds(2.0f);
        //winText.text = " NEW JETPACK !!! USE SPACEBAR TO USE IT";
        this.gameObject.SetActive(false);
        void OnGUI()
        {
            stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
        }

        OnGUI();





    }


    void Update()

    // manage player movement when it is in contact with the jetpack
    {
    }


}
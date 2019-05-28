using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxScript : MonoBehaviour
{
    public GameObject Jetpack;
    public GameObject Arms;
    public GameObject playerObject;
    public GameObject message;
    private Animator anim;
    public Rigidbody2D boxRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        boxRigidbody = GetComponent<Rigidbody2D>();
        //get current scene
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        
        if (sceneName == "10")
        {
            message = GameObject.Find("MessageJetpack");
            //desactivate jetpack sprite
            Jetpack = GameObject.Find("JetPack");
            Jetpack.gameObject.SetActive(false);
        }
        if (sceneName == "2+3")
        {
            message = GameObject.Find("MessageArms");
            //desactivate arms sprite
            Arms = GameObject.Find("Arms");
            Arms.gameObject.SetActive(false);
        }
        //desactivate message sprite
        message.gameObject.SetActive(false);

    }


    public void OnCollisionEnter2D(Collision2D coll)

    {
        playerObject = GameObject.Find("Player");
        anim = playerObject.GetComponent<Animator>();


        if (coll.gameObject == playerObject)
        {
            //activate arms sprite
            Arms.gameObject.SetActive(true);

            //activate message of explanations sprite
            message.SetActive(true);
            
            //desactivate box sprite
            //this.gameObject.SetActive(false);
        }

        //if collision with the robot and we want to add jetpack
        if (coll.gameObject == playerObject && anim.GetBool("arms"))
        {   
            //activate jetpack sprite
            Jetpack.gameObject.SetActive(true);

            //activate message of explanations sprite
            message.gameObject.SetActive(true);

            //desactivate box sprite
            //this.gameObject.SetActive(false);

        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

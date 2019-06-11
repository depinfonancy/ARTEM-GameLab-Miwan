using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class activatePP : MonoBehaviour
{
    private bool postprocessing = false;

    public PostProcessVolume postProcess;
    public GameObject playerObject;
    public GameObject effect;
    public GameObject light;

    public GameObject UIObject;

    //private bool has_lens = false;

    public bool lightoff = true;

    // Start is called before the first frame update
    void Start()
    {
        /*UIObject.SetActive(true);

        effect = GameObject.Find("Postprocessing");
        postProcess = effect.GetComponent<PostProcessVolume>();
        postProcess.weight = 0f;

        light = GameObject.Find("Spot Light");
        light.SetActive(false);*/

    }


    /*public void OnCollisionEnter2D(Collision2D coll)

    // enable the player to climb when there is a collision between rope and player
    {
        
        //light = GameObject.Find("Spot Light");

        if (has_lens)
        {
            
        }

    }*/

    // Update is called once per frame
    void Update()
    {
        /*playerObject = GameObject.Find("Player");

        if (Input.GetKeyDown(KeyCode.L))
        {
            has_lens = true;
            print("L key was pressed");
            UIObject.SetActive(false);
            

            Debug.Log("camera effect on");
            postProcess.weight = 1f;

            light.SetActive(true);
            lightoff = false;
        }*/
    }
}

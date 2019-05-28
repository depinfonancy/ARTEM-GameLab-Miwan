using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class activatePP : MonoBehaviour
{
    private bool postprocessing = false;

    public PostProcessVolume postProcess;
    public GameObject playerObject;
    public GameObject effect;
    public GameObject light;


    private bool hasLens = false;
    public bool lightoff = true;

    // Start is called before the first frame update
    void Start()
    {
        effect = GameObject.Find("Postprocessing");
        postProcess = effect.GetComponent<PostProcessVolume>();
        postProcess.weight = 0f;

        light = GameObject.Find("Spot Light");
        light.SetActive(false);

    }


    public void OnCollisionEnter2D(Collision2D coll)

    // enable the player to climb when there is a collision between rope and player
    {
        playerObject = GameObject.Find("Player");
        //light = GameObject.Find("Spot Light");

        if (coll.gameObject == playerObject)
        {
            hasLens = true;
            Debug.Log("camera effect on");
            postProcess.weight = 1f;

            light.SetActive(true);
            lightoff = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesLoader : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private string scenenb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //SceneManager.LoadScene(scenenb);

    }
    //When arriving at the end of the scene
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "SceneEnd") {
            SceneManager.LoadScene(scenenb);
        }
    }


}

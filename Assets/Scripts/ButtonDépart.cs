using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ButtonDépart : MonoBehaviour

{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

   public void PushStartButton()
    {
//        Destroy(GameObject.Find("Singleton"));
        
        SceneManager.LoadScene("TitleScene");
     


    }




}




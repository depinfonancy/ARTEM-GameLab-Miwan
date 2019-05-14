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
        SceneManager.LoadScene("TitleScene");    //最初のシーンへ
    }
}

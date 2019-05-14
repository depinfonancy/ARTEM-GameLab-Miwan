using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonPause : MonoBehaviour
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
        SceneManager.LoadScene("PauseScene");    //フリップシーンへ
    }
}
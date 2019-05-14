using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonVolume : MonoBehaviour
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
        SceneManager.LoadScene("VolumeScene");    //フリップシーンへ
    }
}
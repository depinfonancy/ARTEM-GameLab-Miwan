using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonCommande : MonoBehaviour
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
        SceneManager.LoadScene("CommandeScene");    //フリップシーンへ
    }
}
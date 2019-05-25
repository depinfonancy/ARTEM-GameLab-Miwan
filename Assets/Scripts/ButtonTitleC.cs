using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonTitleC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PushStartButton()
    {
        SceneManager.LoadScene("PauseScene");    //playのシーンへ
    }
}

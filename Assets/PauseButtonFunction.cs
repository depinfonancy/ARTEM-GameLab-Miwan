using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class PauseButtonFunction : MonoBehaviour
{
    public void PushVolumeButton()
    {
        SceneManager.LoadScene("VolumeScene");    //フリップシーンへ
    }

    public void PushCommadeButton()
    {
        SceneManager.LoadScene("CommandeScene");    //フリップシーンへ
    }

    public void PushPauseButton()
    {
        SceneManager.LoadScene("PauseScene");    //pauseシーンへ
    }




}

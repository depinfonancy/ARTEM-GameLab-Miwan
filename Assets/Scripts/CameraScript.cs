using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;

    public GameObject end;

    private Vector3 offset;         

    private Vector3 vertOffset;

    float horizontalDegree;
    float horizontalValue;
    float horizontalValueBackground;

    void Start()
    {
        Camera.main.fieldOfView = 60.0f;
        player = GameObject.Find("Player");
        end = GameObject.Find("SceneEnd");
 
        //L'offset permet d'avoir la caméra bien placée ar rapport au joueur, peu importe comment elle a été mise sur la scène
        offset = new Vector3(0, 2, -10);

        horizontalDegree = 16 / 9 * Camera.main.fieldOfView; ;
        horizontalValue = Mathf.Tan(horizontalDegree / 2 * Mathf.PI / 180) * 10 * 2.8f;
        //pythagore. Le 2 s'est transformé en 2.8 par tatonnement, parce que ça marchait pas.

        Debug.Log(horizontalValue);
        

    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        //transform.position = player.transform.position + offset + vertOffset;
        if (player.transform.position[0] < end.transform.position[0] - horizontalValue)
        {
            transform.position = player.transform.position + offset;
        }

    }
}
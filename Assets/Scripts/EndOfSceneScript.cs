using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.position - new Vector3(5, 0, 0);
        //permet d'aligner  l'objet avec la fin du décor, en considérant les paramètres suivants :
        // - joueur en Z = 0
        // - background à Z = 5
        // - caméra en Z = -10
        // - angle de vue à 60.0f
        // - écran en 16/9
        // Si une de ses valeurs change, refaire les math. (là ça tombe preque tout pil à 5 mais c'est du bol)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

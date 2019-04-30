using UnityEngine;
using System.Collections;

public class DestroyBox : MonoBehaviour
{
    private Rigidbody2D rb;
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("" + col.attachedRigidbody.velocity);
        if (col.gameObject.name == "caisseBois")
        {
            Destroy(col.gameObject);
        }
    }
}

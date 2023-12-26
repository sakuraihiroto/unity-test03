using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float DethDTimer;

    void OnCollisionEnter(Collision collision)
    {
        // Õ“Ë‚µ‚½‘Šè‚ÉPlayerƒ^ƒO‚ª•t‚¢‚Ä‚¢‚é‚Æ‚«
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "floor")
        {
            Destroy(gameObject, DethDTimer);
        }
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        Destroy(gameObject, DethDTimer);
    }
}

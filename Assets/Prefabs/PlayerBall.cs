using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}

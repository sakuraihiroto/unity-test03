using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float DethDTimer;

    void OnCollisionEnter(Collision collision)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
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

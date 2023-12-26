using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject shellPrefab;
    public int count;

    void Update()
    {
        count += 1;

        // �i�|�C���g�j
        // 1�O�t���[�����ƂɖC�e�𔭎˂���
        if (count % 10 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            // �e���͎��R�ɐݒ�
            shellRb.AddForce(transform.forward * 500);

            // 10�b��ɖC�e��j�󂷂�
            Destroy(shell, 10.0f);
        }
    }
}
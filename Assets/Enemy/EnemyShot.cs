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

        // iƒ|ƒCƒ“ƒgj
        // 1‚OƒtƒŒ[ƒ€‚²‚Æ‚É–C’e‚ğ”­Ë‚·‚é
        if (count % 10 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            // ’e‘¬‚Í©—R‚Éİ’è
            shellRb.AddForce(transform.forward * 500);

            // 10•bŒã‚É–C’e‚ğ”j‰ó‚·‚é
            Destroy(shell, 10.0f);
        }
    }
}
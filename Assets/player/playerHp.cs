using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHp : MonoBehaviour
{
    public Slider slider;

    int maxHp = 10;
    float Hp;
    
    // Start is called before the first frame update
    void Start()
    {
        //Slider�𖞃^���ɂ���B
        slider.value = 10;
        //���݂�HP���ő�HP�Ɠ����ɁB
        Hp = maxHp;
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        //Enemy�^�O��ݒ肵�Ă���I�u�W�F�N�g�ɐڐG�����Ƃ�
        if (other.gameObject.tag == "enemy")
        {
            //HP����1������
            Hp = Hp - 1;
        }
        if (other.gameObject.tag == "EnemyShot")
        {
            Hp = Hp - 1;
        }
        //HP��Slider�ɔ��f�B
        slider.value = (float)Hp / (float)maxHp; ;
    }
}

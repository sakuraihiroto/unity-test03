using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public Slider slider;

    int maxHp = 10;
    float Hp;

    // Start is called before the first frame update
    void Start()
    {
        //Slider�𖞃^���ɂ���B
        slider.value = 1;
        //���݂�HP���ő�HP�Ɠ����ɁB
        Hp = maxHp;
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        //Enemy�^�O��ݒ肵�Ă���I�u�W�F�N�g�ɐڐG�����Ƃ�
        if (other.gameObject.tag == "playerBall")
        {
            if (Hp > 0)
            {
                Hp = Hp - 0.1f;
            }
            else
            {
                Destroy(gameObject);
            }
            //HP��Slider�ɔ��f�B
            slider.value = (float)Hp / (float)maxHp; ;
        }
        //��_�ɓ���������
        if (other.gameObject.tag == "weakPoint")
        {
            if (Hp > 0)
            {
                Hp = Hp - 8.0f;
            }
            else
            {
                Destroy(gameObject);
            }

            //HP��Slider�ɔ��f�B
            slider.value = (float)Hp / (float)maxHp; ;
        }
    }
}

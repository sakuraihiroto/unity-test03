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
        //Sliderを満タンにする。
        slider.value = 10;
        //現在のHPを最大HPと同じに。
        Hp = maxHp;
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        //Enemyタグを設定しているオブジェクトに接触したとき
        if (other.gameObject.tag == "enemy")
        {
            //HPから1を引く
            Hp = Hp - 1;
        }
        if (other.gameObject.tag == "EnemyShot")
        {
            Hp = Hp - 1;
        }
        //HPをSliderに反映。
        slider.value = (float)Hp / (float)maxHp; ;
    }
}

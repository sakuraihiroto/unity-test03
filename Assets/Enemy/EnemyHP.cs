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
        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        Hp = maxHp;
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        //Enemyタグを設定しているオブジェクトに接触したとき
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
            //HPをSliderに反映。
            slider.value = (float)Hp / (float)maxHp; ;
        }
        //弱点に当たった時
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

            //HPをSliderに反映。
            slider.value = (float)Hp / (float)maxHp; ;
        }
    }
}

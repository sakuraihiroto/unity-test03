using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //攻撃①
    // 円の半径
    [SerializeField] private float _radius = 1;
    // 円の中心点
    [SerializeField] private Vector3 _center;
    // 配置するPrefab
    [SerializeField] private GameObject _prefab;
    //カウント
    public int count;

    //攻撃②
    //playerObject
    [SerializeField] GameObject player;
    //prefub
    [SerializeField] GameObject ball;
    //ボールのスピード
    private float ballSpeed = 12.0f;
    //タイマー
    private float time = 0.5f;

    public enum RoutineType
    { 
        Attack_1, //攻撃パターン１
        Attack_2, //攻撃パターン２
    }
    RoutineType m_routine = RoutineType.Attack_1;



    void Attack_1()
    {
        
        transform.LookAt(player.transform);
        time -= Time.deltaTime;
        if (time <= 0)
        {
            GameObject shotObj = Instantiate(ball, transform.position, Quaternion.identity);
            shotObj.GetComponent<Rigidbody>().velocity = transform.forward * ballSpeed;
            time = 0.5f;
        }
    }
    void Attack_2()
    {
        count += 1;

        // 3０フレームごとに砲弾を発射される
        if (count % 30 == 0)
        {
            // 指定された半径の円内のランダム位置を取得
            var circlePos = _radius * Random.insideUnitCircle;

            // XZ平面で指定された半径、中心点の円内のランダム位置を計算
            var spawnPos = new Vector3(
                circlePos.x, 0, circlePos.y
            ) + _center;

            // Prefabを追加
            GameObject prefab = Instantiate(_prefab, spawnPos, Quaternion.identity);
        }
    }

    public void Update()
    {
        switch (m_routine)
        {
            //攻撃パターン①
            case RoutineType.Attack_1:
                {
                    Attack_1();
                }
            break;
            //攻撃パターン②
            case RoutineType.Attack_2:
                {
                    //Attack_2();
                }
            break;
        }
    }
}

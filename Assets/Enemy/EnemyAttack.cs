using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //�U���@
    // �~�̔��a
    [SerializeField] private float _radius = 1;
    // �~�̒��S�_
    [SerializeField] private Vector3 _center;
    // �z�u����Prefab
    [SerializeField] private GameObject _prefab;
    //�J�E���g
    public int count;

    //�U���A
    //playerObject
    [SerializeField] GameObject player;
    //prefub
    [SerializeField] GameObject ball;
    //�{�[���̃X�s�[�h
    private float ballSpeed = 12.0f;
    //�^�C�}�[
    private float time = 0.5f;

    public enum RoutineType
    { 
        Attack_1, //�U���p�^�[���P
        Attack_2, //�U���p�^�[���Q
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

        // 3�O�t���[�����ƂɖC�e�𔭎˂����
        if (count % 30 == 0)
        {
            // �w�肳�ꂽ���a�̉~���̃����_���ʒu���擾
            var circlePos = _radius * Random.insideUnitCircle;

            // XZ���ʂŎw�肳�ꂽ���a�A���S�_�̉~���̃����_���ʒu���v�Z
            var spawnPos = new Vector3(
                circlePos.x, 0, circlePos.y
            ) + _center;

            // Prefab��ǉ�
            GameObject prefab = Instantiate(_prefab, spawnPos, Quaternion.identity);
        }
    }

    public void Update()
    {
        switch (m_routine)
        {
            //�U���p�^�[���@
            case RoutineType.Attack_1:
                {
                    Attack_1();
                }
            break;
            //�U���p�^�[���A
            case RoutineType.Attack_2:
                {
                    //Attack_2();
                }
            break;
        }
    }
}

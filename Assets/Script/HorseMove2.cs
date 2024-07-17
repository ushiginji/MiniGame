using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class HorseMove2 : MonoBehaviour
{
    [SerializeField] private float minSpeed = 1.0f; // �ŏ����x
    [SerializeField] private float maxSpeed = 3.0f; // �ő呬�x

    private float currentSpeed;

    public Transform targetPosition; // ���B�ʒu

    bool StartRun = false;
    
    [SerializeField]
    public bool B = false;

    [SerializeField]
    public GameObject HorseMove;
    HorseMove CS;
    [SerializeField]
    public GameObject HorseMove3;
    HorseMove3 CS3;
    [SerializeField]
    public GameObject HorseMove4;
    HorseMove4 CS4;
    [SerializeField]
    public GameObject HorseMove5;
    HorseMove5 CS5;

    void Start()
    {
        // �ŏ��̑��x��ݒ�
        SetRandomSpeed();
        CS = HorseMove.GetComponent<HorseMove>();
        CS3 = HorseMove3.GetComponent<HorseMove3>();
        CS4 = HorseMove4.GetComponent<HorseMove4>();
        CS5 = HorseMove5.GetComponent<HorseMove5>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartRun = true;
        }
        if (StartRun == true)
        {
            // �I�u�W�F�N�g���ړ�������
            transform.Translate(Vector3.up * currentSpeed * Time.deltaTime);

            // ��莞�Ԃ��Ƃɑ��x��ύX����
            if (Random.value < 0.001f) // �Ⴆ�΁A�m���ő��x��ύX����
            {
                SetRandomSpeed();
            }

            if (targetPosition != null)
            {
                // ���B�ʒu�ɃI�u�W�F�N�g�����B�������ǂ������m�F
                if (Vector3.Distance(transform.position, targetPosition.position) > 8.0f)
                {
                    B = true;
                    currentSpeed = 0.0f;
                    if (CS.A == true && CS5.E == true && CS3.C == true && CS4.D == true && B == true)
                    {
                        Invoke("Des", 3.0f);
                    }
                }

            }
        }

    }

    void SetRandomSpeed()
    {
        // �����_���ȑ��x��ݒ肷��
        currentSpeed = Random.Range(minSpeed, maxSpeed);
    }
    void Des()
    {
        // ���B������I�u�W�F�N�g��j������
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMove5 : MonoBehaviour
{
    [SerializeField] private float minSpeed = 1.0f; // �ŏ����x
    [SerializeField] private float maxSpeed = 3.0f; // �ő呬�x

    private float currentSpeed;

    public Transform targetPosition; // ���B�ʒu

    bool StartRun = false;
    [SerializeField]
    public bool E = false;

    [SerializeField]
    public GameObject HorseMove;
    HorseMove CS;
    [SerializeField]
    public GameObject HorseMove2;
    HorseMove2 CS2;
    [SerializeField]
    public GameObject HorseMove3;
    HorseMove3 CS3;
    [SerializeField]
    public GameObject HorseMove4;
    HorseMove4 CS4;

    void Start()
    {
        // �ŏ��̑��x��ݒ�
        SetRandomSpeed();
        CS = HorseMove.GetComponent<HorseMove>();
        CS2 = HorseMove2.GetComponent<HorseMove2>();
        CS3 = HorseMove3.GetComponent<HorseMove3>();
        CS4 = HorseMove4.GetComponent<HorseMove4>();
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
                if (Vector3.Distance(transform.position, targetPosition.position) > 6.5f)
                {
                    E = true;
                    currentSpeed = 0.0f;
                    if (CS.A == true && CS2.B == true && CS3.C == true && CS4.D == true && E == true)
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

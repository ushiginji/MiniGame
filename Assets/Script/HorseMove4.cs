using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class HorseMove4 : MonoBehaviour
{
    [SerializeField] private float minSpeed = 1.0f; // 最小速度
    [SerializeField] private float maxSpeed = 3.0f; // 最大速度

    private float currentSpeed;

    public Transform targetPosition; // 到達位置

    bool StartRun = false;
    [SerializeField]
    public bool D = false;

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
    public GameObject HorseMove5;
    HorseMove5 CS5;

    void Start()
    {
        // 最初の速度を設定
        SetRandomSpeed();
        CS = HorseMove.GetComponent<HorseMove>();
        CS2 = HorseMove2.GetComponent<HorseMove2>();
        CS3 = HorseMove3.GetComponent<HorseMove3>();
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
            // オブジェクトを移動させる
            transform.Translate(Vector3.up * currentSpeed * Time.deltaTime);

            // 一定時間ごとに速度を変更する
            if (Random.value < 0.001f) // 例えば、確率で速度を変更する
            {
                SetRandomSpeed();
            }

            if (targetPosition != null)
            {
                // 到達位置にオブジェクトが到達したかどうかを確認
                if (Vector3.Distance(transform.position, targetPosition.position) > 6.8f)
                {
                    D = true;
                    currentSpeed = 0.0f;
                    if (CS.A == true && CS2.B == true && CS3.C == true && CS5.E == true && D == true)
                    {
                        Invoke("Des", 3.0f);
                    }
                }

            }
        }

    }

    void SetRandomSpeed()
    {
        // ランダムな速度を設定する
        currentSpeed = Random.Range(minSpeed, maxSpeed);
    }
    void Des()
    {
        // 到達したらオブジェクトを破棄する
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMove5 : MonoBehaviour
{
    [SerializeField] private float minSpeed = 1.0f; // 最小速度
    [SerializeField] private float maxSpeed = 3.0f; // 最大速度

    private float currentSpeed;

    public Transform targetPosition; // 到達位置

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
        // 最初の速度を設定
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
        // ランダムな速度を設定する
        currentSpeed = Random.Range(minSpeed, maxSpeed);
    }

   void Des()
    {
        // 到達したらオブジェクトを破棄する
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneMan : MonoBehaviour
{
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
    [SerializeField]
    public GameObject HorseMove5;
    HorseMove5 CS5;

    // Start is called before the first frame update
    void Start()
    {
        CS = HorseMove.GetComponent<HorseMove>();
        CS2 = HorseMove2.GetComponent<HorseMove2>();
        CS3 = HorseMove3.GetComponent<HorseMove3>();
        CS4 = HorseMove4.GetComponent<HorseMove4>();
        CS5 = HorseMove5.GetComponent<HorseMove5>();
    }

    // Update is called once per frame
    void Update()
    {



        if (CS.A == true && CS2.B == true && CS3.C == true && CS4.D == true && CS5.E == true)
        {
            // ÉVÅ[ÉìÇêÿÇËë÷Ç¶ÇÈ
            SceneManager.LoadScene("TitleScene");

        }
    }
}
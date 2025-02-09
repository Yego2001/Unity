using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float balance;
    public TextMeshProUGUI balanceText;
    private GameObject canvas;

    void Start()
    {


        balanceText.SetText("0");

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void ButtonClick(int ScoreToAdd)
    {
        balance += ScoreToAdd;
    }
}

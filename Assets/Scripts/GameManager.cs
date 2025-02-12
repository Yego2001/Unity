using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float balance;
    public TextMeshProUGUI balanceText;
    public Button buttonComponent;



    void Start()
    {




    }
    // Update is called once per frame
    void Update()
    {

    }


    private void ButtonClick(int ScoreToAdd)
    {
        balance += ScoreToAdd;
    }


    public void updateText()
    {
        balanceText.SetText(balance + "");
    }
}

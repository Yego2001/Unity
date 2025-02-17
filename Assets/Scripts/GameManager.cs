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
    public int ScoreToAdd;



    void Start()
    {
        buttonComponent.onClick.AddListener(ButtonClick);



    }
    // Update is called once per frame
    void Update()
    {

    }


    private void ButtonClick()
    {
        balance += ScoreToAdd;
        updateText();
    }


    public void updateText()
    {
        balanceText.SetText(balance + "");
    }
}
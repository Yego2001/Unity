using System;
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
    public Button clickButton;
    public int ScoreToAdd = 1;
    public GameObject storeScene;
    public GameObject homeScene;
    public Button homeButton;
    public Button storeButton;
    private String activeScene = "Home";




    void Start()
    {
        clickButton.onClick.AddListener(ButtonClick);
        homeButton.onClick.AddListener(ButtonClick);
        storeButton.onClick.AddListener(ButtonClick);




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


    private void ChaigeScene()
    {
        if (String.Equals(activeScene, "Home"))
        {
            homeScene.gameObject.SetActive(false);
        }
    }
}


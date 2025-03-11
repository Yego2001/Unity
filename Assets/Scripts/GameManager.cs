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
    public float balance;
    public TextMeshProUGUI balanceText;
    public TextMeshProUGUI balanceText2;
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
        storeButton.onClick.AddListener(ChaigeScene);
        homeButton.onClick.AddListener(ChaigeScene);




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
        balanceText2.SetText(balance + "");
    }


    private void ChaigeScene()
    {
        if (String.Equals(activeScene, "Home"))
        {
            homeScene.gameObject.SetActive(true);
            storeScene.SetActive(false);
            activeScene = "Store";

        }
        else if (String.Equals(activeScene, "Store"))
        {
            homeScene.gameObject.SetActive(false);
            storeScene.SetActive(true);
            activeScene = "Home";

        }
    }
}



using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.UI;


public class BuyScript : MonoBehaviour
{
    public Button increaseTapByOneButton;
    public Button temporaryIncreaseInTapButton;
    public Button criticalTapButton;
    private GameManager gameManager;
    private int priceIncreaseTapByOne = 100;
    private int priceTemporaryIncreaseInTap = 250;
    private int priceCriticalTap = 1000;
    public TextMeshProUGUI priceIncreaseTapByOneText;
    public TextMeshProUGUI priceTemporaryIncreaseInTapText;
    public TextMeshProUGUI priceCriticalTapText;





    void Start()
    {
        increaseTapByOneButton.onClick.AddListener(TapByOne);
        temporaryIncreaseInTapButton.onClick.AddListener(TemporaryIncreaseInTap);
        criticalTapButton.onClick.AddListener(CriticalTap);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();



    }


    // Update is called once per frame
    void Update()
    {

    }

    private void TapByOne()
    {
        if (gameManager.balance >= priceIncreaseTapByOne)
        {
            gameManager.balance -= priceIncreaseTapByOne;
            gameManager.ScoreToAdd++;
            priceIncreaseTapByOne = (int)(priceIncreaseTapByOne * 1.2);
            priceIncreaseTapByOneText.SetText(priceIncreaseTapByOne + "");
            gameManager.updateText();

        }
    }


    private void TemporaryIncreaseInTap()
    {
        if (gameManager.balance >= priceTemporaryIncreaseInTap)
        {
            gameManager.multiplier = 5;
            gameManager.balance -= priceTemporaryIncreaseInTap;
            gameManager.ScoreToAdd *= gameManager.multiplier;
            priceTemporaryIncreaseInTap = (int)(priceTemporaryIncreaseInTap * 1.3);
            priceTemporaryIncreaseInTapText.SetText(priceTemporaryIncreaseInTap + "");
            gameManager.updateText();
            StartCoroutine(ResetMultiplier());


        }


    }

    private void CriticalTap()
    {
        if (gameManager.balance >= priceCriticalTap)
        {
            gameManager.multiplier = Random.Range(2, 11);
            gameManager.balance -= priceCriticalTap;
            gameManager.ScoreToAdd *= gameManager.multiplier;
            priceCriticalTap = (int)(priceCriticalTap * 1.5);
            priceCriticalTapText.SetText(priceCriticalTap + "");
            gameManager.updateText();
            StartCoroutine(ResetMultiplier());


        }


    }

    IEnumerator ResetMultiplier()
    {
        yield return new WaitForSeconds(10);
        gameManager.multiplier = 1;
    }



}

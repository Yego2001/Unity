
using System.Collections;

using TMPro;

using UnityEngine;

using UnityEngine.UI;


public class BuyScript : MonoBehaviour
{
    public Button increaseTapByOneButton;
    public Button temporaryIncreaseInTapButton;
    public Button criticalTapButton;
    public Button assistantButton;
    private GameManager gameManager;
    private int priceIncreaseTapByOne = 100;
    private int priceTemporaryIncreaseInTap = 250;
    private int priceCriticalTap = 1000;
    private int priceAssistant = 1500;
    public TextMeshProUGUI priceIncreaseTapByOneText;
    public TextMeshProUGUI priceTemporaryIncreaseInTapText;
    public TextMeshProUGUI priceCriticalTapText;
    public TextMeshProUGUI priceAssistantText;
    private AssistantScript assistantScript;





    void Start()
    {
        increaseTapByOneButton.onClick.AddListener(TapByOne);
        temporaryIncreaseInTapButton.onClick.AddListener(TemporaryIncreaseInTap);
        criticalTapButton.onClick.AddListener(CriticalTap);
        assistantButton.onClick.AddListener(Assistant);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        assistantScript = gameObject.GetComponent<AssistantScript>();
        



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
            priceIncreaseTapByOne = Mathf.CeilToInt(priceIncreaseTapByOne * 1.2f / 10f) * 10;
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
            priceTemporaryIncreaseInTap = Mathf.CeilToInt(priceTemporaryIncreaseInTap * 1.3f / 10f) * 10;
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
            priceCriticalTap = Mathf.CeilToInt(priceCriticalTap * 1.5f / 10f) * 10;
            priceCriticalTapText.SetText(priceCriticalTap + "");
            gameManager.updateText();
            StartCoroutine(ResetMultiplier());


        }


    }

    private void Assistant()
    {
        if (gameManager.balance >= priceAssistant)
        {
            gameManager.balance -= priceAssistant;
            
            gameManager.updateText();
        }
    }

    IEnumerator ResetMultiplier()
    {
        Debug.Log("Coroutine запущена");
        yield return new WaitForSeconds(10);
        Debug.Log("Время Закончилось");
        gameManager.multiplier = 1;

    }



}

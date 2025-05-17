using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssistantScript : MonoBehaviour
{
    public int accrualPerSecond = 0;
    private GameManager gameManager;


    void Start()
    {
        gameManager = gameObject.GetComponent<GameManager>();
        InvokeRepeating("UpdateBalance", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void UpdateBalance()
    {
        if (accrualPerSecond > 0)
        {
            gameManager.balance += accrualPerSecond;
            gameManager.updateText();
        }
    }
}

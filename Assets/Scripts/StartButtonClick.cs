using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonClick : MonoBehaviour
{
    private Button button;
    private Bird bird;
    public GameObject startScreen;

    void Start()
    {
        bird = GameObject.Find("Bird").GetComponent<Bird>();
        button = GetComponent<Button>();
        button.onClick.AddListener(StartButton);

    }
    public void StartButton()
    {
        bird.ResetGame();
        startScreen.SetActive(false);

    }
}

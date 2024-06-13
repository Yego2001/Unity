using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManager;

public class reStartButton : MonoBehaviour
{

    private Button button;
    private Bird bird;
    public GameObject goScreen;

    void Start()
    {
        bird = GameObject.Find("Bird").GetComponent<Bird>();
        button = GetComponent<Button>();
        button.onClick.AddListener(ReStartButton);

    }
    public void ReStartButton()
    {
        bird.ResetGame();
        goScreen.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}


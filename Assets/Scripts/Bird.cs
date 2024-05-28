using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private BirdMovie birdMovie;
    public int score;
    public GameObject goScreen;
    public GameObject startScreen;

    void Start()
    {
        birdMovie = GetComponent<BirdMovie>();
        ResetGame();
        goScreen.SetActive(false);
        startScreen.SetActive(true);
        Time.timeScale = 0;

    }



    public void IncreaceScore()
    {
        score++;
    }



    public void ResetGame()
    {
        score = 0;
        birdMovie.ResetBird();
        Time.timeScale = 1;
    }



    public void Loss()
    {
        Debug.Log("I am a loss");
        Time.timeScale = 0;
        goScreen.SetActive(true);

    }
}



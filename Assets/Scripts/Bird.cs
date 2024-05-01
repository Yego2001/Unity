using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private BirdMovie birdMovie;
    public int score;

    void Start()
    {
        birdMovie = GetComponent<BirdMovie>();
        ResetGame();
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void IncreaceScore()
    {
        score++;
    }



    public void ResetGame()
    {
        score = 0;
        birdMovie.ResetBird;
    }



    public void Loss()
    {
        Debug.Log("I am a loss");
        Time.timeScale = 0;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawn;
    private float spawnRate = 1;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI goverText;
    public int score = 0;
    public bool isGameActive;
    public Button restartButton;


    void Start()
    {
        isGameActive = true;
        score = 0;
        scoreText.text = "Score: " + score;
        StartCoroutine(SpawnTargets());



    }

    // Update is called once per frame
    void Update()
    {

    }

    //:)
    IEnumerator SpawnTargets()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int randomIndex = Random.Range(0, spawn.Length);
            Instantiate(spawn[randomIndex]);


        }
    }


    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }


    public void GameOver()
    {
        goverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
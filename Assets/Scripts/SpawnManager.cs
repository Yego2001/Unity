using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawn;
    private float spawnRate = 1;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI goverText;
    public int score = 0;


    void Start()
    {
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
        while (true)
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
    }
}
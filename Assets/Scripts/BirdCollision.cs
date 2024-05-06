using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    private Bird bird;
    void Start()
    {
        bird = GetComponent<Bird>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreZone")
        {
            bird.IncreaceScore();
        }
        else
        {
            bird.Loss();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipes;
    private Transform spawnPosition;
    private float startDelay = 2;
    private float spawnRate = 0.5f;
    void Start()
    {
        spawnPosition = GetComponent<Transform>();
        InvokeRepeating("SpawnObjects", startDelay, spawnRate);
    }

    // Update is called once per frame
    private void SpawnObjects()
    {
        spawnPosition.position = new Vector3(spawnPosition.position.x, Random.Range(-2.5f, 1f), spawnPosition.position.z);
        Instantiate(pipes, spawnPosition.position, pipes.transform.rotation);
    }




}
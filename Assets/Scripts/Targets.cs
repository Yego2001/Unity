using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    private Rigidbody targetsRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float spawnPozitionY = -2;
    private SpawnManager spawnManager;
    public int pointValue;
    public ParticleSystem explogionParticle;

    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        targetsRb = GetComponent<Rigidbody>();
        targetsRb.AddForce(Vector3.up * Random.Range(minSpeed, maxSpeed), ForceMode.Impulse);
        targetsRb.AddTorque(Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), ForceMode.Impulse);
        transform.position = new Vector2(Random.Range(-xRange, xRange), spawnPozitionY);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnMouseDown()
    {
        if (spawnManager.isGameActive == true)
        {
            Destroy(gameObject);
            spawnManager.UpdateScore(pointValue);
            Instantiate(explogionParticle, transform.position, explogionParticle.transform.rotation);
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            spawnManager.GameOver();
        }
    }
}

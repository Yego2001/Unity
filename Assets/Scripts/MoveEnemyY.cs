using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyY : MonoBehaviour
{
    public float maxUp;
    public float maxDown;
    public float enemySpeed = 2;
    public int chaingeDirection = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * chaingeDirection * enemySpeed * Time.deltaTime);
        if (transform.position.y > maxUp)
        {
            chaingeDirection = -1;

        }
        else if (transform.position.y < maxDown)
        {
            chaingeDirection = 1;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float XleftMove;
    public float XrightMove;
    private float maxRight;
    private float maxLeft;
    public float enemySpeed = 5;
    void Start()
    {
        maxRight = transform.position.x + XrightMove;
        maxLeft = transform.position.x + XleftMove;
    }

    // Update is called once per frame
    void Update()
    {
        int chaingeDirection = 1;
        transform.Translate(Vector3.right * chaingeDirection);
        if (transform.position.x < maxLeft || transform.position.x > maxRight)
        {
            chaingeDirection *= -1;
        }


    }

}

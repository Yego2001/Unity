using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBearEnemy : MonoBehaviour
{
    public float maxRight;
    public float maxLeft;
    public float enemySpeed = 5;
    private int chaingeDirection = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * chaingeDirection * enemySpeed * Time.deltaTime);
        if (transform.position.x > maxRight)
        {
            chaingeDirection = -1;

        }
        else if (transform.position.x < maxLeft)
        {
            chaingeDirection = 1;
        }
        transform.localScale = new Vector3(chaingeDirection * 4.4f, 4.4f, 4.4f);

    }

}

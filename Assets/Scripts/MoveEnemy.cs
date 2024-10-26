using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float XleftMove;
    public float XrightMove;
    private float maxRight;
    private float maxleft;
    void Start()
    {
        maxRight = transform.position.x + XrightMove;
        maxLeft = transform.position.x + XleftMove;
    }

    // Update is called once per frame
    void Update()
    {
        float chainge direction;
        if
        transform.Translate


    }
}

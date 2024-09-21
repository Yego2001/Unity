using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smouthTime;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        Vector3 pointPosition = Vector3.Lerp(transform.position, player.position, smouthTime);
        transform.position = pointPosition + offset;

    }
}

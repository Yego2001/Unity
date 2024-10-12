using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smouthTime;
    private Vector3 point;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        FollowMe();

    }



    private void FollowMe()
    {
        point.x = player.position.x;
        Vector3 pointPosition = Vector3.Lerp(transform.position, point, smouthTime * Time.deltaTime);
        transform.position = pointPosition;

    }
}

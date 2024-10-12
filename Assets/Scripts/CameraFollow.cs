using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smouthTime;
    private Vector3 point;
    public Transform leftboarder;
    public Transform rightboarder;
    public Transform upboarder;
    public Transform downboarder;
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
        Limit();

    }



    private void FollowMe()
    {
        point.x = player.position.x;
        point.y = player.position.y;
        Vector3 pointPosition = Vector3.Lerp(transform.position, point, smouthTime * Time.deltaTime);
        transform.position = pointPosition + offset;

    }


    private void Limit()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftboarder.position.x, rightboarder.position.x),
            Mathf.Clamp(transform.position.y, downboarder.position.y, upboarder.position.y),
            Mathf.Clamp(transform.position.z, -500, -500)
        );
    }
}

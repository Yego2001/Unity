using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BirdMovie : MonoBehaviour
{
    private Vector3 startPosition;
    private float tapForce = 501;
    private Rigidbody2D rb;
    public float speed = 0;
    public float rotationSpeed;
    public float maxRotationZ;
    public float minRotationZ;
    private Quaternion maxRotation;
    private Quaternion minRotation;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        maxRotation = Quaternion.Euler(0, 0, maxRotationZ);
        minRotation = Quaternion.Euler(0, 0, minRotationZ);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * tapForce, ForceMode2D.Force);
            rb.velocity = Vector3.right * speed;
            transform.rotation = maxRotation;
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, minRotation, Time.deltaTime * rotationSpeed);

    }



    public void ResetBird()
    {
        transform.position = startPosition;
        rb.velocity = Vector3.zero;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}

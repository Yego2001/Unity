using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovie : MonoBehaviour
{
    private Vector3 startPosition;
    private float tapForce = 11;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * tapForce, ForceMode2D.Force);
        }
    }
}

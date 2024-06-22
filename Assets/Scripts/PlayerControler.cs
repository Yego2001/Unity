using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 20;
    public float jumpSpeed = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float horisontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * moveSpeed * horisontalInput * Time.deltaTime);
        if (Input.GetAxis(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed * Time.deltaTime)
        }
    }
}

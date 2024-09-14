using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 500;
    public float shiftSpeed = 750;
    public float jumpSpeed = 333;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float speed = Input.GetKey(KeyCode.LeftShift) ? shiftSpeed : moveSpeed;

        float horisontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");


        rb.AddForce(Vector3.right * speed * horisontalInput * Time.deltaTime, ForceMode2D.Force);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode2D.Force);

        }




    }
}

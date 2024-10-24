using System;
using TMPro;
using UnityEngine;


public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 500;
    public float shiftSpeed = 750;
    public float jumpSpeed = 333;
    public Transform spawnPosition;
    public int scorePoint = 0;
    public TextMeshProUGUI scoreText;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreText.text = "Score: 0 ";
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


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Respawn"))
        {
            transform.position = spawnPosition.position;

        }

        if (col.gameObject.CompareTag("Cherry"))
        {
            scorePoint += UnityEngine.Random.Range(30, 60);
            Destroy(col.gameObject);
            scoreText.text = "Score: " + scorePoint;

        }
    }


}


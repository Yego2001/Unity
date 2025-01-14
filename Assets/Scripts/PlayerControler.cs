using System;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;


public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ctrlSpeed = 250;
    public float moveSpeed = 500;
    public float shiftSpeed = 750;
    public float jumpSpeed = 333;
    public Transform spawnPosition;
    public int scorePoint = 0;
    public TextMeshProUGUI scoreText;
    private Animator animator;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreText.text = "Score: 0 ";
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        float speed = Input.GetKey(KeyCode.LeftShift) ? shiftSpeed : moveSpeed;
        speed = Input.GetKey(KeyCode.LeftControl) ? ctrlSpeed : moveSpeed;
        float horisontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetTrigger("ctrlTrigger");
        }
        Debug.Log(rb.velocity.x);

        rb.AddForce(Vector3.right * speed * horisontalInput * Time.deltaTime, ForceMode2D.Force);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode2D.Force);

        }
        if (horisontalInput > 0)
        {
            transform.localScale = new Vector3(3.5f, 3.5f, 3.5f);
        }

        if (horisontalInput < 0)
        {
            transform.localScale = new Vector3(-3.5f, 3.5f, 3.5f);
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
        if (col.gameObject.CompareTag("Level 1"))
        {
            SceneManager.LoadScene("Level 2");
        }

        if (col.gameObject.CompareTag("Level 2"))
        {
            SceneManager.LoadScene("Level 3");
        }



        if (col.gameObject.CompareTag("Level 3"))
        {
            Debug.Log("Ананас");
            SceneManager.LoadScene("Level 4");
        }


    }


}


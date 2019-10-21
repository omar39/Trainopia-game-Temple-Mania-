using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumb : MonoBehaviour
{
    public float jumpForce;
    public KeyCode jumpKey;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isJumping = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jumpKey) && !isJumping)
        {
            rb.velocity=Vector2.up * jumpForce;
        }
        animator.SetBool("IsJumping", isJumping);

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "Box")
        {
            isJumping = true;
            print("exit");
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "Box")
        {
            isJumping = false;
            print("stay");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if ((collision.tag == "WaterLake" && gameObject.tag == "Water") 
            || (collision.tag == "FireFall" && gameObject.tag == "Fire"))
        {
            isJumping = false;
        }
    }






}

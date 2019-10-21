using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    Rigidbody2D rb;
    bool isColliding = false;
    bool isPressed = false;
    public KeyCode pushKey;
    public float speed = 4;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(Input.GetKey(pushKey))
        {
            isPressed = true;
        }
        else
        {
            isPressed = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Box")
        {
            collision.transform.Translate(-Mathf.Sign(rb.velocity.x) * speed * Time.deltaTime, 0, 0);
            print("Pushing");
        }
        
    }
}

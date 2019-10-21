using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    public Rigidbody2D mario3;

    public float speed2;

    public SpriteRenderer sprite2;

    private float direction2;
    void Update()
    {
        direction2 = mario3.transform.position.x;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //mario3.velocity = new Vector2(direction2 * speed2 * 2,0);
            transform.Translate(-speed2 * Time.deltaTime, 0, 0);
             sprite2.flipX = true;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
        
            //mario3.velocity = new Vector2(direction2 * speed2 * 2,0);
            transform.Translate(speed2 * Time.deltaTime, 0, 0);
            sprite2.flipX = false;
        }





    }
    
}

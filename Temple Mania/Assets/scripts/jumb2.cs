using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumb2 : MonoBehaviour
{

    public float speedo;

    public Rigidbody2D d;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            d.velocity=Vector2.up*speedo;
        }

    }
}

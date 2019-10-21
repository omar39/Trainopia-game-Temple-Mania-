using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Water"|| other.tag== "Air"|| other.tag== "Earth")
        {
            Destroy(other.gameObject);
        }
    }
    
}

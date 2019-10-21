using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    private Animator animator;
    public KeyCode right, left;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKey(left))
        {            
            transform.Translate(speed * Time.deltaTime, 0, 0);
            transform.rotation = new Quaternion(0, 180, 0, transform.rotation.w);
            animator.SetBool("IsRunning", true);
        }
        else if(Input.GetKey(right)) 
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            transform.rotation = new Quaternion(0, 0, 0, transform.rotation.w);
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
        
       
    }
}

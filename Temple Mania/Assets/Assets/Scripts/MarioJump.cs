using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioJump : MonoBehaviour
{
    Rigidbody2D rigidbody;
    GroundChecker Checker;
    Animator animator;
    public KeyCode JumpButton = KeyCode.Space;
    public float JumpForce=3;
    void Start()
    {
     rigidbody=GetComponent<Rigidbody2D>();
     Checker=GetComponent<GroundChecker>();
     animator=GetComponent<Animator>();
    }
    void Update()
    {
     if(Checker.OnGround&&Input.GetKey(JumpButton)){
         MakeJump(1);
         animator.SetBool("OnGround",Checker.OnGround);  
     }else{
         animator.SetTrigger("Jump");
         animator.SetBool("OnGround",Checker.OnGround);
     }
    }
    public void MakeJump(float force){
        rigidbody.velocity=Vector2.up*JumpForce*force;
    }
}

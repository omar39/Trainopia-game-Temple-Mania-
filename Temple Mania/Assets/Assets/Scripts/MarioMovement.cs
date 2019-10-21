using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{
    Transform transform;
    SpriteRenderer renderer;
    Animator animator;
    public float MarioSpeed=3;
    void Start()
    {
     transform=GetComponent<Transform>(); 
     renderer=GetComponent<SpriteRenderer>();
     animator=GetComponent<Animator>();  
    }
    void Update()
    {
     float InputOnX = Input.GetAxis("Horizontal");  
     Vector3 MarioDirction = new Vector3 (InputOnX , 0);
     transform.position += MarioDirction*MarioSpeed*Time.deltaTime;

     if(InputOnX>0){
         renderer.flipX=false;
         animator.SetBool("Run",true);
     } else if(InputOnX<0){
         renderer.flipX=true;
         animator.SetBool("Run",true);
     }else{
         renderer.flipX=false;
         animator.SetBool("Run",false);
     }
    }
}

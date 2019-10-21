using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    Transform CameraTransform;
    void Start()
    {
       CameraTransform=GetComponent<Transform>(); 
    }
    void Update()
    {
     Vector3 TargetDirction = new Vector3(Target.position.x,CameraTransform.position.y,CameraTransform.position.z);
     CameraTransform.position=TargetDirction;   
    }
}

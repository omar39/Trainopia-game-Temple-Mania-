using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    Transform transform;
    public float ObjectSpeeed;
    bool ObjectDirction;
    void Start()
    {
     transform=GetComponent<Transform>();
     ObjectDirction=true;
    }
    void Update()
    {
        if(ObjectDirction){
        Vector3 ObjectDirction = new Vector3(1*ObjectSpeeed,0,0);
        transform.position+=ObjectDirction*Time.deltaTime;
        }else{
             Vector3 ObjectDirction = new Vector3(-1*ObjectSpeeed,0,0);
        transform.position+=ObjectDirction*Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        ObjectDirction=!ObjectDirction;
    }
}

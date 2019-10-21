using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_bullet : MonoBehaviour

{   
    public float speed;
    public float delay;


    void Update()
    {
        transform.Translate(speed* Time.deltaTime, 0, 0);

        Destroy(gameObject, delay);
    }






}

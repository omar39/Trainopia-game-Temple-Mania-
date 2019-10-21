using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2 : MonoBehaviour
{
    public GameObject shot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Instantiate(shot, transform.position, Quaternion.identity);
        }
    
    
    
    }
}

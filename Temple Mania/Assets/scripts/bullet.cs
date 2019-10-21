using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject shot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(shot, transform.position, Quaternion.identity);
        }
    
    
    
    }


















}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getcoin : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject)
        {
            Destroy(this.gameObject);
            FindObjectOfType<AudioManager>().Play("Coin");
        }
    }
}

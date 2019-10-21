using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="Player"){
            Destroy(gameObject);
            other.gameObject.GetComponent<MarioJump>().MakeJump(0.5f);
        }
    }
}

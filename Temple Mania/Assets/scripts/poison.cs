using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poison : MonoBehaviour
{
      void OnTriggerEnter2D(Collider2D other)
      {
        Destroy(other.gameObject);
        FindObjectOfType<game_manager>().GameOver();
      }
}

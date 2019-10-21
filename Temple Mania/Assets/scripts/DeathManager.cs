using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Poison" || 
            (collision.tag == "WaterLake" && gameObject.tag == "Fire") ||
            (collision.tag =="FireFall" && gameObject.tag == "Water"))
        {
            FindObjectOfType<game_manager>().GameOver();
            Destroy(gameObject);
        }
    }
}

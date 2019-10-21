using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageKey : MonoBehaviour
{
    public GameObject Cage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(Cage);
        Destroy(gameObject);

    }
    IEnumerator Free()
    {
        yield return new WaitForSeconds(2f);
        FindObjectOfType<game_manager>().Win();

    }
}

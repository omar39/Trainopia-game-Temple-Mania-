using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Free());
    }
    IEnumerator Free()
    {
        yield return new WaitForSeconds(2f);
        FindObjectOfType<game_manager>().Win();

    }
}

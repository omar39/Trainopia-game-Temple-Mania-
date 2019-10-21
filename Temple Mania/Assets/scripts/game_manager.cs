using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject winPanel;
    public void GameOver()
    {
        Instantiate(gameOverPanel);
        FindObjectOfType<AudioManager>().Play("Lose");
    }    
    public void Win()
    {
        Instantiate(winPanel);
        FindObjectOfType<AudioManager>().Play("Win");
    }
    
}

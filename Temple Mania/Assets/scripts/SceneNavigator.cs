using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    private void Start()
    {
        if(gameObject.tag == "Win")
        {
            NextLevel();    
        }
    }
    public void Retry_btn()
    {
        print("retried");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        StartCoroutine(nextLevel());
        
    }
    IEnumerator nextLevel()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1 ) % 5);
    }
}

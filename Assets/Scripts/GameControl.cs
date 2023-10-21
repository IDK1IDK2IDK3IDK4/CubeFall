using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameControl : MonoBehaviour
{
   
    public bool gameOver = false;
    public float timer;
    public GameObject lose;
    public TextMeshProUGUI timer_text;
  
    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            timer = timer + Time.deltaTime;
            timer_text.text = timer.ToString("#.00");

        }
    }

    public void endGame()
    {
        gameOver = true;
        lose.SetActive(true);
        StartCoroutine(restart());
    }

    IEnumerator restart(){
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

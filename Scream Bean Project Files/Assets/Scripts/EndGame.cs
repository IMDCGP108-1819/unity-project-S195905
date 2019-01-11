using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{

  // Hides the gameover UI until the player runs out of lives

    void Start()
    {
        Time.timeScale = 1.0f;

        GameObject endGame = GameObject.FindGameObjectWithTag("GameOver");
        endGame.GetComponent<CanvasGroup>().interactable = false;
        endGame.GetComponent<CanvasGroup>().alpha = 0;
        endGame.GetComponent<CanvasGroup>().blocksRaycasts = false;
       

    }

    void Update()
    {


        if (Userinterfacelives.liveAmount <= 0)
        {
            Time.timeScale = 0.01f;
            GameObject endGame = GameObject.FindGameObjectWithTag("GameOver");
            endGame.GetComponent<CanvasGroup>().alpha = 1;
            endGame.GetComponent<CanvasGroup>().blocksRaycasts = true;
            Invoke("Interactable", 0.05f);
            Userinterfacelives.liveAmount = Mathf.Max(0);

        }
            
            
             

      



    }

    void Interactable()
    {

        GameObject endGame = GameObject.FindGameObjectWithTag("GameOver");
        endGame.GetComponent<CanvasGroup>().interactable = true;


    }



}





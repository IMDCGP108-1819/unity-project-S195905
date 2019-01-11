using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Return : MonoBehaviour
{
    //Resets the score when the player changes scenes
    public void EndGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        Userinterfacelives.liveAmount = 20;
        Userinterfacescore.scoreAmount = 0;

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //The code which I use to transition from scene to scene by way of functions and buttons assigned to these functions.

    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {

        Application.Quit();
    }

    public void EndGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}

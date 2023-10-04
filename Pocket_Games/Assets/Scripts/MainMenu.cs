using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // function to start game scene
    public void PlaySimpsonsGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    // function to start game scene
    public void PlayMemoryGame()
    {
        SceneManager.LoadSceneAsync(4);
    }

    // function to start game scene
    public void PlayCupGame()
    {
        SceneManager.LoadSceneAsync(7);
    }

    // function to quit game program
    public void QuitGame()
    {
        Application.Quit();
    }
}

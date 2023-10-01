using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    // function to start game scene
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
    // function to quit game program
    public void QuitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
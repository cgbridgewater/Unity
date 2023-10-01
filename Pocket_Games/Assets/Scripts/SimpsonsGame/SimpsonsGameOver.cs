using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // function to return to Simpsons menu
    public void SimpsonsMenu()
    {
        SceneManager.LoadSceneAsync(1);
    }
    // function to return to main menu
    public void ExitSimpsonsGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // function to restart the game
    public void RestartMemoryGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
    // function to return to main menu
    public void ExitMemoryGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

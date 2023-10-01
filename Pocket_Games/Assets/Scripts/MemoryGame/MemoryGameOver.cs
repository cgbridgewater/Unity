using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemoryGameOver : MonoBehaviour
{
    // function to restart the game
    public void MemoryMenu()
    {
        SceneManager.LoadSceneAsync(4);
    }

    // function to return to memory menu
    public void ExitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    // // function to return to the main menu page
    // public void ReturnToMain()
    // {
    //     SceneManager.LoadSceneAsync(0);
    // }
}

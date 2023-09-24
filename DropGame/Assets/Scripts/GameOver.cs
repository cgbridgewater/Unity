using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // function to return to main menu
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

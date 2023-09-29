using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    //     void Start()
    // {
    //     // // Get default score
    //     // GetComponent<ShowAttempts>().GetAttempts();
    // }



    // function to restart the game
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CupsIntro : MonoBehaviour
{
    // function to start game scene
    public void PlayCupsGame()
    {
        SceneManager.LoadSceneAsync(8);
    }
    // function to quit game program
    public void QuitCupsGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
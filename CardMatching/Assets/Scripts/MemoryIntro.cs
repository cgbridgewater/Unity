using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemoryIntro : MonoBehaviour
{
    // function to start game scene
    public void PlayMemoryGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    // function to quit game program
    public void QuitMemoryGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    // Audio
    public AudioSource src;
    public AudioClip sfx1;

    void Start()
    {
        src.clip = sfx1;
        src.Play();
    }

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
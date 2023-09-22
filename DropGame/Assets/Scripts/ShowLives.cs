using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This allows us to use the text
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class ShowLives : MonoBehaviour
{
    // initial lives count
    private int lives = 3;

    // bonus counter
    private int bonusCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // set initial lives count on game start
        GetComponent<Text>().text = "Lives: " + this.lives;
    }

    public void loseLife()
        {
            this.lives -= 1;
            GetComponent<Text>().text = "Lives: " + this.lives;
            this.bonusCount = 0;
            // add logic if lives == 0
            if(lives == 0)
            {
                Time.timeScale = 0;
            }
        }

    public void addLife()
        {
            this.bonusCount += 1;
            if(bonusCount == 5)
            {
            this.lives += 1;
            GetComponent<Text>().text = "Lives: " + this.lives;
            bonusCount = 0;
            }
        }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this allows text component
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    // Keep track of high score


    // Keep track of a score from the start of the game
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Get default score
        GetComponent<Text>().text = "Score: " + this.score;
    }

    public void incrementScore(int val)
    {
        // Update score and add it to previous score
        this.score += val;
        if(score < 0){
            this.score = 0;
        }
        GetComponent<Text>().text = "Score: " + this.score;
    }

}

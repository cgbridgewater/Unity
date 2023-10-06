using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAttempts : MonoBehaviour
{
    // string attemptKey = "Attempts: ";
    // Keep track of attempts from game start
    private int attempts = 0;


    // Start is called before the first frame update
    void Start()
    {
        // get default
        GetComponent<Text>().text = "Attempts: " + this.attempts;
    }

    // method to add to increment attempts
    public void incrementAttempts(int val)
    {
        // update attempts
        this.attempts += val;
        GetComponent<Text>().text = "Attempts: " + this.attempts;
    }

        public int GetAttempts(){
        return attempts;
    }
}

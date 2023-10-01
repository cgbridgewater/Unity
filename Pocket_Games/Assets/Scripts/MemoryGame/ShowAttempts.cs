using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAttempts : MonoBehaviour
{
    // string attemptKey = "Attempts: ";
    // Keep track of attempts from game start
    private int attempts = 0;

    // [SerializeField]
    // private FloatSO AttemptSO;

    
    // Start is called before the first frame update
    void Start()
    {
        // get default
        GetComponent<Text>().text = "Attempts: " + this.attempts;
        // AttemptSO.Value = 0;

    }

    // method to add to increment attempts
    public void incrementAttempts(int val)
    {
        // update attempts
        this.attempts += val;
        GetComponent<Text>().text = "Attempts: " + this.attempts;
        // AttemptSO.Value += val;
        // GetComponent<Text>().text = "Attempts: " + AttemptSO.Value;
    }

    //     public void GetAttempts(){
    //     GetComponent<Text>().text = "Attempts: " + this.attempts;
    // }
}

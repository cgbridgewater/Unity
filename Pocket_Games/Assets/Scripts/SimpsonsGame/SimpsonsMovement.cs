using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // set drop motion vector2(angle,speed)
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1f, 1f),Random.Range(-2.1f, -6.3f));
        // destroy object after time out, giving enough time to clear game screen
        Destroy(this.gameObject, 10);
    }
    // method for clicking on objects
    void OnMouseDown()
    {
        Destroy(this.gameObject);
        // Increase score when simpson icon clicked
        if(this.gameObject.tag == "SimpsonIcon")
        {
            GameObject scoreText = GameObject.Find("ScoreText");
            scoreText.GetComponent<ShowScore>().incrementScore(100);
        }
        // Increase score when quimby icon clicked
        if(this.gameObject.tag == "BigsbyIcon")
        {
            GameObject scoreText = GameObject.Find("ScoreText");
            scoreText.GetComponent<ShowScore>().incrementScore(300);
            GameObject livesText = GameObject.Find("LivesText");
            livesText.GetComponent<ShowLives>().addLife();
        }
        // Reduce score when donut icon is clicked and remove 1 life
        if(this.gameObject.tag == "DonutIcon")
        {
            // deduct life if donut is clicked
            GameObject livesText = GameObject.Find("LivesText");
            livesText.GetComponent<ShowLives>().loseLife();
            // deduct points if dunut is clicked and life still exists
            GameObject scoreText = GameObject.Find("ScoreText");
            scoreText.GetComponent<ShowScore>().incrementScore(-200);
        }
    }
}
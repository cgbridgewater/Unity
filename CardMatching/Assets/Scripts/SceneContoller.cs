using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneContoller : MonoBehaviour
{
    public MemoryCard origionalCard;
    public Sprite[] images;

    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3, sfx4;

    public const int gridRows = 4;
    public const int gridCols = 8;
    public const float offsetX = 3.0f;
    public const float offsetY = 3.0f;

    private MemoryCard _firstChoice;
    private MemoryCard _secondChoice;
    private int matches = 0;
    public bool canReveal { get { return _secondChoice == null;} }

    // Start is called before the first frame update
    void Start()
    {
        src.clip = sfx4;
        src.Play();
        // get start position
        Vector3 startPos = origionalCard.transform.position;
        // ensure matches is zeroed out
        matches = 0;

        //This represents our 4 sprite options as index values
        List<int> numbers = new List<int>() {0,0,0,0,1,1,1,1,2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6,7,7,7,7};
        numbers = Shuffle(numbers); 
        // set grid size
        for(int i = 0; i < gridCols; i++)
        {
            for(int j = 0; j < gridRows; j++)
            {
                // set cards to grid
                MemoryCard card;
                // Dont add a new card where the old one is
                if(i == 0 && j == 0)
                {
                    card = origionalCard;
                } else {
                    card = Instantiate(origionalCard) as MemoryCard;
                }
                // Assign image to our cards
                int id = numbers[0]; // grab first number of list
                card.SetCard(id, images[id]); // set image based on number
                numbers.RemoveAt(0); // remove that option from the list
                // Set the card somewhere
                float posX = (offsetX * i) + startPos.x;
                float posY = -(offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }
    }

    private List<int> Shuffle(List<int> arr)
    {
        for(int i = 0; i < arr.Count; i++)
        {
            int idx = Random.Range(0, arr.Count);
            int temp = arr[i];
            arr[i] = arr[idx];
            arr[idx] = temp;
        }
        return arr;
    }

    public void CardRevealed(MemoryCard card)
    {
        if(_firstChoice == null)
        {
            _firstChoice = card;
            src.clip = sfx1;
            src.Play();
        } else {
            _secondChoice = card;
            // then check for match
            StartCoroutine(CheckMatch());
            src.clip = sfx1;
            src.Play();
        }
    }

    private IEnumerator CheckMatch()
    {
        // match check
        if(_firstChoice.id == _secondChoice.id)
        {
            // we have a match increase attempt count +1
            yield return new WaitForSeconds(.5f);
            GameObject attempt = GameObject.Find("AttemptCounter");
            attempt.GetComponent<ShowAttempts>().incrementAttempts(1);
            matches ++;
            if(matches == 16){
                SceneManager.LoadScene(2);
            }
            src.clip = sfx2;
            src.Play();
        } else {
            // we do not have a match increase attempt count +1
            yield return new WaitForSeconds(.5f);
            _firstChoice.Unreveal();
            _secondChoice.Unreveal();
            GameObject attempt = GameObject.Find("AttemptCounter");
            attempt.GetComponent<ShowAttempts>().incrementAttempts(1);
            src.clip = sfx3;
            src.Play();
        }
        _firstChoice = null;
        _secondChoice = null;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    // function to return to memory menu
    public void ExitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneContoller : MonoBehaviour
{
    public MemoryCard origionalCard;
    public Sprite[] images;

    public const int gridRows = 2;
    public const int gridCols = 4;
    public const float offsetX = 4.5f;
    public const float offsetY = 6.5f;

    private MemoryCard _firstChoice;
    private MemoryCard _secondChoice;
    public bool canReveal { get { return _secondChoice == null;} }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 startPos = origionalCard.transform.position;

        //This represents our 4 sprite options as index values
        List<int> numbers = new List<int>() {0,0,1,1,2,2,3,3};
        numbers = Shuffle(numbers); 



        for(int i = 0; i < gridCols; i++)
        {
            for(int j = 0; j < gridRows; j++)
            {
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
        } else {
            _secondChoice = card;
            // then check for match
            StartCoroutine(CheckMatch());
        }
    }

    private IEnumerator CheckMatch()
    {
        // match check
        if(_firstChoice.id == _secondChoice.id)
        {
            // we have a match
        } else {
            // we do not have a match
            yield return new WaitForSeconds(.5f);
            _firstChoice.Unreveal();
            _secondChoice.Unreveal();
        }
        _firstChoice = null;
        _secondChoice = null;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

}
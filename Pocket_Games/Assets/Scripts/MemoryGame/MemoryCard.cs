using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    // access to card that will be deactivated
    public GameObject cardBack;
    public Sprite image;
    public SceneContoller controller;


    private int _id;
    public int id {get {return _id;}}

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    // function to check if card has been clicked
    public void OnMouseDown()
    {
        //deactivate visibility of the cardBack when clicked
        //First, Check if card back is already deactivated or not
        if(cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }
}

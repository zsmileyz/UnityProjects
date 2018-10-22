using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject[] cards;
    public Image deckPos;

    public int deckSize = 40;
    int randomInt;


    void Start()
    {
        StartingDeck();        
    }

    void Update()
    {
       
    }

    void StartingDeck()
    {
        randomInt = Random.Range(0, cards.Length);
        Instantiate(cards[randomInt], deckPos.transform);

    }

}
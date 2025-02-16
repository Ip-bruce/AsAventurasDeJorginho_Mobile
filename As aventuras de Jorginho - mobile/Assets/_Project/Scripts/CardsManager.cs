using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Manages the all the logic of the cards
public class CardsManager : MonoBehaviour
{
    //Variables
    public RectTransform [] dragableCards;
    public GameObject [] displayCards;
    public RectTransform[] dragableCardsHolder;
    public CardDrop cardDrop;
    private int points = 0;

    private GameObject currentDisplayCard;

    private void Start() 
    {
        ShowCards();    
        DisplayCards();

        cardDrop = GetComponent<CardDrop>();
    }

    private void Update()
    {
        // if(Input.GetKey(KeyCode.A))
        // {
        //     ShowCards();
        // }

        //Win Condition
        if(points == 5)
        {
            Debug.Log("Gahou!!!");
        }

    }

    //Show and organize the Dragable Cards
    private void ShowCards()
    {
         int dragableCardsQuantity = dragableCards.Length - 1; 

        for(int i = 0; i <= dragableCardsQuantity; i++)
        {
            dragableCards[i].anchoredPosition = dragableCardsHolder[i].anchoredPosition;       
        }
    }

    //Void responsable for Display the cards with the signs
    public void DisplayCards()
    {
        for(int i = 0; i<= displayCards.Length - 1; i++)
        {
            currentDisplayCard = displayCards[Random.Range(0,displayCards.Length - 1)];
            if(currentDisplayCard != null) currentDisplayCard.SetActive(true);

            if(i == 4) i = 0;   
        }

        // (displayCards[Random.Range(0,displayCards.Length - 1)] != null) 
        // displayCards[Random.Range(0,displayCards.Length - 1)].SetActive(true);
    }


    public void CheckCard(string currentCardTag, GameObject currentCard)
    {

        Debug.Log("Check Card: " + currentCardTag);

         int dragableCardsQuantity = dragableCards.Length - 1; 

        for(int i = 0; i <= dragableCardsQuantity; i++)
        {
            if(displayCards[i].activeSelf)
            {
                string displayCardsTag = displayCards[i].tag; 
                if( displayCardsTag == currentCardTag)
                {
                    Destroy(currentCard);
                    Destroy(displayCards[i]);
                    ShowCards();
                    DisplayCards();
                    points++;
                }
            }
        }
    }

}

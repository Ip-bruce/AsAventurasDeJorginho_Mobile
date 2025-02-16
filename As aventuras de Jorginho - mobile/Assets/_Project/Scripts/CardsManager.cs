using System.Collections.Generic;
using UnityEngine;

//Manages the all the logic of the cards
public class CardsManager : MonoBehaviour
{
    //Variables
    public RectTransform[] dragableCards;
    public List<GameObject> displayCards;
    public List<int> numbers;
    public RectTransform[] dragableCardsHolder;
    public CardDrop cardDrop;
    private int points = 0;



    private GameObject currentDisplayCard;

    private void Start()
    {

        DisplayCards();
        ShowCards();

        cardDrop = GetComponent<CardDrop>();
    }

    private void Update()
    {
        // if(Input.GetKey(KeyCode.A))
        // {
        //     ShowCards();
        // }

        
       

    }

    //Show and organize the Dragable Cards
    private void ShowCards()
    {
        int dragableCardsQuantity = dragableCards.Length - 1;

        for (int i = 0; i <= dragableCardsQuantity; i++)
        {
            dragableCards[i].anchoredPosition = dragableCardsHolder[i].anchoredPosition;
        }
    }

    //Void responsable for Display the cards with the signs
    public void DisplayCards()
    {
        if (numbers.Count > 0)
        {
            int theNumber = numbers[Random.Range(0, numbers.Count)];
            numbers.Remove(theNumber);
            
            //currentDisplayCard = displayCards[Random.Range(0,displayCards.Count)];

            currentDisplayCard = displayCards[theNumber];
            
            if (currentDisplayCard != null)
            {
                
                currentDisplayCard.SetActive(true);
            }
            else
            {

                return;
            }

        }
        else
        {
            Debug.LogError("Ganhou !!!!!");
        }





    }


    public void CheckCard(string currentCardTag, GameObject currentCard)
    {

        int dragableCardsQuantity = dragableCards.Length - 1;

        for (int i = 0; i <= dragableCardsQuantity; i++)
        {
            if (displayCards[i].activeSelf)
            {
                string displayCardsTag = displayCards[i].tag;
                if (displayCardsTag == currentCardTag)
                {

                    currentCard.SetActive(false);
                    displayCards[i].SetActive(false);
                    //displayCards.Remove(displayCards[i]);
                    //Destroy(displayCards[i]);
                    ShowCards();
                    DisplayCards();
                    points++;
                }
            }
        }
    }

}

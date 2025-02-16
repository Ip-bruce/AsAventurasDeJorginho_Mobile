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
    [SerializeField] CardDrop cardDrop;


    private void Start() 
    {
        ShowCards();    
        DisplayCards();
    }

    private void Update()
    {
        // if(Input.GetKey(KeyCode.A))
        // {
        //     ShowCards();
        // }
    }


    private void ShowCards()
    {
         int dragableCardsQuantity = dragableCards.Length - 1; 

        for(int i = 0; i <= dragableCardsQuantity; i++)
        {
            dragableCards[i].anchoredPosition = dragableCardsHolder[i].anchoredPosition;       
        }
    }

    //Void responsable for Display the cards with the signs
    private void DisplayCards()
    {
        displayCards[Random.Range(0,4)].SetActive(true);
    }

    public static void CheckCard()
    {
        
    }

}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Manages the all the logic of the cards
public class CardsManager : MonoBehaviour
{
    //Variables
    public RectTransform[] dragableCards;
    public List<GameObject> displayCards;
    public List<int> numbers;
    public RectTransform[] dragableCardsHolder;
    public CardDrop cardDrop;
    [SerializeField] int points = 0;
    [SerializeField] ScoreManager scoreManager;
    //Panels
    public GameObject pointPanel;



    private GameObject currentDisplayCard;

    private void Start()
    {

        //DisplayCards();
        //ShowCards();

        cardDrop = GetComponent<CardDrop>();
    }

    private void Update()
    {       

    }

    //Show and organize the Dragable Cards
    public void ShowCards()
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
           Score(points);
        }





    }


    public void Score(int points)
    {
        if (scoreManager != null && scoreManager.scoreImages.Count > points && pointPanel != null)
        {
            Image pointPanelImage = pointPanel.GetComponent<Image>();

            if (pointPanelImage != null)
            {
                pointPanelImage.sprite = scoreManager.scoreImages[points];
                pointPanel.SetActive(true);
            }
        }

        //switch (points)
        //{
        //    case 1:
        //        Debug.LogWarning("Baixo: " + points);
        //        break;
        //    case 2:
        //    case 3:
        //    case 4:
        //        Debug.LogWarning("Médio: " + points);
        //        break;
        //    case 5:
        //        Debug.LogWarning("Pontuação Máxima: " + points);
        //        break;
        //    case 0:
        //        Debug.LogWarning("PASSOU: " + points);
        //        break;
        //}
    }

    public void CheckCard( GameObject currentCard)
    {
  
                if (currentDisplayCard.CompareTag(currentCard.tag))
                {
                    points++;

                    currentCard.SetActive(false);
                    currentDisplayCard.SetActive(false);
                    ShowCards();
                    DisplayCards();
                }
                else if (currentDisplayCard.tag != currentCard.tag)
                {
                    Debug.LogError("Errou: " + currentDisplayCard.tag);
                    points--;
                    ShowCards();
                }
    }

}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Manages the all the logic of the cards
public class CardsManager : MonoBehaviour
{

    public VlibrasManager vlibrasManager;

    //Variables
    public RectTransform[] dragableCards;
    public List<GameObject> displayCards;
    public List<int> numbers;
    public RectTransform[] dragableCardsHolder;
    public CardDrop cardDrop;
    [SerializeField] int points = 0;
    [SerializeField] int errors = 0;
    [SerializeField] ScoreManager scoreManager;
    private GameObject currentDisplayCard;
    //Panels
    public GameObject pointPanel;
    //Audio
    [SerializeField] AudioManager audioManager;



    private void Start()
    {
        cardDrop = GetComponent<CardDrop>();
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
        
        audioManager.PlayAudio(audioManager.popupAudioClip);
        pointPanel.SetActive(true);
          ScoreManager.instance.SetSprite(5-errors);
         
    }

    public void CheckCard(GameObject currentCard)
    {

        if (currentDisplayCard.CompareTag(currentCard.tag))
        {
            audioManager.PlayAudio(audioManager.hitAudioClip);
            PlayLibras(currentCard.tag);
            Debug.Log("Tag de Carta Atual: "+currentCard.tag);
            points++;
            currentCard.SetActive(false);
            currentDisplayCard.SetActive(false);
            ShowCards();
            DisplayCards();
        }
        else if (currentDisplayCard.tag != currentCard.tag)
        {
            audioManager.PlayAudio(audioManager.missAudioClip);

            errors++;
            if (errors > 5)
            {
                errors = 5;
            }
            ShowCards();
        }
    }

    public void PlayLibras(string CardName)
    {
        vlibrasManager.VideoManagerAnimal(CardName);    
    }

    

}

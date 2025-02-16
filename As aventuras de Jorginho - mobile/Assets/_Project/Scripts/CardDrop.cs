using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardDrop : MonoBehaviour, IDropHandler
{
    public CardsManager cardsManager;
    public  string currentCardTag = "";
    public GameObject currentCard;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            currentCardTag = eventData.pointerDrag.tag;  
            currentCard = eventData.pointerDrag;
            currentCard.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            cardsManager.CheckCard( currentCard);
        }
        Debug.Log("Dropped");
    }
}

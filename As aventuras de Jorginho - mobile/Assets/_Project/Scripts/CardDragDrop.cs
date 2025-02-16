using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardDragDrop : MonoBehaviour,IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;

    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

    }


    public void OnBeginDrag(PointerEventData eventData)
    {
         Debug.Log("Begin Drag");
         canvasGroup.alpha = .6f;
         canvasGroup.blocksRaycasts = false;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        //Move the object along with the mouse
        canvasGroup.alpha = 1;
         canvasGroup.blocksRaycasts = true;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Point Down");
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag!!");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

}

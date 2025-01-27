//using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasgroup;
   // public GameObject collider;
    private void Awake()
    {
       
        rectTransform = GetComponent<RectTransform>();
        canvasgroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("On Begin Drag");
        canvasgroup.alpha = .6f;
        canvasgroup.blocksRaycasts = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("On pointer down");
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("On End Drag");
        canvasgroup.alpha = 1;
        canvasgroup.blocksRaycasts = true;
        


    }
    void OnTriggerStay2D(Collider2D other)
    {
       
        if (other.gameObject.tag == "Drop")
        {
            Debug.Log("Dropou");  
        }
       

    }



}

using UnityEngine;
using System.Collections;
public class PanelSwitch : MonoBehaviour
{
    [SerializeField] GameObject panel;
    public CanvasGroup menuPanel;
    [SerializeField] GameObject panelMemorize;
    [SerializeField] CardsManager cardsManager;  
    [SerializeField]bool canStart = false;
    [SerializeField]float timer = 0;
    
    public void PlayGame()
    {
        //canStart = true;
        //activate();
        openClose();
        StartCoroutine(Routine());
        
        //Invoke(nameof(Deactivate), 5f);
        
        
    }

    //private void Update()
    //{
    //    Debug.Log("Antes");
    //    if (!canStart)
    //    {
    //        return;
    //    }
    //    timer += 1;
    //    Debug.Log("depois");
    //    if (timer >= 200)
    //    {
    //        canStart = false;
    //        Deactivate();
    //    }
    //}

    //private void activate()
    //{
    //    panelMemorize.SetActive(true);
    //}
    //void Deactivate()
    //{
    //    panelMemorize.SetActive(false);
    //    cardsManager.DisplayCards();
    //    cardsManager.ShowCards();
    //}

    IEnumerator Routine()
    {
        panelMemorize.SetActive(true);
        yield return new WaitForSecondsRealtime(5);

        panelMemorize.SetActive(false);
        cardsManager.DisplayCards();
        cardsManager.ShowCards();
    }

    

    public void infoButton()
    {
        if(panelMemorize.activeInHierarchy)
        {
            panelMemorize.SetActive(false);
        }
        else
        {

            panelMemorize.SetActive(true) ;
        }
    }

    private void openClose()
    {
        if (panel.activeInHierarchy)
        {
            //panel.SetActive(false);
            menuPanel.alpha = 0f;
            menuPanel.blocksRaycasts = false;
            menuPanel.interactable = false; 
        }
        else
        {
            //panel.SetActive(true);
            menuPanel.alpha = 1f;
            menuPanel.blocksRaycasts = true;
            menuPanel.interactable = true;
        }
    }



}

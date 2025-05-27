using UnityEngine;
using System.Collections;
public class PanelSwitch : MonoBehaviour
{
    public GameObject VlibrasPanel;
    [SerializeField] GameObject panel;
    public CanvasGroup menuPanel;
    [SerializeField] GameObject panelMemorize;
    [SerializeField] CardsManager cardsManager;  
    [SerializeField]bool canStart = false;
    [SerializeField]float timer = 0;
    
    public void PlayGame()
    {
       
        openClose();
        StartCoroutine(Routine());
       
        
        
    }

  

    IEnumerator Routine()
    {
        panelMemorize.SetActive(true);
        yield return new WaitForSecondsRealtime(5);

        panelMemorize.SetActive(false);
        VlibrasPanel.SetActive(true);
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

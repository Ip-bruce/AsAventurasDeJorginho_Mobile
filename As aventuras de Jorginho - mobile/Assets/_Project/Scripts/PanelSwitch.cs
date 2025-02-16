using UnityEngine;

public class PanelSwitch : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject panelMemorize;
    [SerializeField] CardsManager cardsManager;
    public void PlayGame()
    {
        panelMemorize.SetActive(true);
        Invoke(nameof(Deactivate), 5f);
    }

    void Deactivate()
    {
        panelMemorize.SetActive(false);
        cardsManager.DisplayCards();
        cardsManager.ShowCards();
    }
       

    public void openClose()
    {
        if (panel.activeInHierarchy)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }



}

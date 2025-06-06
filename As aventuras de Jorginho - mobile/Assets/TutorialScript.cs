using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject tutorialPanel;


    // Start is called before the first frame update
    void Start()
    {
        tutorialPanel.SetActive(true);
        StartCoroutine(TutorialCoroutine());
    }

    IEnumerator TutorialCoroutine()
    {
  //      Time.timeScale = 0;
        yield return new WaitForSeconds(5);
//        Time.timeScale = 1;
        CloseTutorial();
    }
    
    public void CloseTutorial()
    {
        tutorialPanel.SetActive(false);
    }
}

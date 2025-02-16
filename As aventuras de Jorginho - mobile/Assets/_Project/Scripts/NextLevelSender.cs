using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelSender : MonoBehaviour
{
    public string nextLevelName;
    public LevelManager levelManager;
    public GameObject panel;


    public void Start()
    {
        panel.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")) 
        {
         panel.SetActive(true);

            Time.timeScale = 0f;

        }    
                 
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        levelManager.NextLevel(nextLevelName);
    }
}

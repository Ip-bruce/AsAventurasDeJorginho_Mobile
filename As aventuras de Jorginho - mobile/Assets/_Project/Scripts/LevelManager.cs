using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
  
    public GameObject[] colectableObjects;
    public GameObject nestLevelDoor;
    public bool allColected = false;

    private void Start()
    {
        allColected = false;
    }

    public void Update()
    {
        AllCollected();
        if(allColected)
        {
            Destroy(nestLevelDoor);
            PlayerMovement.colectables = 0;
        }    
    }

    public void NextLevel(string SceneName )
    {
        if (Time.timeScale < 1)
        {
            Time.timeScale = 1;
            
            SceneManager.LoadScene(SceneName);
        }
            SceneManager.LoadScene(SceneName);

    }

    void AllCollected()
    {
       
        int allColectables = colectableObjects.Length;
        if( allColectables ==  PlayerMovement.colectables)
        {
            allColected = true;
        }
    }

}

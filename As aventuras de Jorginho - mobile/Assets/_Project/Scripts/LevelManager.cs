using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
  
    public GameObject[] colectableObjects;
    public GameObject nestLevelDoor;


    public bool allColected = false;



    public void Update()
    {
        AllCollected();
        if(allColected)
        {
            Debug.Log("Coletados, Só Abrir o Portão");
            Destroy(nestLevelDoor);
        }    
    }

    public void NextLevel(string SceneName )
    {
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

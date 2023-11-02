using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelSender : MonoBehaviour
{
    public string nextLevelName;
    public LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")) levelManager.NextLevel(nextLevelName);    
    }
}

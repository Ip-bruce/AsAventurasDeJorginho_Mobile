
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    //Scene Change
    public void SceneLoader(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}

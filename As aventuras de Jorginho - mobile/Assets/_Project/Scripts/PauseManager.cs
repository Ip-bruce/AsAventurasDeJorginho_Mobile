using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{

    public GameObject PauseCanvas;
    public bool IsPaused = false;
    //Audio
    public Slider AudioSlider;
    public AudioSource LevelAudio;

    // Start is called before the first frame update
    void Start()
    {
        PauseCanvas.SetActive(false);
        AudioSlider.value = LevelAudio.volume;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
           PauseGame();
           Debug.Log("ESC APERTADO");
        }
        //Audio Configurations

        LevelAudio.volume = AudioSlider.value;


    }

    public void PauseGame()
    {
           
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void ResumeGame()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = true;
    }


}

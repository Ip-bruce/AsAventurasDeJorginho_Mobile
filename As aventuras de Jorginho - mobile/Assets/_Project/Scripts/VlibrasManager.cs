using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;
using System.Collections;

public class VlibrasManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Vlibras Vídeos")]
    public VideoClip jogar;
    public VideoClip creditos;
    public VideoClip voltar;
    public VideoClip sair;
    public VideoClip macaco;
    public VideoClip galinha;
    public VideoClip leão;
    public VideoClip peixe;
    public VideoClip girafa;
    public VideoClip bonus;

    [Header("Video Player")]
    public VideoPlayer videoPlayer;
    [SerializeField]private bool isVlibrasPanel = false;

    [Header ("Video Player Panel")]
    public GameObject vLibrasPanel;

    [Header("LevelManager")]
    public LevelManager levelManager;  

    [Header("PausePanel")]
    public GameObject pausePanel;


    void Start()
    {
        if (videoPlayer == null)
            videoPlayer = gameObject.AddComponent<VideoPlayer>();

        videoPlayer.playOnAwake = false;


        vLibrasPanel.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       // VlibrasPanelView();
             vLibrasPanel.SetActive(true);

        VideoManager();
    }

    public void OnPointerExit(PointerEventData eventData)
    {

            videoPlayer.Stop();
            vLibrasPanel.SetActive(false);

    }

    public void Update()
    {
        if(levelManager.colectableObjects[0].activeSelf == false)
        {
            vLibrasPanel.SetActive(true);
            VideoClip selectedClip = null;
            selectedClip = jogar;
            videoPlayer.Play();
        }

        if(pausePanel.activeSelf == false)
        {
            vLibrasPanel.SetActive(false);
        }
    }


    // public void VlibrasPanelView()
    // {
    //     if(isVlibrasPanel == true)
    //     {
    //          vLibrasPanel.SetActive(true);
    //     }
    //     else
    //     {
    //         vLibrasPanel.SetActive(false);
    //     }
    // } 
    


    public void VideoManager()
    {
        VideoClip selectedClip = null;

        switch (this.gameObject.name)
        {
            case "Jogar":    selectedClip = jogar; break;
            case "Creditos": selectedClip = creditos; break;
            case "Voltar":   selectedClip = voltar; break;
            case "Sair":     selectedClip = sair; break;
            case "Macaco":   selectedClip = macaco; break;
            case "Galinha":  selectedClip = galinha; break;
            case "Leão":     selectedClip = leão; break; // sem acento para casar com o texto
            case "Peixe":    selectedClip = peixe; break;
            case "Girafa":   selectedClip = girafa; break;
            case "Bonus":    selectedClip = bonus; break;
        }

        if (selectedClip != null)
        {
            videoPlayer.clip = selectedClip;
            videoPlayer.Play();
        }
        else
        {
            Debug.LogWarning("Nenhum vídeo atribuído para o estado: ");
        }
    }

    public void VideoManagerAnimal(String name)
    {
        VideoClip selectedClip = null;

          switch (name)
        {
            case "Jogar":    selectedClip = jogar; break;
            case "Creditos": selectedClip = creditos; break;
            case "Voltar":   selectedClip = voltar; break;
            case "Sair":     selectedClip = sair; break;
            case "Macaco":   selectedClip = macaco; break;
            case "Galinha":  selectedClip = galinha; break;
            case "Leão":     selectedClip = leão; break; // sem acento para casar com o texto // sem acento para casar com o texto
            case "Peixe":    selectedClip = peixe; break;
            case "Girafa":   selectedClip = girafa; break;
            case "Bonus":    selectedClip = bonus; break;
        }
         if (selectedClip != null)
        {
            videoPlayer.clip = selectedClip;
            videoPlayer.Play();
            //StartCoroutine(TimeWait());
        }
    }

    // IEnumerator TimeWait()
    // {
    //     yield return new WaitForSecondsRealtime(2);
    //     Debug.Log("PASSOU 2 SEGUNDOS !!!!!!!!!!!!!!!!!!!!!!!!!!");
        
    // }
}

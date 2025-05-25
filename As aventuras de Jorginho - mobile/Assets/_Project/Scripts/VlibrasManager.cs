using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class VlibrasManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Vlibras Vídeos")]
    public VideoClip jogar;
    public VideoClip creditos;
    public VideoClip voltar;
    public VideoClip sair;
    public VideoClip macaco;
    public VideoClip galinha;
    public VideoClip leao;
    public VideoClip peixe;
    public VideoClip girafa;
    public VideoClip bonus;

    [Header("Video Player")]
    public VideoPlayer videoPlayer;
    private bool isVlibrasPanel = false;

    [Header ("Video Player Panel")]
    public GameObject vLibrasPanel;


    void Start()
    {
        if (videoPlayer == null)
            videoPlayer = gameObject.AddComponent<VideoPlayer>();

        videoPlayer.playOnAwake = false;


        vLibrasPanel.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isVlibrasPanel = true;
        vLibrasPanel.SetActive(true);
        VideoManager();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (isVlibrasPanel)
        {
            videoPlayer.Stop();
            isVlibrasPanel = false;
            vLibrasPanel.SetActive(false);
        }
    }

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
            case "Leao":     selectedClip = leao; break; // sem acento para casar com o texto
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
}

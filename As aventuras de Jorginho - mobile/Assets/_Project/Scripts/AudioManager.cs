using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public  AudioClip hitAudioClip;
    public  AudioClip missAudioClip;
    public  AudioClip popupAudioClip;

    public void PlayAudio(AudioClip track)
    {
        audioSource.clip = track;
        audioSource.Play();
    }
    
}

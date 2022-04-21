using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private AudioManager audioManager;

    [SerializeField]private AudioSource audioSource;

    [SerializeField]private AudioClip introNarration;
    [SerializeField]private AudioClip earthNarration;
    [SerializeField]private AudioClip mainAudio;


    private void Awake()
    {
        audioManager =  GameObject.Find("Audio Manager").GetComponent<AudioManager>();
    }

    public void Update()
    {
   
    }

    public void PlayIntroNarration()
    {
        audioSource.PlayOneShot(introNarration);
    }
  
}

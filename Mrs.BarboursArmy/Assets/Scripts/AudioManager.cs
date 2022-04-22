using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    private AudioManager audioManager;

    [SerializeField]private AudioSource audioSource;

    [SerializeField]private AudioClip mainAudio;
    [SerializeField]private AudioClip introNarration;
    [SerializeField]private AudioClip airNarration;
    [SerializeField]private AudioClip fireNarration;
    [SerializeField]private AudioClip earthNarration;
    [SerializeField]private AudioClip waterNarration;
    

    private void Awake()
    {
        audioManager =  GameObject.Find("Audio Manager").GetComponent<AudioManager>();
    }
    
    


}

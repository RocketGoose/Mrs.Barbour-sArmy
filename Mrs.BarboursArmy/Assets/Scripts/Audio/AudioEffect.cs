using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEffect : MonoBehaviour
{   

    AudioSource myAudioSource;

    GameManager gameManager;

    bool isPlaying;


     void OnEnable()
    {
        ActivateTrigger.OnTrigger += PlayAudio;

    }

    void OnDisable()
    {
        ActivateTrigger.OnTrigger -= PlayAudio;
    }
    
     void PlayAudio(Vector3 triggerPoint, string audioObject )
    {
        string cube = gameObject.name;

        
        if (audioObject.Contains(cube) == true && isPlaying == false)
        {

            {
                isPlaying = true;
                myAudioSource.Play();
                Debug.Log("Audio is playing" + cube);
                StartCoroutine(LockWhileAudio());
            }
                        

        }
       /* else if  (audioObject.Contains(cube) == true && isPlaying == true)
        {

            {
                isPlaying = false;
                myAudioSource.Stop();
                Debug.Log("Audio stopped");
                        
            }

        }*/
      
    }
    void Start()
    {
      
        myAudioSource = GetComponent<AudioSource>();
        isPlaying = false;
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
       
    }
    IEnumerator LockWhileAudio()
    {
        gameManager.isControlLock = true;
        yield return new WaitForSeconds(42);
        gameManager.isControlLock = false;
    }

}
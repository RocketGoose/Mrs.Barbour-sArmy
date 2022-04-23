using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlScript : MonoBehaviour
{

    public GameObject morph; 
    public GameObject hogBacks;
    public GameObject hogBackB;
    public GameObject textBox;

    Animator morphAnimator;
    Animator hogbacksAnimator;
    Animator hogbackBAnimator;

    public AudioSource menuAmbiance;
    public AudioSource audio;

    public AudioClip intro;
    public AudioClip outro;

    GameManager gameManager;

    void OnEnable()
    {
        GameManager.OnSceneChange += CheckSceneInt;
    }

    void OnDisable()
    {
        GameManager.OnSceneChange -= CheckSceneInt;
    }

    void CheckSceneInt(int checkScene)
    {
        if(checkScene == 1)
        {
            StartCoroutine(IntroSequence());
        }

        else if(checkScene == 2)
        {
            StartCoroutine(IntractSequence());
        }

        else if(checkScene == 3)
        {
            StartCoroutine(OutroSequence());
        }

          else if(checkScene == 0)
        {
            StartCoroutine(MenuSequence());
        }
    }

    void Start()
    {
        morphAnimator = morph.GetComponent<Animator>();
        hogbacksAnimator = hogBacks.GetComponent<Animator>();
        hogbackBAnimator = hogBackB.GetComponent<Animator>();
        menuAmbiance = textBox.GetComponent<AudioSource>();
        audio = GetComponent<AudioSource>();

        menuAmbiance.Play(0);

        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));

    }

    
    void Update()
    {
        
    }

    
    public IEnumerator MenuSequence()
    {
        menuAmbiance.Play(0);
        yield return new WaitForSeconds(1);
        Debug.Log("MenuPlaying");

    }
    
    public IEnumerator IntroSequence()
    {
        menuAmbiance.Stop();
        gameManager.isControlLock = true;


        morphAnimator.SetBool("Morph1", true);
        hogbacksAnimator.SetBool("HogBacks1", true);
        hogbackBAnimator.SetBool("HogbackB1", true);
        yield return new WaitForSeconds(1);
        morphAnimator.SetBool("Morph1", false);
        hogbacksAnimator.SetBool("HogBacks1", false);
        hogbackBAnimator.SetBool("HogbackB1", false);

        audio.PlayOneShot (intro);
        StartCoroutine(IntroSequenceSubs());

        //Delay for Intro Audio
        yield return new WaitForSeconds(56);   

        gameManager.isControlLock = false;    

    }

    public IEnumerator IntractSequence()
    {
        gameManager.isControlLock = true;   

        morphAnimator.SetBool("Morph2", true);
        hogbacksAnimator.SetBool("HogBacks2", true);
        hogbackBAnimator.SetBool("HogbackB2", true);
        yield return new WaitForSeconds(1);
        morphAnimator.SetBool("Morph2", false);
        hogbacksAnimator.SetBool("HogBacks2", false);
        hogbackBAnimator.SetBool("HogbackB2", false);

        gameManager.isControlLock = false;   

        audio.PlayOneShot (outro);
        StartCoroutine(OutroSequenceSubs());

        //Delay for Outro Audio
        yield return new WaitForSeconds(58);
        
        gameManager.sceneInt ++;

    }

    public IEnumerator OutroSequence()
    {

        morphAnimator.SetBool("Morph3", true);
        hogbackBAnimator.SetBool("HogbackB3", true);
        yield return new WaitForSeconds(1);
        morphAnimator.SetBool("Morph3", false);
        hogbackBAnimator.SetBool("HogbackB3", false);

        gameManager.sceneInt = 0;
    }

        IEnumerator IntroSequenceSubs()
    {
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text = "The Govan Stones represent a fusion of different carving styles depicting ‘Pictish’ horsemen and beasts, ‘Gaelic’ ringed crosses and ‘Angelian’ knots and interlace,";
            yield return new WaitForSeconds(9);
            //textBox.GetComponent<TMP_Text>().text ="";
           // yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "creating a style unique to the area known as the ‘Govan School’ of stonecarving.";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "Probably the most enigmatic amongst the 31 stones at Govan are a series of five";
            //textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(3);
            textBox.GetComponent<TMP_Text>().text = "so-called ‘Hogback’ stones.";
            yield return new WaitForSeconds(3);
            textBox.GetComponent<TMP_Text>().text = "First mentioned in 1535 these types of stones have been found across the United Kingdom.";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "Despite many similarities suggesting they were made by local carvers, all the stones have their own individual characteristics.";
            yield return new WaitForSeconds(8);
            textBox.GetComponent<TMP_Text>().text = "While they are often described as grave markers none of the stones have yet been linked to a specific burial site or";
            yield return new WaitForSeconds(4);
            //textBox.GetComponent<TMP_Text>().text ="";
            //yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "feature inscriptions memorialising the dead, leaving many puzzled about their origins and usage.";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(5);
    }

         IEnumerator OutroSequenceSubs()
    {
            //Placeholder
            
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text = "Several of the Hogbacks show signs of alteration throughout their history hinting at a potential history of reuse";
            yield return new WaitForSeconds(9);
            //textBox.GetComponent<TMP_Text>().text ="";
           // yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "One of the more notable changes seem to have involved the redesigning of the ‘endbeasts’ to resemble a singular creature ";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "with the addition of distinguishable legs and one of the heads reversed to face outwards";
            //textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(3);
            textBox.GetComponent<TMP_Text>().text = " indicating how even then the hogbacks may have been interpreted in different ways and how their usage may have varied throughout their existence.";
            yield return new WaitForSeconds(3);
            textBox.GetComponent<TMP_Text>().text = "Another interesting feature is what looks to be a hone or whetstone worked  into the ridge of one of the Hogbacks";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "indicating these stones may have had other uses outside of burial sites.";
            yield return new WaitForSeconds(13);
          
     }


}

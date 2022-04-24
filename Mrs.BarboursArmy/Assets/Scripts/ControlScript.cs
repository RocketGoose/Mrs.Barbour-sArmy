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
        //ActivateTrigger.OnTrigger += CheckHogComplete;
    }

    void OnDisable()
    {
        GameManager.OnSceneChange -= CheckSceneInt;
        //ActivateTrigger.OnTrigger += CheckHogComplete;
    }

    /*
    void CheckHogComplete(Vector3 a, string b)
    {
        Debug.Log("starting hog ckeck");
        if(gameManager.hogComplete == true)
        {
            Debug.Log("hog check is true");
            StartCoroutine(IfHogComplete());
        }
    }
    

    IEnumerator IfHogComplete()
    {
        Debug.Log("starting hog complete scene change");
        yield return new WaitForSeconds(45);
        gameManager.sceneInt ++;
    }
    */
    
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
            gameManager.hogAirClicked = false;
            gameManager.hogEarthClicked = false;
            gameManager.hogFireClicked = false;
            gameManager.hogWaterClicked = false;
            gameManager.hogComplete = false;
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
        yield return new WaitForSeconds(54);   

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
        gameManager.isControlLock = false;  
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
        yield return new WaitForSeconds(5);
        textBox.GetComponent<TMP_Text>().text = "The origins of the Govan Stones have been linked to Doomster Hill ";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<TMP_Text>().text = "a nearby man-made mound that was flattened to make way for the Clyde shipyards";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "Originally 45 stones were said to have been found in Govan however many were lost, destroyed, or damaged ";
        yield return new WaitForSeconds(7);
        //textBox.GetComponent<TMP_Text>().text ="";
// yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "during the demolition of the neighbouring buildings, where they were mistaken for debris.";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text ="This has made it difficult to determine the original locations of the Hogbacks which could have helped unravel some of the mystery around their origins";
        yield return new WaitForSeconds(7);
        textBox.GetComponent<TMP_Text>().text = "The Govan Hogbacks have seen much wear and tear both by time as well as negligence making it difficult to define what they may have actually been used for, ";
        yield return new WaitForSeconds(8);
        textBox.GetComponent<TMP_Text>().text =" while we may not know their exact origins";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text ="what is clear is that these stone are an important part of the local history and may well be key to uncovering those parts still shrouded in mystery.";
        yield return new WaitForSeconds(7);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);

        //yield return null;
    }


}

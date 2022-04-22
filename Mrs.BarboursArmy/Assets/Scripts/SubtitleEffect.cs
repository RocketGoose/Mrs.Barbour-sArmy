using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SubtitleEffect : MonoBehaviour
{
    public GameObject textBox;
    
   // public void PlayIntro() 
   // {
    //     StartCoroutine(IntroSequence());
   // }

   //void PlaySubtitle( Vector3 center)
   // {
    //   StartCoroutine(IntroSequence());
   // }

    
    void OnEnable()
    {
        ActivateTrigger.OnTrigger += TriggerSubtitle;

    }

    void OnDisable()
    {
        ActivateTrigger.OnTrigger -= TriggerSubtitle;
    }

       void TriggerSubtitle(Vector3 triggerPoint, string audioObject )
    {
        string cube = gameObject.name;

        
        if (audioObject.Contains(cube) == true )
        {

            {
                StartCoroutine(IntroSequence());  
            }
        }

       /*     else if  (audioObject.Contains(cube) == true)
        {

            {
                  
                StopCoroutine(IntroSequence());
                Debug.Log("Subtitle stopped");
                        
            } 
            

    }*/


      
    }   
    //delay lines
    IEnumerator IntroSequence()
    {
            yield return new WaitForSeconds(1);
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
     }

         IEnumerator EarthSequence()
    {
            yield return new WaitForSeconds(1);
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
     }

    
}
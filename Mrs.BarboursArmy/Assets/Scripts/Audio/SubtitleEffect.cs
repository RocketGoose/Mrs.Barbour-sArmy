using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SubtitleEffect : MonoBehaviour
{
    public GameObject textBox;

    GameManager gameManager;

   // bool isShowing;

     void Start()
    {
        //StopAllCoroutines();
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        
    }
       
    

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

    void TriggerSubtitle(Vector3 triggerPoint, string hitObject )
    {
        string objectName = gameObject.name;
        
        if(hitObject.Contains(objectName)==true)
        {
            if(objectName.Contains(gameManager.hogAir.name) == true  )
            {
                {   
                    Debug.Log("subtrigger:" + objectName);
                    //Invoke("AirSequence",0.1f);
                    StartCoroutine(AirSequence());  
                }
            }

            else if(objectName.Contains(gameManager.hogEarth.name) == true )
            {
                {   
                    Debug.Log("subtrigger:" + objectName);
                    //Invoke("EarthSequence",0.1f); 
                    StartCoroutine(EarthSequence());  
                }
            }
            else if(objectName.Contains(gameManager.hogFire.name) == true )
            {
                {   
                    Debug.Log("subtrigger:" + objectName);
                    //Invoke("FireSequence",0.1f); 
                    StartCoroutine(FireSequence());  
                }
            }
            else if(objectName.Contains(gameManager.hogWater.name) == true )
            {
                {   
                    Debug.Log("subtrigger:" + objectName);
                    //Invoke("WaterSequence",0.1f);  
                    StartCoroutine(WaterSequence()); 
                }
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

    /*
    IEnumerator IntroSequence()
    {
        yield return new WaitForSeconds(0);
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
    */

    IEnumerator AirSequence()
    {
        yield return new WaitForSeconds(0);
        textBox.GetComponent<TMP_Text>().text = "Most of the Hogbacks feature a type of tegulation, a pattern of rectangular tiles";
        yield return new WaitForSeconds(4);
        //textBox.GetComponent<TMP_Text>().text ="";
        // yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "and this was so common amongst the stones that it would come to characterise the Hogback stones in the 19th Century ";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "These tegulae seem to be reminiscent of stylised roof tiles, suggesting it may be a representation of a local type of building, often referred to as a longhouse";
        yield return new WaitForSeconds(7);
        //textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TMP_Text>().text = " This style of housing was not uncommon within the area and does not seem to have come from Scandinavia alone.";
        yield return new WaitForSeconds(6);
        textBox.GetComponent<TMP_Text>().text = "As with so many of the Hogbacks it is unknown why these particular details are present on the stones,";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text ="although in combination with the ‘endbeasts’ it might represent a creature guarding or protecting a home.";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
    }
    

    IEnumerator EarthSequence()
    {
        yield return new WaitForSeconds(0);   
        textBox.GetComponent<TMP_Text>().text = "Several of the Hogbacks show signs of alteration throughout their history hinting at a potential history of reuse";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "One of the more notable changes seem to have involved the redesigning of the ‘endbeasts’ to resemble a singular creature ";
        yield return new WaitForSeconds(6);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "with the addition of distinguishable legs and one of the heads reversed to face outwards";
        //textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<TMP_Text>().text = " indicating how even then the hogbacks may have been interpreted in different ways and how their usage may have varied throughout their existence.";
        yield return new WaitForSeconds(7);
        textBox.GetComponent<TMP_Text>().text = "Another interesting feature is what looks to be a hone or whetstone worked  into the ridge of one of the Hogbacks";
        yield return new WaitForSeconds(7);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "indicating these stones may have had other uses outside of burial sites.";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
            
    }

    IEnumerator FireSequence()
    {
        yield return new WaitForSeconds(0);
        textBox.GetComponent<TMP_Text>().text = "A common detail amongst the Hogbacks is the depiction of beasts resemblant of dragons at either end of the stone";
        yield return new WaitForSeconds(7);
        //textBox.GetComponent<TMP_Text>().text ="";
        // yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "Often referred to as ‘endbeasts’, it is difficult to say what these creatures may actually have represented due to the weathering and damage done to the stones. ";
        yield return new WaitForSeconds(10);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "Each Hogback’s end-design is different. Some are more recognisable as creatures than others";
        //textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TMP_Text>().text = " although carved depictions of beasts are not uncommon amongst the Govan Stones it is unknown for what reason they are featured on the Hogbacks,";
        yield return new WaitForSeconds(8);
        textBox.GetComponent<TMP_Text>().text = "although some speculate they may have had some role as symbolic guardians.";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
    }
    IEnumerator WaterSequence()
    {
        yield return new WaitForSeconds(0);
        textBox.GetComponent<TMP_Text>().text = "Many historians have linked the Hogbacks to the Scandinavian settlers that lived in Scotland during the time that the Hogbacks are thought to have been created. ";
        yield return new WaitForSeconds(8);
        //textBox.GetComponent<TMP_Text>().text ="";
        // yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "These ‘hogback people’ seem to have shared a maritime culture as many of the stones were found close to prominent waterways such as the Clyde. ";
        yield return new WaitForSeconds(8);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<TMP_Text>().text = "Notably one of the Govan Hogbacks is similar in design to those found in Cumbria and is also has a much slimmer profile than the others";
        yield return new WaitForSeconds(8);
        textBox.GetComponent<TMP_Text>().text ="While this seems to show a connection between these communities through the waterways";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<TMP_Text>().text = "it is unknown if it was the design language or the actual stones themselves that may have travelled by boat to Govan. ";
        yield return new WaitForSeconds(6);
        textBox.GetComponent<TMP_Text>().text ="";
        yield return new WaitForSeconds(1);
        //yield return null;
    }
      

    
}
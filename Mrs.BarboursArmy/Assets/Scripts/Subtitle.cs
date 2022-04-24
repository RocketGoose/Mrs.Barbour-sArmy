using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Subtitle : MonoBehaviour
{    

    //public enum MyEnum {AirSequence, WaterSequence, EarthSequence, FireSequence}
   
    public GameObject textBox;
        
    public  IEnumerator AirSequence()
    {
            
         
        
            yield return new WaitForSeconds(0);
            textBox.GetComponent<TMP_Text>().text = "Most of the Hogbacks feature a type of tegulation, a pattern of rectangular tiles";
            yield return new WaitForSeconds(9);
            //textBox.GetComponent<TMP_Text>().text ="";
           // yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "and this was so common amongst the stones that it would come to characterise the Hogback stones in the 19th Century ";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "These tegulae seem to be reminiscent of stylised roof tiles, suggesting it may be a representation of a local type of building, often referred to as a longhouse";
            //textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(3);
            textBox.GetComponent<TMP_Text>().text = " This style of housing was not uncommon within the area and does not seem to have come from Scandinavia alone.";
            yield return new WaitForSeconds(3);
            textBox.GetComponent<TMP_Text>().text = "As with so many of the Hogbacks it is unknown why these particular details are present on the stones,although in combination with the ‘endbeasts’ it might represent a creature guarding or protecting a home.";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "The origins of the Govan Stones have been linked to Doomster Hill, a nearby man-made artificial mound that was flattened to make way for the Clyde shipyards.";
            yield return new WaitForSeconds(8);
            textBox.GetComponent<TMP_Text>().text = " Originally 45 stones were said to have been found in Govan however many were lost,destroyed, or damaged during the demolition of the neighbouring buildings, where they were mistaken for debris. ";
            yield return new WaitForSeconds(4);
            //textBox.GetComponent<TMP_Text>().text ="";
            //yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "This has made it difficult to determine the original locations of the Hogbacks which could have helped unravel some of the mystery around their origins.";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            textBox.GetComponent<TMP_Text>().text = "The Govan Hogbacks have seen much wear and tear both by time as well as negligence making it difficult to divine what they may have actually been used for,";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text = "yet while we may not know their exact origins what is clear is that these stone are an important part of the local history and may well be key to uncovering those parts still shrouded in mystery. ";
            yield return new WaitForSeconds(5);


    }
     

    public IEnumerator EarthSequence()
    {
            yield return new WaitForSeconds(0);
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
            yield return new WaitForSeconds(8);
          
    }

    public IEnumerator FireSequence()
    {
            yield return new WaitForSeconds(0);
            textBox.GetComponent<TMP_Text>().text = "A common detail amongst the Hogbacks is the depiction of beasts resemblant of dragons at either end of the stone";
            yield return new WaitForSeconds(9);
            //textBox.GetComponent<TMP_Text>().text ="";
           // yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "Often referred to as ‘endbeasts’, it is difficult to say what these creatures may actually have represented due to the weathering and damage done to the stones. ";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "Each Hogback’s end-design is different. Some are more recognisable as creatures than others";
            //textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(3);
            textBox.GetComponent<TMP_Text>().text = " while carved depictions of beasts are not uncommon amongst the Govan Stones it is unknown for what reason they are featured on the Hogbacks,";
            yield return new WaitForSeconds(3);
            textBox.GetComponent<TMP_Text>().text = "although some speculate they may have had some role as symbolic guardians.";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "Despite many similarities suggesting they were made by local carvers, all the stones have their own individual characteristics.";
            yield return new WaitForSeconds(8);
            textBox.GetComponent<TMP_Text>().text = "While they are often described as grave markers none of the stones have yet been linked to a specific burial site or";
            yield return new WaitForSeconds(4);
           
    }

    public IEnumerator WaterSequence()
    
    {
            yield return new WaitForSeconds(0);
            textBox.GetComponent<TMP_Text>().text = "Many historians have linked the Hogbacks to the Scandinavian settlers that lived in Scotland during the time that the Hogbacks are thought to have been created. ";
            yield return new WaitForSeconds(9);
            //textBox.GetComponent<TMP_Text>().text ="";
           // yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "These ‘hogback people’ seem to have shared a maritime culture as many of the stones were found close to prominent waterways such as the Clyde. ";
            yield return new WaitForSeconds(5);
            textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(1);
            textBox.GetComponent<TMP_Text>().text = "Notably one of the Govan Hogbacks is similar in design to those found in Cumbria and is also has a much slimmer profile than the others";
            //textBox.GetComponent<TMP_Text>().text ="";
            yield return new WaitForSeconds(3);
            textBox.GetComponent<TMP_Text>().text = "it is unknown if it was the design language or the actual stones themselves that may have travelled by boat to Govan. ";
            yield return new WaitForSeconds(3);
    }
      
}

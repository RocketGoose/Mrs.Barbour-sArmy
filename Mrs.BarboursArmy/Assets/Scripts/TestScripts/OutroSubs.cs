using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OutroSubs : MonoBehaviour
{
    public GameObject textBox;

    GameManager gameManager;


    void Start()
    {
        StartCoroutine(OutroSequence()); 
    }
     

        IEnumerator OutroSequence()
    { 
         yield return new WaitForSeconds(0);
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



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubtitleScript : MonoBehaviour
{
    public GameObject textBox;

    public void Start() 
    {
        StartCoroutine(IntroSequence());
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

    
}

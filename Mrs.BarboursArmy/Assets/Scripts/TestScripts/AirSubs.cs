using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class AirSubs : MonoBehaviour
{
    public GameObject textBox;

     GameManager gameManager;

   
     void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));  
    }
       
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
        string objectName = gameObject.name;
        
        if (objectName.Contains(gameManager.hogAir.name) == true  )
        {     
               StartCoroutine(AirSequence()); 
                  
        }
    }

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
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class EarthSubs : MonoBehaviour
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
               StartCoroutine(EarthSequence()); 
                  
        }
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
}
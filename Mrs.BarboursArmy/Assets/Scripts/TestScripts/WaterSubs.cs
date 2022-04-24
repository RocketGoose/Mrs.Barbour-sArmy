using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class WaterSubs : MonoBehaviour
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
        
        if (objectName.Contains(gameManager.hogWater.name) == true  )
        {     
               StartCoroutine(WaterSequence()); 
                  
        }
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

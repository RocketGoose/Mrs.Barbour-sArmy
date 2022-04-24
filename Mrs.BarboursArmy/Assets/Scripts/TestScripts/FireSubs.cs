using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class FireSubs : MonoBehaviour
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
        
        if (objectName.Contains(gameManager.hogFire.name) == true  )
        {     
               StartCoroutine(FireSequence()); 
                  
        }
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
}

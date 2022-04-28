using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    string thisName;

    GameManager gameManager;
    void OnEnable()
    {
        ActivateTrigger.OnTrigger += DoTrigger;

    }

    void OnDisable()
    {
        ActivateTrigger.OnTrigger -= DoTrigger;
    }

    void DoTrigger(Vector3 triggerPoint, string _hitName)
    {
        Debug.Log("menu triggered");
        if(_hitName.Contains(thisName) == true)
        {
            MenuFunctions();
            Debug.Log("start menu functions");
        }
        
      
    }

    void MenuFunctions()
    {
        if(thisName.Contains(gameManager.startButton.name) == true)
        {
            Debug.Log("start button");
            gameManager.sceneInt ++ ;
        }

        //Attempt
        if (thisName.Contains(gameManager.aboutButton.name) == true)
        {
            Debug.Log("about button");
            gameManager.aboutPanel.SetActive(true);
            
        }  
        //
    }
    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        thisName = gameObject.name;
    }
}

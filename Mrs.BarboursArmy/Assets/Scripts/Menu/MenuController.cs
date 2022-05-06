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
        thisName = _hitName;
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
            gameManager.backButton.SetActive(true);

            gameManager.helpButton.SetActive(false);
            gameManager.aboutButton.SetActive(false);
            gameManager.quitButton.SetActive(false);
        }

        if (thisName.Contains(gameManager.helpButton.name) == true)
        {
            Debug.Log("help button");
            gameManager.helpPanel.SetActive(true);
            gameManager.backButton.SetActive(true);
            
            gameManager.helpButton.SetActive(false);
            gameManager.aboutButton.SetActive(false);
            gameManager.quitButton.SetActive(false);

        }

        if (thisName.Contains(gameManager.backButton.name) == true)
        {
            Debug.Log("back button");
            gameManager.aboutPanel.SetActive(false);
            gameManager.helpPanel.SetActive(false);
            gameManager.backButton.SetActive(false);

            gameManager.helpButton.SetActive(true);
            gameManager.aboutButton.SetActive(true);
            gameManager.quitButton.SetActive(true);

        }


        if (thisName.Contains(gameManager.quitButton.name) == true)
        {
            Debug.Log("quit button");
            Application.Quit();
        }

        //
    }
    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        thisName = gameObject.name;

        //
        gameManager.aboutPanel.SetActive(false);
        gameManager.helpPanel.SetActive(false);
        gameManager.backButton.SetActive(false);
        //
    }
}

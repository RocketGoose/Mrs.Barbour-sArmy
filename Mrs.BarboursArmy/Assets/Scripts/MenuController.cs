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
        if(_hitName.Contains(thisName) == true)
        {
            MenuFunctions();
        }
    }

    void MenuFunctions()
    {
        if(thisName.Contains(gameManager.startButton.name) == true)
        {
            gameManager.sceneInt ++ ;
        }
    }
    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        thisName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

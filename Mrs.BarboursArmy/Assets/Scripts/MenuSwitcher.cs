using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitcher : MonoBehaviour
{
    GameManager gameManager;
   // public GameObject[] menuObjects;

    public List<GameObject> menuObjects;
    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));

        foreach (Transform child in this.gameObject.transform) 
        {
            menuObjects.Add(child.gameObject);
        }
    }

    void OnEnable()
    {
        GameManager.OnSceneChange += DoMenuCheck;

    }

    void OnDisable()
    {
        GameManager.OnSceneChange -= DoMenuCheck;
    }

    void DoMenuCheck(int _sceneInt)
    {
        if(gameManager.sceneInt > 0)
        {
            foreach(GameObject obj in menuObjects) 
            {
                obj.SetActive(false);
            }
        }

        if(gameManager.sceneInt == 0)
        {
            foreach(GameObject obj in menuObjects) 
            {
                obj.SetActive(true);
            }
        }
    }
}

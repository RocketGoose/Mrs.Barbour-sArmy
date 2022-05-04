using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitcher : MonoBehaviour
{
    GameManager gameManager;
   // public GameObject[] menuObjects;

    public List<GameObject> menuObjects;

    /*
    public GameObject hogAir;
    public GameObject hogEarth;
    public GameObject hogWater;
    public GameObject hogFire;
    */
    void Start()
    {
        /*
        hogAir = GameObject.FindGameObjectWithTag("Air");
        hogEarth = GameObject.FindGameObjectWithTag("Earth");
        hogWater = GameObject.FindGameObjectWithTag("Water");
        hogFire = GameObject.FindGameObjectWithTag("Fire");
        */

        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));

        foreach (Transform child in this.gameObject.transform) 
        {
            menuObjects.Add(child.gameObject);
        }
        /*
        hogAir.SetActive(false);
        hogEarth.SetActive(false);
        hogFire.SetActive(false);
        hogWater.SetActive(false);
        */
    }

    void OnEnable()
    {
        GameManager.OnSceneChange += DoSceneCheck;
    }

    void OnDisable()
    {
        GameManager.OnSceneChange -= DoSceneCheck;
    }

    void DoSceneCheck(int _sceneInt)
    {
        if(gameManager.sceneInt > 0)
        {
            
            foreach(GameObject obj in menuObjects) 
            {
                obj.SetActive(false);
            }
        
            /*
            hogAir.SetActive(true);
            hogEarth.SetActive(true);
            hogFire.SetActive(true);
            hogWater.SetActive(true);
            */
        }

        if(gameManager.sceneInt == 0)
        {
            foreach(GameObject obj in menuObjects) 
            {
                obj.SetActive(true);
            }
            /*
            hogAir.SetActive(false);
            hogEarth.SetActive(false);
            hogFire.SetActive(false);
            hogWater.SetActive(false);
            */
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isControlLock;

    public bool hogFireClicked;
    public bool hogAirClicked;
    public bool hogWaterClicked;
    public bool hogEarthClicked;
    public bool hogComplete;


    public GameObject hogAir;
    public GameObject hogEarth;
    public GameObject hogWater;
    public GameObject hogFire;

    public int sceneInt;
    int lastSceneInt;

    public delegate void SceneChange(int a);
    public static event SceneChange OnSceneChange;

    string hitName;
 
    void Start()
    {
        hogAir = GameObject.FindGameObjectWithTag("Air");
        hogEarth = GameObject.FindGameObjectWithTag("Earth");
        hogWater = GameObject.FindGameObjectWithTag("Water");
        hogFire = GameObject.FindGameObjectWithTag("Fire");

        
        isControlLock = false;

        hogAirClicked = false;
        hogEarthClicked = false;
        hogFireClicked = false;
        hogWaterClicked = false;
        hogComplete = false;

        sceneInt = 0;
    }

    void Update()
    {

        if (lastSceneInt != sceneInt)
        {
            OnSceneChange(sceneInt);
            lastSceneInt = sceneInt;
        }

    }

    void OnEnable()
    {
        ActivateTrigger.OnTrigger += HogCheck;
    }

    void OnDisable()
    {
        ActivateTrigger.OnTrigger -= HogCheck;
    }

    void HogCheck(Vector3 a, string b)
    {
        hitName = b;
        Invoke("HogRayCheck", 0.1f);

    }

    void HogRayCheck()
    {
        if(hitName.Contains(hogAir.name) == true)
        {
            hogAirClicked = true;
        }
        if(hitName.Contains(hogEarth.name) == true)
        {
            hogEarthClicked = true;
        }
        if(hitName.Contains(hogWater.name) == true)
        {
            hogWaterClicked = true;
        }
        if(hitName.Contains(hogFire.name) == true)
        {
            hogFireClicked = true;
        }
        if(hogAirClicked == true && hogEarthClicked == true && hogFireClicked == true && hogWaterClicked == true)
        {
            hogComplete = true;
            sceneInt ++ ; 
            Debug.Log("HOG COMPLEAT!!!");
        }
    }

}

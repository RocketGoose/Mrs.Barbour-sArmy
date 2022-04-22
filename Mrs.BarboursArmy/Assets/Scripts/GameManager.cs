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

    string hitName;
    // Start is called before the first frame update
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
            Debug.Log("HOG COMPLEAT!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

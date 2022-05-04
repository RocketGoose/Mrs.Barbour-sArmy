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

    public GameObject hogbackB;
    public GameObject hogAir;
    public GameObject hogEarth;
    public GameObject hogWater;
    public GameObject hogFire;

    public GameObject hogbacks;
    public GameObject floatOutside;
    public GameObject inside;
    public GameObject outside;

    public GameObject startButton;

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
        hogbackB = GameObject.FindGameObjectWithTag("HogbackB");

        startButton = GameObject.FindGameObjectWithTag("StartButton");

        hogbacks = GameObject.FindGameObjectWithTag("Hogbacks");
        inside = GameObject.FindGameObjectWithTag("Inside");
        outside = GameObject.FindGameObjectWithTag("Outside");
        floatOutside = GameObject.FindGameObjectWithTag("FloatOutside");

        hogbackB.SetActive(false);

        hogbacks.SetActive(false);

        inside.SetActive(false);
        outside.SetActive(false);
        floatOutside.SetActive(true);
        
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
            Debug.Log("HOG COMPLEAT!!!");

            Debug.Log("hog check is true");
            StartCoroutine(IfHogComplete());
        }
    }

    IEnumerator IfHogComplete()
    {
        Debug.Log("starting hog complete scene change");
        yield return new WaitForSeconds(42);
        sceneInt ++;
    }

}

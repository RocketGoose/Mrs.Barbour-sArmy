using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TransitionEffect : MonoBehaviour
{

    Material material;

    GameManager gameManager;

    float triggerVal;

    void OnEnable()
    {
        ActivateTrigger.OnTrigger += DoTrigger;

    }

    void OnDisable()
    {
        ActivateTrigger.OnTrigger -= DoTrigger;
    }
    void DoTrigger(Vector3 triggerPoint, string hitName)
    {
        string _thisName = gameObject.name;
        Debug.Log("Activate");

        if(_thisName.Contains(gameManager.hogAir.name) == true && gameManager.hogAirClicked == true)
        {
            Debug.Log("air already clicked");
        }
        else if(_thisName.Contains(gameManager.hogWater.name) == true && gameManager.hogWaterClicked == true)
        {
            Debug.Log("water already clicked");
        }
        else if(_thisName.Contains(gameManager.hogEarth.name) == true && gameManager.hogEarthClicked == true)
        {
            Debug.Log("earth already clicked");
        }
        else if(_thisName.Contains(gameManager.hogFire.name) == true && gameManager.hogFireClicked == true)
        {
            Debug.Log("fire already clicked");
        }
        else if(hitName.Contains(_thisName) == true)
        {
            StartTransition(triggerPoint);
           // Debug.Log("Ray hit:" + hitName + " This:" + _thisName + hitName.Contains(_thisName));
        }
    }
    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
        triggerVal = 0;
        material.SetFloat("_Trigger", triggerVal);
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
    }

    void StartTransition(Vector3 center)
    {
        triggerVal = 1;
        material.SetVector("_TransitionPoint", center);
        material.SetFloat("_Trigger", triggerVal);
        material.SetFloat("_TransitionStartTime", Time.time);
    }
}

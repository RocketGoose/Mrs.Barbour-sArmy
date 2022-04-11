using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TransitionEffect : MonoBehaviour
{


    Material material;

    float triggerVal;

    void OnEnable()
    {
        ActivateTrigger.trigger += DoTrigger;

    }

    void OnDisable()
    {
        ActivateTrigger.trigger -= DoTrigger;
    }
    void DoTrigger()
    {
        Debug.Log("Activate");
        var camera = Camera.main;
        var mousePos = Input.mousePosition;
        var ray = camera.ScreenPointToRay(mousePos);
        if(Physics.Raycast(ray, out var hitInfo) && hitInfo.collider.gameObject == gameObject)
        {
            StartTansition(hitInfo.point);
        }
    }
    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
        triggerVal = 0;
        material.SetFloat("_Trigger", triggerVal);
    }

    void StartTansition(Vector3 center)
    {
        triggerVal = 1;
        material.SetVector("_TransitionPoint", center);
        material.SetFloat("_Trigger", triggerVal);
        material.SetFloat("_TransitionStartTime", Time.time);
    }



}

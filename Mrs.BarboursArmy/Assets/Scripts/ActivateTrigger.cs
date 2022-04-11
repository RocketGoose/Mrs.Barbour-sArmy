using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

public class ActivateTrigger : MonoBehaviour
{
    // Followed this tutorial for seting up input https://www.youtube.com/watch?v=jOn0YWoNFVY
    // and this for the observer pattern https://www.youtube.com/watch?v=UWMmib1RYFE
    
    public InputActionReference activate = null;

    public static event Action trigger;

    XRRayInteractor rayInteractor;

    void Awake()
    {
        activate.action.performed += DoActivate;
        rayInteractor = GetComponent<XRRayInteractor>();
    }

    void DoActivate(InputAction.CallbackContext obj)
    {

        if(rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit raycastHit) == true)
        {
            Debug.Log(raycastHit.point);
            trigger?.Invoke();
            Debug.Log("trigger invoked");
        }

    }

}

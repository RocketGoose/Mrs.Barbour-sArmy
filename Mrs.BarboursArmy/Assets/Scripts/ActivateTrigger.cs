
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

    public GameManager gameManager;

    //public static event Action trigger;

    public delegate void TriggerClick(Vector3 a, string b);
    public static event TriggerClick OnTrigger;

    XRRayInteractor rayInteractor;

    void Awake()
    {
        activate.action.performed += DoActivate;
        rayInteractor = GetComponent<XRRayInteractor>();
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
    }

    void DoActivate(InputAction.CallbackContext obj)
    {

        if(rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit raycastHit) == true && gameManager.isControlLock == false)
        {
            Debug.Log(raycastHit.point);
            if (OnTrigger != null)
            {
                OnTrigger(raycastHit.point, raycastHit.transform.gameObject.name);
                Debug.Log("trigger invoked");
            }
            //trigger?.Invoke();
        }

    }

}

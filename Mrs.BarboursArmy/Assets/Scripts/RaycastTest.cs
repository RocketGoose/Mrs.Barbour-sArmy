using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

public class RaycastTest : MonoBehaviour
{
    /*void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             RaycastHit hit;
             if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
             {
                 Transform objecthit = hit.transform;
                 if (hit.transform.gameObject.tag == "Hog")
                 {
*/
 public InputActionReference activate = null;

    //public static event Action trigger;

    public delegate void TriggerClick(Vector3 a);
    public static event TriggerClick OnTrigger;

    XRRayInteractor rayInteractor;

    void Awake()
    {
        activate.action.performed += PlayNarration;
        rayInteractor = GetComponent<XRRayInteractor>();
    }

    void PlayNarration(InputAction.CallbackContext obj)
    {

        if(rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit raycastHit) == true)
        {
            Debug.Log(raycastHit.point);
            if (OnTrigger != null)
            {
                OnTrigger(raycastHit.point);
                Debug.Log("trigger invoked");
            }
            //trigger?.Invoke();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UiRayActivation : MonoBehaviour
{

 [SerializeField]
 private Transform linkedhandpos;

 [SerializeField]
 private LayerMask layerToHit; 

 [SerializeField]
 private float maxDistanceToCanvas;

 [Header("UI Hover Events")]
 public UnityEvent onUiHoverStart;
 public UnityEvent onUiHoverEnd;

enum CurrentInteractorState
{
    DefaultMode,
    UiMode
}

private CurrentInteractorState CurrentInteractorMode;

private void Awake() => CurrentInteractorMode = CurrentInteractorState.DefaultMode;

private void FixedUpdate()
{
    RaycastHit hit;
    if (Physics.Raycast(linkedhandpos.position, linkedhandpos.forward, out hit, maxDistanceToCanvas, layerToHit))
    {
            if (CurrentInteractorMode != CurrentInteractorState.UiMode)
            {
                onUiHoverStart.Invoke();
                CurrentInteractorMode = CurrentInteractorState.UiMode;
            }


            


    }
       else
       {
            if (CurrentInteractorMode == CurrentInteractorState.UiMode)
            {
                onUiHoverEnd.Invoke();
                CurrentInteractorMode = CurrentInteractorState.DefaultMode;
            }
       }

    }


}

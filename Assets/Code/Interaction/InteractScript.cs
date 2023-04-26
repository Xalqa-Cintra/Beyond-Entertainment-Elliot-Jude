using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable { 
    public void Interact();
}
public class InteractScript : MonoBehaviour
{
    public Transform interactorSource;
    public float interactorRange;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray r = new Ray(interactorSource.position, interactorSource.forward);
            if(Physics.Raycast(r, out RaycastHit hitInfo, interactorRange))
            {
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }
    }
}

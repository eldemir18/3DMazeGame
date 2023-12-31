using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePlayer : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<IInteractable>(out var interactable))
        {
            interactable.Interact();
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.TryGetComponent<IInteractable>(out var interactable))
        {
            interactable.Interact();
        }
    }
}

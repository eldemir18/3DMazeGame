using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<IInteractable>(out var interactable))
        {
            interactable.Interact();
        }
    }
}

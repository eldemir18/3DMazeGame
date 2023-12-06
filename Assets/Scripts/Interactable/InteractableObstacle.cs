using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObstacle : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        GameManager.Instance.ResetPlayerPosition();     
    }
}

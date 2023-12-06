using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableGoal : MonoBehaviour, IInteractable
{
    public static event Action OnGoalReached;
    public void Interact()
    {
        OnGoalReached?.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayCursor : MonoBehaviour
{
    private void OnEnable()
    {
        InteractableGoal.OnGoalReached += () => SetCursorState(CursorLockMode.None);
    }

    private void OnDisable()
    {
        InteractableGoal.OnGoalReached -= () => SetCursorState(CursorLockMode.None);
    }

    private void Start()
    {
        SetCursorState(CursorLockMode.Locked);
    }

    private void SetCursorState(CursorLockMode mode)
    {
        Cursor.lockState = mode;
    }
}


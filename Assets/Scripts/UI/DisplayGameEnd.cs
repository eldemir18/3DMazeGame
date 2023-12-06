using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayGameEnd : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameEndPanel;

    private void OnEnable()
    {
        InteractableGoal.OnGoalReached += ShowGameEndPanel;
    }

    private void OnDisable()
    {
        InteractableGoal.OnGoalReached -= ShowGameEndPanel;
    }

    private void ShowGameEndPanel()
    {
        _gameEndPanel.SetActive(true);
    }
}


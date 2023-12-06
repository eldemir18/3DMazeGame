using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform;
    private Vector3 _startPosition;

    public static GameManager Instance {get; private set;}

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _startPosition = _playerTransform.transform.position;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ResetPlayerPosition()
    {
        _playerTransform.position = _startPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    [SerializeField]
    private GameObject _camera;

    private IInputReceiver<Vector2> _playerMovement;
    private IInputReceiver<Vector2> _cameraFollow;

    private bool _isInputEnabled = true;

    private void Awake()
    {
        _playerMovement = _player.GetComponent<IInputReceiver<Vector2>>();
        _cameraFollow = _camera.GetComponent<IInputReceiver<Vector2>>();
    }

    private void OnEnable()
    {
        InteractableGoal.OnGoalReached += () => _isInputEnabled = false;
    }

    private void OnDisable()
    {
        InteractableGoal.OnGoalReached -= () => _isInputEnabled = false;
    }

    private void OnMove(InputValue value)
    {
        SetInput(_playerMovement, value.Get<Vector2>());
    }

    private void OnRotate(InputValue value)
    {
        SetInput(_cameraFollow, value.Get<Vector2>());
    }

    private void SetInput<T>(IInputReceiver<T> receiver, T value) where T : struct
    {
        if(_isInputEnabled)
        {
            receiver.SetInputValue(value);
        }
    }
}

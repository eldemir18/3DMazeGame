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

    private void Awake()
    {
        _playerMovement = _player.GetComponent<IInputReceiver<Vector2>>();
        _cameraFollow = _camera.GetComponent<IInputReceiver<Vector2>>();
    }

    public void OnMove(InputValue value)
    {
        _playerMovement?.SetInputValue(value.Get<Vector2>());
    }

    public void OnRotate(InputValue value)
    {
        _cameraFollow?.SetInputValue(value.Get<Vector2>());
    }
}

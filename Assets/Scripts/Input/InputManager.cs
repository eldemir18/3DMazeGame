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

    public void OnMove(InputValue value)
    {
        SetInput<Vector2>(_player, value);
    }

    public void OnRotate(InputValue value)
    {
        SetInput<Vector2>(_camera, value);
    }
    
    private void SetInput<T>(GameObject target, InputValue value) where T : struct
    {
        if (target.TryGetComponent<IInputReceiver<T>>(out var inputReceiver))
        {
            inputReceiver.SetInputValue(value.Get<T>());
        }
    }
}

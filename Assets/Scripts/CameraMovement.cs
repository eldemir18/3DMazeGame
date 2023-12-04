using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private float _mouseSensitivity;
    private Vector2 _moveInput;

    private void Update()
    {
        float mouseX = _moveInput.x * _mouseSensitivity;
        float mouseY = _moveInput.y * _mouseSensitivity;

        Vector3 currentRotation = transform.localEulerAngles;
        currentRotation.y += mouseX;
        currentRotation.x -= mouseY;
        transform.localRotation = Quaternion.Euler(currentRotation);
    }

    public void OnLook(InputValue value)
    {
        _moveInput = value.Get<Vector2>();
    }
}

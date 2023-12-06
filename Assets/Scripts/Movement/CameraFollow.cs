using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour, IInputReceiver<Vector2>
{
    [SerializeField] 
    private Transform _playerTransform;

    [SerializeField]
    private float _sensitivity = 0.25f;

    private readonly float _distance = 10f;
    private float _currentRotationX = 0f;
    private float _currentRotationY = -35f;
    
    private void LateUpdate()
    {
        var rotation = Quaternion.Euler(_currentRotationY, _currentRotationX, 0f);
        var direction = rotation * Vector3.forward;

        var desiredPosition = _playerTransform.position + direction * _distance;

        transform.position = desiredPosition;
        transform.LookAt(_playerTransform.position); 
    }

    public void SetInputValue(Vector2 value)
    {
        _currentRotationX += value.x * _sensitivity;
        _currentRotationY -= value.y * _sensitivity;

        _currentRotationY = Mathf.Clamp(_currentRotationY, -89f, 0f);
    }
}

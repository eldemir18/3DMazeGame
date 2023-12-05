using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour, IInputReceiver<Vector2>
{
    [SerializeField] 
    private Transform _playerTransform;

    [SerializeField]
    private float _sensitivity = 0.25f;

    private float _distance = 10f;
    private float _currentRotationX = 0f;
    private float _currentRotationY = -35f;
    
    private void LateUpdate()
    {
        Quaternion rotation = Quaternion.Euler(_currentRotationY, _currentRotationX, 0);
        Vector3 direction = rotation * Vector3.forward;

        // Calculate position on the surface of the sphere
        Vector3 desiredPosition = _playerTransform.position + direction * _distance;

        transform.position = desiredPosition;
        transform.LookAt(_playerTransform.position); // Keep looking at the target (player)
    }

    public void SetInputValue(Vector2 value)
    {
        _currentRotationX += value.x * _sensitivity;
        _currentRotationY -= value.y * _sensitivity;
        _currentRotationY = Mathf.Clamp(_currentRotationY, -89f, 89f);
    }
}

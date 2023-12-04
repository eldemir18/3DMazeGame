using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void OnRotate(InputValue value)
    {
        var moveInput = value.Get<float>();
        _rb.angularVelocity = moveInput * _rotationSpeed * Mathf.Deg2Rad * Vector3.up;
    }
}

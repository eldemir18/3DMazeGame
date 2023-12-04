using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed;
    private Vector2 _moveInput;
    private Rigidbody _rb;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _moveInput = Vector2.zero;
    }

    private void Update()
    {
        _rb.velocity = new Vector3(_moveInput.x * _moveSpeed, _rb.velocity.y, _moveInput.y * _moveSpeed);
    }

    public void OnMove(InputValue value)
    {
        _moveInput = value.Get<Vector2>();
        Debug.Log(_moveInput);
    }
}
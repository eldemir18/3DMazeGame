using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed;
    private Rigidbody _rb;
    private Transform _camTransform;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _camTransform = Camera.main.transform;
    }

    public void OnMove(InputValue value)
    {
        var moveInput = value.Get<Vector2>();
        var camForward = Vector3.Scale(_camTransform.forward, new Vector3(1, 0, 1)).normalized;
        var camRight = _camTransform.right;

        var move = moveInput.x * camRight + moveInput.y * camForward;
        move.Normalize(); 

        _rb.velocity = move * _moveSpeed;
    }
}
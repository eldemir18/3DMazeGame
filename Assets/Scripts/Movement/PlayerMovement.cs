using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IInputReceiver<Vector2>
{
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _maxSpeed; 
    
    private Vector2 _moveInput;
    private Rigidbody _rb;
    private Transform _camTransform;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _camTransform = Camera.main.transform;
    }

    public void SetInputValue(Vector2 value)
    {
        _moveInput = value;
    }
    
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        var camForward = Vector3.Scale(_camTransform.forward, new Vector3(1, 0, 1)).normalized;
        var camRight = _camTransform.right;
        var move = _moveInput.x * camRight + _moveInput.y * camForward;
        move.Normalize();

        _rb.AddForce(move * _moveSpeed);        
        if (_rb.velocity.magnitude > _maxSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * _maxSpeed;
        }
    }

}
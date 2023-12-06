using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField]
    private Vector3 _startPosition;

    [SerializeField]
    private Vector3 _endPosition;

    [SerializeField]
    private float _speed = 2.0f;

    private bool _moveDirection = false; 
    private const float _distanceThreshold = 1f;

    private void Awake()
    {
        transform.position = _startPosition;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var targetPosition = _moveDirection ? _startPosition : _endPosition;

        var moveStep = _speed * Time.deltaTime;
        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveStep);

        if (Vector3.Distance(transform.position, targetPosition) < _distanceThreshold)
        {
            _moveDirection = !_moveDirection; 
        }
    }
}


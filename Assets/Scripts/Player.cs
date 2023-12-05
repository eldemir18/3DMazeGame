using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerMovement MoveComponent {get; private set;}
    public PlayerHealth HealthComponent {get; private set;}

    private void Awake()
    {
        MoveComponent = GetComponent<PlayerMovement>();
        HealthComponent = GetComponent<PlayerHealth>();
    }
}
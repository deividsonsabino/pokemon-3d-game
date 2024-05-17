using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rb;

    Vector3 moveVectorInput;
    Vector3 moveDirection;
    [SerializeField] float speed = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void AddMoveVectorInput(Vector3 moveVector)
    {
        moveVectorInput = moveVector;
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        moveDirection = moveVectorInput;

        Vector3 moveVelocity = moveDirection * speed;
        moveVelocity += Physics.gravity;

        rb.velocity = moveVelocity; 
    }
}

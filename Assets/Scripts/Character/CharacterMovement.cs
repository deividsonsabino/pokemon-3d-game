using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rb;

    Vector3 moveVectorInput;
    Vector3 moveDirection;
    Vector3 rotationDirection;
    [SerializeField] float speed = 10f;
    [SerializeField] float rotationSpeed = 5f;
    [SerializeField] Camera targetCamera;
    PlayerAnimate playerAnimate;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerAnimate = GetComponent<PlayerAnimate>();
    }
    public void AddMoveVectorInput(Vector3 moveVector)
    {
        moveVectorInput = moveVector;
    }

    private void Update()
    {
        HandleMovement();
        HandleRotation();
        HandleAnimation();
    }

    private void HandleMovement()
    {
        //moveDirection = moveVectorInput;
        moveDirection = targetCamera.transform.forward * moveVectorInput.y;
        moveDirection += targetCamera.transform.right * moveVectorInput.x;
        moveDirection.y = 0;
        moveDirection.Normalize();

        Vector3 moveVelocity = moveDirection * speed;
        moveVelocity += Physics.gravity;

        rb.velocity = moveVelocity; 
    }

    private void HandleRotation()
    {
       if (moveDirection.magnitude > 0f) 
       {
            rotationDirection = moveDirection;
       }

       if (rotationDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(rotationDirection);
            Quaternion rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            transform.rotation = rotation;
        }
    }

    private void HandleAnimation()
    {
        playerAnimate.motion = moveVectorInput.magnitude;
    }
}

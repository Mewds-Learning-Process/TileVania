using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float characterSpeed = 10f;
    Vector2 moveInput;
    Rigidbody2D myRigidBody;
    

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2 (moveInput.x * characterSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
}

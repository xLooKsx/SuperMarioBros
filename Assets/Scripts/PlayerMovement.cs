using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed;
    private Rigidbody2D myRigidbody2D;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        CheckPlayerInput();
    }

    private void CheckPlayerInput()
    {
        float HorizontalInput = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(HorizontalInput, 0);
        myRigidbody2D.AddForce(movement * MovementSpeed);
    }
}

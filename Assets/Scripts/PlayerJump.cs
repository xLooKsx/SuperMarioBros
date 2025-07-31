using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce;
    public float overlapCircleRadius;
    public Transform GroundCheck;
    public LayerMask WhatIsGround;

    private bool isGrounded;
    private bool isJumping;

    private Rigidbody2D myRigidbody2D;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        isGrounded = false;
        isJumping = false;
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, overlapCircleRadius, WhatIsGround);
        // isGrounded = Physics2D.Linecast(transform.position, GroundCheck.position, WhatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isJumping = true;
        }
    }

    void FixedUpdate()
    {
        if (isJumping)
        {
            myRigidbody2D.AddForce((Vector2.up * jumpForce), ForceMode2D.Impulse);
            isJumping = false;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(GroundCheck.position, overlapCircleRadius);
    }

}

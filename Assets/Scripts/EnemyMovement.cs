using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{


    public float MovementSpeed;
    private Rigidbody2D myRigidbody2D;
    private bool moveToTheRight;
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        moveToTheRight = false;
    }

    void FixedUpdate()
    {
        Vector2 movementDirection;

        if (moveToTheRight)
        {
            movementDirection = Vector2.right;
        }
        else
        {
            movementDirection = Vector2.left;
        }

        myRigidbody2D.velocity = movementDirection * MovementSpeed;
    }

    public void ChangeMovementDirection()
    {
        this.moveToTheRight = !moveToTheRight;
    }
}

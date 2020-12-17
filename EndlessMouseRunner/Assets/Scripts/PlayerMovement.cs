using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    private void Update()
    {
        ProcessedInputs();
    }

    void FixedUpdate()
    {
        Move();
    }
    void ProcessedInputs()
    {
        
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(0, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}

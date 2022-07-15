using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    float mx;

    public float jumpForce = 20f;
    public Transform feet;

    public LayerMask whatIsGround; 
    


    // Update is called once per frame
    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Vector2 move = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = move;
    }

    bool isGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.01f, whatIsGround);

        if (groundCheck != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Jump()
    {
        Vector2 jump = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = jump;
    }
}

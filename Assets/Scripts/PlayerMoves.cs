using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    public float jumpSpeed;
    private Rigidbody2D rb;

    public Transform GroundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public bool isGrounded;

    public int maxJumpHeight;
    int maxJump;



    private void Start()
    {
        maxJump = maxJumpHeight;
       rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, whatIsGround);
        if (Input.GetMouseButtonDown(0) && maxJump > 0)
        {
            maxJump--;
            Jump(); 
        }
        else if (Input.GetMouseButtonDown(0) && maxJump == 0 && isGrounded)
        {
            Jump();
        }

        if (isGrounded)
        {
            maxJump = maxJumpHeight;
        }

        
    }

    void Jump()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0, jumpSpeed));
    }

    
}
 
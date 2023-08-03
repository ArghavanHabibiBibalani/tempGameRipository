using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speedController = 20f;
    [SerializeField] float jumpSpeed = 10f;
    [SerializeField] int jumpTimes = 2;
    [SerializeField] LayerMask groroundLayer;
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] Transform feet;
    int jumpCounter = 0;
    bool isGrounded;
    float horizontalMove;
    float jumpCoolDown;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speedController * Time.deltaTime;//A == -1 == BACK AND D == 1 == FORWARD

        if (Input.GetButtonDown("Jump") && jumpCounter < jumpTimes)
        {
            Jump();
        }
    }
    void FixedUpdate()//MOVE THE CHARECTER
    {
        if ( jumpCounter < jumpTimes)
        {
            rigidBody.velocity = new Vector2(horizontalMove, rigidBody.velocity.y);

        }
    }

    void Jump()
    {
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        jumpCounter++;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
            jumpCounter = 0;
        }
        else if (Time.time < jumpCoolDown)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }



}

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
        horizontalMove = Input.GetAxisRaw("Horizontal") * speedController;//A == -1 == BACK AND D == 1 == FORWARD

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        //CheakGrounded();
    }
    void FixedUpdate()//MOVE THE CHARECTER
    {
        //if(isGrounded || jumpCounter < jumpTimes)
        //{
            rigidBody.velocity = new Vector2(horizontalMove, rigidBody.velocity.y);
        //    jumpCounter++;
        //}
      
    }
    void Jump()
    {
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
    }
    //void CheakGrounded()
    //{
    //    if (Physics2D.OverlapCircle(feet.position, 0.2f, groroundLayer))
    //    {
    //        isGrounded = true;
    //        jumpCounter = 0;
    //        jumpCoolDown = Time.time + 0.2f;
    //    }
    //    else if (Time.time < jumpCoolDown)
    //    {
    //        isGrounded = true;
    //    }
    //    else
    //    {
    //        isGrounded = false;

    //    }
    //}
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontal;
    public float jumpHeight;
    public Rigidbody2D rb;
    public float speed;
    //public float gravity;
    //public float gravitySpeed;
    public Animator playerAnim;
  

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal == 0)
        {
            playerAnim.SetBool("isMoving", false);
        }
        else
        {
            playerAnim.SetBool("isMoving", true);
        }


        //if (Input.GetKey(KeyCode.A))
        //{
        //    playerAnim.Play("Player_Walking");
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    playerAnim.Play("Player_Walking");
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    playerAnim.Play("Player_Walking");
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    playerAnim.Play("Player_Walking");
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            rb.AddForce(Vector2.up * jumpHeight);
            playerAnim.SetBool("isJumping", true);
            //gravity = 0;
        }
        else
        {
            playerAnim.SetBool("isJumping", false);
        }


        //gravity += Time.deltaTime * gravitySpeed;
        //gravity = Mathf.Clamp(gravity, 0, 10);

        //rb.gravityScale = gravity;
    }

    private void FixedUpdate()
    {
        float vertical = rb.velocity.y;
        rb.velocity = new Vector2(horizontal * speed, vertical);
    }


   
}

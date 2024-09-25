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

  

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal, 0, 0) * Time.deltaTime * speed;
    }

   
}

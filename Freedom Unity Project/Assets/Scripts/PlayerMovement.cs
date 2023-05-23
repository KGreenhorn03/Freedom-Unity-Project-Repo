using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Declare variables.

    public int speed = 5;
    private Rigidbody2D rb;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = new Vector2(rb.velocity.x, speed);

    }

}

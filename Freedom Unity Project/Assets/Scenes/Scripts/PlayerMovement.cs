using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public int speed = 2; 
    private Vector2 playerDirection;
    public float jumpForce = 30;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        playerDirection = new Vector2(Input.GetAxis("Horizontal"), 0);

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            Jump();
        }

    }

    private void Jump()
    {
        // Apply vertical force to the rigidbody
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        isJumping = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player is grounded
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void FixedUpdate()
    {

        rb.velocity = playerDirection * speed;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    // Declare variables.

    public int speed = 5;
    private Rigidbody2D rb;
    public string stage;
    // Start is called before the first frame update.
    private void Start()
    {

        // Call on the Rigidbody component.
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {

            SceneManager.LoadScene(stage);

        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {

            Application.Quit();

        }


        // If the player presses an input on the horizontal (X axis) then the player shall move in that direction at the speed determined by the "speed" variable.

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);


        // If the player moves to the right (positive) on the X axis then they shall face right.

        if (horizontalInput > 0.01)
            transform.localScale = Vector3.one;

        // If the player moves to the left (negative) on the X axis then they shall face left.

        else if (horizontalInput < -0.01)
            transform.localScale = new Vector3(-1, 1, 1);

        // If the player presses space, the player will jump.

        if (Input.GetKeyDown(KeyCode.Alpha5))
            rb.velocity = new Vector2(rb.velocity.x, speed);

    }


}

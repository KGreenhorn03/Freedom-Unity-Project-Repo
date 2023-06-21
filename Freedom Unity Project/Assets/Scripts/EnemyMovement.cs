using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    // Declare variables. 

    [SerializeField] float moveSpeed = 1f;

    Rigidbody2D  rb;
    BoxCollider2D bCollider;

    // Start is called before the first frame update.
    void Start()
    {

        // Call components into scene.

        rb = GetComponent<Rigidbody2D>();
        bCollider = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame.
    void Update()
    {

        if (isFacingRight())
        {

            // If moving right then the enemy shall face right.

            rb.velocity = new Vector2(moveSpeed, 0f);

        }
        else
        {

            // If moving left then the enemy shall face left.

            rb.velocity = new Vector2(-moveSpeed, 0f);

        }

    }

    // Function makes it possble for the enemies' rotation to equal the way they are moving.
    private bool isFacingRight()
    {

        return transform.localScale.x > Mathf.Epsilon;

    }

    //  Turns the enemy around when they collide with the collider set on either side of them.
    private void OnTriggerExit2D(Collider2D collision)
    {

        transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);

    }
}

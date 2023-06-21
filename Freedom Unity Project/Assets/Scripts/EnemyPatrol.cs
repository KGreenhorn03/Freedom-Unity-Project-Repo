using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    // Decalre variables.

    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed;

    // Start is called before the first frame update.
    void Start()
    {

        // Call Rigidbody component to scene.

        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;

    }

    // Update is called once per frame
    void Update()
    {

        // Gives the enemy a direction to go towards.

        Vector2 point = currentPoint.position - transform.position;

        // The enemy starts by moving to point B which is on the right of them.

        if (currentPoint == pointB.transform)
        {

            rb.velocity = new Vector2(speed, 0);

        }

        // If current point is not point B then the enemy will move to the left in the direction of point A.

        else
        {

            rb.velocity = new Vector2(-speed, 0);

        }

        // If the enemy reaches point B then the current point will change to point A.

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.2f && currentPoint == pointB.transform)
        {

            currentPoint = pointA.transform;

        }

        // If the enemy reaches point A then the current point will change to point B.

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.2f && currentPoint == pointA.transform)
        {

            currentPoint = pointB.transform;

        }

    }

    // Highlights the patrol lines in-scene
    private void OnDrawGizmos()
    {

        Gizmos.DrawWireSphere(pointA.transform.position, 0.05f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.05f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);

    }
}

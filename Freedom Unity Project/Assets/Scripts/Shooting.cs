using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    // Defclare variables.

    public GameObject bulletPrefab;
    public Transform shootingPoint;
    public float bulletSpeed = 10f;

    // Update is called once per frame
    void Update()
    {

        // If player presses keypad number 6, the shoot funciton will be used.

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {

            Shoot();

        }

    }

    // Shoot function makes in game attacks work.
    void Shoot()
    {

        // Bullet direction will be determined by which way the player is moving.

        float aimDirection = Input.GetAxis("Horizontal");

        // Declare bullet variables.

        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();

        // If player is facing the positive on the X axis the bullet will shoot right.

        if (aimDirection > 0.01)
            bulletRigidbody.velocity = new Vector2(1 * bulletSpeed, bulletRigidbody.velocity.y);

        // If player is facing the negative on the X axis the bullet will shoot right

        else if (aimDirection < -0.01)
            bulletRigidbody.velocity = new Vector2(-1 * bulletSpeed, bulletRigidbody.velocity.y);

    }

}

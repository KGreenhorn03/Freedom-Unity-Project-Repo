using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform shootingPoint;
    public float bulletSpeed = 10f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            Shoot();

        }

    }

    void Shoot()
    {

        float aimDirection = Input.GetAxis("Horizontal");

        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();


        if (aimDirection > 0.01)
            bulletRigidbody.velocity = new Vector2(1 * bulletSpeed, bulletRigidbody.velocity.y);
        else if (aimDirection < -0.01)
            bulletRigidbody.velocity = new Vector2(-1 * bulletSpeed, bulletRigidbody.velocity.y);

    }

}

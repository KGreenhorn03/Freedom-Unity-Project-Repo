using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileEnemy : MonoBehaviour
{

    // Declare variables.

    public GameObject bulletPrefab;
    public float shootingRate = 2f;
    public Transform shootingPoint;

    private Transform player;
    private float shootingTimer;

    // Start is called before the first frame update
    void Start()
    {

        // Player variable is associated with the right tag and shooting timer set to 0.

        player = GameObject.FindGameObjectWithTag("Player").transform;
        shootingTimer = 0f;

    }

    // Update is called once per frame
    void Update()
    {

        // If the shooting timer is equal to 0 call the "Shoot" function and 

        if (shootingTimer <= 0)
        {

            Shoot();
            shootingTimer = 1f / shootingRate;

        }

        shootingTimer -= Time.deltaTime;
        
    }


    // Function makes bullet shoot out from the gun.
    private void Shoot()
    {

        // Bullet will be spawned at the desired "shooting point".

        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);

        // The bullet will determine which way the player is facing so it knows which way to fire.

        Vector2 direction = (player.position - transform.position).normalized;

        // This line gives the bullet a velocity so that it will actually move in the desired direction.

        bullet.GetComponent<Rigidbody2D>().velocity = direction * 10f;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileEnemy : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float shootingRate = 2f;
    public Transform shootingPoint;

    private Transform player;
    private float shootingTimer;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        shootingTimer = 0f;

    }

    // Update is called once per frame
    void Update()
    {

        if (shootingTimer <= 0)
        {

            Shoot();
            shootingTimer = 1f / shootingRate;

        }

        shootingTimer -= Time.deltaTime;
        
    }

    private void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);

        Vector2 direction = (player.position - transform.position).normalized;

        bullet.GetComponent<Rigidbody2D>().velocity = direction * 10f;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void Update()
    {

        Destroy(gameObject, 1f);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(gameObject);

    }

}

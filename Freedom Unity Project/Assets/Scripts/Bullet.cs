using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Update is called once per frame.
    private void Update()
    {

        // Bullet gets destroyed after being in the scene for a short time as to stop the bullets flying forever.
        Destroy(gameObject, 1f);

    }

    // On collision with an object in the same physics layer.
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // The bullet will get destroyed.
        Destroy(gameObject);

    }

}

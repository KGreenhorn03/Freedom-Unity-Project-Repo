using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    // Declare variables.

    public int damageAmount = 25;

    // Function called on once a trigger has been set off.
    private void OnTriggerEnter2D(Collider2D other)
    {

        // For the players' health, the 

        HealthSystem health = other.GetComponent<HealthSystem>();
        if (health != null)
        {
            health.Damage(damageAmount);
        }

        EnemyHealth health1 = other.GetComponent<EnemyHealth>();
        if (health1 != null)
        {

            health1.Damage(damageAmount);

        }

    }

}

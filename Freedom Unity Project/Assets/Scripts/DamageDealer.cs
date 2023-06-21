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

        // For the players' health, the player will take the predetermined damage amount if the trigger is set off.

        HealthSystem health = other.GetComponent<HealthSystem>();
        if (health != null)
        {
            health.Damage(damageAmount);
        }

        // For the robots' health, the robots will take the predetermined damage amount if the trigger is set off.

        EnemyHealth health1 = other.GetComponent<EnemyHealth>();
        if (health1 != null)
        {

            health1.Damage(damageAmount);

        }

        // For the boss' health, the boss will take the predetermined damage amount if the trigger is set off.

        BossHealth health2 = other.GetComponent<BossHealth>();
        if (health2 != null)
        {

            health2.Damage(damageAmount);

        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{

    public int damageAmount = 25;

    private void OnTriggerEnter2D(Collider2D other)
    {
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

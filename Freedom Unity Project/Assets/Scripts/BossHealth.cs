using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{

    // Declare Variables 

    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {

        currentHealth = maxHealth;

    }

    // Function will be used in the DamageDealer script so the desired amount of damage can be inflicted.
    // Function will be used to determine the players current health and what happens in the event of health reaching 0.
    public void Damage(int damageAmount)
    {

        // Current health will be equal to whatever remains after damage has been dealt.

        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {

            // If health reaches 0, the Die function will be called.

            Die();

        }

    }

    // This function determines what will happen to the enemy upon dying.
    private void Die()
    {

        // The enemy will be destroyed in the event of their health reaching 0.

        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
}

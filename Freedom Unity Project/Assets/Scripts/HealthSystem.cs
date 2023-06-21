using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{

    // Declare Variables.

    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update.
    private void Start()
    {

        // At the start of the scene the current health of the player is to equal the maximum health they can have.
    
        currentHealth = maxHealth;

    }

    // This function handles the damage dealt to the player.
    public void Damage(int damageAmount)
    {

        // Current health will have the damage amount subtracted from it.

        currentHealth -= damageAmount;

        // If the current health depletes to 0 then the scene will restart.

        if (currentHealth <= 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }

}

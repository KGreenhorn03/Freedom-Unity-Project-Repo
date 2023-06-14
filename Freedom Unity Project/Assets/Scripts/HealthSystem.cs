using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{

    // Declare Variables.
    public Slider healthBarSlider;

    public int maxHealth = 100;
    public int currentHealth;

    // 
    private void Start()
    {

        currentHealth = maxHealth;

    }

    public void Damage(int damageAmount)
    {

        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }
    public void Heal(int amount)
    {

        currentHealth += amount;

        if (currentHealth > maxHealth)
        {

            currentHealth = maxHealth;

        }

    }

}

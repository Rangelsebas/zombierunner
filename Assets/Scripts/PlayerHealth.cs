using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float hitPoints = 100f;
    public float currentHealth;

    public HealthBar healthBar;

    public void TakeDamage(float damage) 
    {
        hitPoints -= damage;
        if (hitPoints <= 0) 
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void Start()
    {
        currentHealth = hitPoints;
        healthBar.SetMaxHealth(hitPoints);
    }
}

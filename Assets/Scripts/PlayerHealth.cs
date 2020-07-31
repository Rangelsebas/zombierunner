using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float hitPoints = 200f;
    public float currentHealth;

    public HealthBar healthBar;

    public void TakeDamage(float damage) 
    {
        hitPoints -= damage;
        if (hitPoints <= 0) 
        {
            Debug.Log("you dead");
        }
        healthBar.SetHealth(currentHealth);
    }

    void Start()
    {
        currentHealth = hitPoints;
        healthBar.SetMaxHealth(hitPoints);
    }
}

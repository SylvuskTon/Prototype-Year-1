using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int currentHealth;
    public int maxHP = 20;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHP;
        healthBar.SetMaxHealth(maxHP);
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        healthBar.SetHealth(currentHealth);
    }
}

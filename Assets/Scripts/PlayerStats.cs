using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int currentHealth;
    public int maxHP = 20;

    public HealthBar healthBar;

    public GameObject gameOverPanel;

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
            
            PlayerDie();
        }

        healthBar.SetHealth(currentHealth);
    }

    void PlayerDie()
    {
      
        gameOverPanel.SetActive(true);
        Destroy(gameObject);
    }

}

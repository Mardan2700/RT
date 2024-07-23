using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    

    public TMP_Text healthText;
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }

    public void TakeDamage(int dmg)
    {
        currentHealth = currentHealth - dmg;
        UpdateHealthText();
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
            Time.timeScale = 0.0f;
            Debug.Log("Training Beendet");
    }
    
    void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth.ToString();
        }
    }
}

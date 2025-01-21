using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public float health;
    public Slider healthbar;

    public int damage;
    public int heal;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage (float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            SceneManager.LoadScene("Lose Screen");
        }
        UpdateHealthBar();
    }

    public void Healing (int amount)
    {
        health += amount;
    }

    void UpdateHealthBar()
    {
        healthbar.value = (float)health / maxHealth; // This connects the health bar to the player's health
    }



}

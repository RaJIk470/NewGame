using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    private int currentHealth;
    public HealthBar healthBar;
    
    void Start()
    {
        // при старте ставим макс хп
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    
    void Damage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(20);
            Death();
        }
    }
    void Death()
    {
        if (currentHealth <= 0)
        {
            Debug.Log("Dead");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
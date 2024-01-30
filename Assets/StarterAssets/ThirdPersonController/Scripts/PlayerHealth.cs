using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthSlider;
    public float maxHealth = 100f;
    private float currentHealth;
    public Animator animator;

    public float CurrentHealth
    {
        get { return currentHealth; }
    }
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    void Update()
    {
        healthSlider.value = currentHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        // Garantir que a saúde não seja menor que zero
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);

        
        if (currentHealth <= 0)
        {
            // Play death animation
            animator.SetTrigger("die");
            Debug.Log("die");
        }
        else
        {
            // Play get hit animation
            animator.SetTrigger("damage");
            Debug.Log("damage");
        }
    }
}

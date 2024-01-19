using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon : MonoBehaviour
{
    private int maxHP = 100;
    public Slider healthBar;
    public Animator animator;
    int currentHealth;

    void Update()
    {
        healthBar.value = currentHealth;
    }

    void Start()
    {
        currentHealth = maxHP;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

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
/*
    // Chame esta função quando quiser realizar o ataque da garra
    public void PerformClawAttack()
    {
        // Ative a área de colisão da garra
        clawAttack.gameObject.SetActive(true);

        // Execute a animação de ataque da garra
        animator.SetTrigger("clawAttack");
    }
*/    
}

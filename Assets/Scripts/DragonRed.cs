using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonRed : MonoBehaviour
{
    private int maxHP = 300;
    public Slider healthBar;
    public Animator animator;
    int currentHealth;

    // Referência ao script GenerateEnemies
    private GenerateEnemies generateEnemies;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHP;
        generateEnemies = FindObjectOfType<GenerateEnemies>(); // Encontrar o script GenerateEnemies na cena
    }

    void Update()
    {
        healthBar.value = currentHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            // Play death animation
            animator.SetTrigger("die");
            Debug.Log("die");

            // Notificar o script GenerateEnemies sobre a morte do mob após 1 segundo
            Invoke("NotifyEnemyDeath", 3f);
        }
        else
        {
            // Play get hit animation
            animator.SetTrigger("damage");
            Debug.Log("damage");
        }
    }

    // Método para notificar o script GenerateEnemies sobre a morte do mob
    void NotifyEnemyDeath()
    {
        if (generateEnemies != null)
        {
            generateEnemies.IncrementMobsKilled();
        }

        // Destruir o objeto Dragon após notificar o script GenerateEnemies
        Destroy(gameObject);
    }

}
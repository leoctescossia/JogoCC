using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthSlider;
    public float maxHealth = 100f;
    private float currentHealth;

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
            Debug.Log("die");
        }
    }
}

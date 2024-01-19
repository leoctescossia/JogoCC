using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonDamage : MonoBehaviour
{

    public int playerHP = 100;
    public bool isGameOver;
    public Slider healthBar;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        currentHealth = playerHP;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth;

        if(isGameOver)
        {

        }
    }

    public void TakeDamage(int damageAmount)
    {
        playerHP -= damageAmount;
        if(playerHP <= 0)
        {
            Debug.Log("die");
            isGameOver = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonClawAttack : MonoBehaviour
{
    public int damageAmount = 20;
/*
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto atingido tem a tag "Player"
        if (other.CompareTag("Player"))
        {
            // Obtém o componente Enemy do objeto atingido
            Player player = other.GetComponent<Player>();

            // Se o objeto atingido tiver o componente Player, aplique o dano
            if (player != null)
            {
                player.TakeDamage(damageAmount);
            }
        }
    }
    */
}

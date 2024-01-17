using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletSpeed = 10f;
    public float timeBetweenShots = 0.5f;

    private float shotTimer;

    void Update()
    {
        // Atualiza o temporizador entre os disparos
        shotTimer += Time.deltaTime;

        // Verifica se o botão de atirar foi pressionado e tempo entre disparos foi atingido
        if (Input.GetButtonDown("Fire1") && shotTimer >= timeBetweenShots)
        {
            // Dispara a função de atirar
            Shoot();
            // Reinicia o temporizador
            shotTimer = 0f;
        }
    }

    void Shoot()
    {
        // Cria uma bala na posição do firePoint
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Obtém a direção para o inimigo mais próximo
        Vector3 direction = GetDirectionToClosestEnemy();

        // Configura a velocidade da bala na direção do inimigo
        bullet.GetComponent<Rigidbody>().velocity = direction.normalized * bulletSpeed;
    }

    Vector3 GetDirectionToClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemies");

        if (enemies.Length > 0)
        {
            Transform closestEnemy = enemies[0].transform;
            float closestDistance = Vector3.Distance(transform.position, closestEnemy.position);

            // Encontra o inimigo mais próximo
            foreach (GameObject enemy in enemies)
            {
                float distance = Vector3.Distance(transform.position, enemy.transform.position);

                if (distance < closestDistance)
                {
                    closestEnemy = enemy.transform;
                    closestDistance = distance;
                }
            }

            // Calcula a direção para o inimigo mais próximo
            return (closestEnemy.position - transform.position).normalized;
        }

        // Retorna uma direção padrão se não houver inimigos
        return Vector3.right;
    }
}

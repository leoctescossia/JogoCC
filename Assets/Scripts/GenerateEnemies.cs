using System.Collections;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    int maxEnemyCount = 2;
    private int mobsKilled;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartEnemySpawn());
    }

    IEnumerator StartEnemySpawn()
    {
        yield return new WaitForSeconds(1f); // Atraso de 1 segundo antes de começar a gerar inimigos
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        int enemyCount = 0;

        while (enemyCount < maxEnemyCount)
        {
            // Ajuste as coordenadas conforme necessário
            float xPos = 178.89f + Random.Range(-5f, 5f); // Adicionando um deslocamento aleatório para x
            float y = 0.02f;
            float zPos = 42f + Random.Range(-5f, 5f); // Adicionando um deslocamento aleatório para z

            Instantiate(theEnemy, new Vector3(xPos, y, zPos), Quaternion.identity);

            enemyCount++;
            yield return new WaitForSeconds(0.1f);
        }
    }

    // Método para incrementar o número de mobs mortos
    public void IncrementMobsKilled()
    {
        mobsKilled++;
        
    }

    // Método para obter o número de mobs mortos
    public int GetMobsKilled()
    {
        return mobsKilled;
    }
}

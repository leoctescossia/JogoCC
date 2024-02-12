using System.Collections;
using UnityEngine;

public class GenerateBoss : MonoBehaviour
{
    public GameObject bossEnemy; // Adicione o prefab do Boss aqui
    private bool bossSpawned = false;
    
    // Referência ao script GenerateEnemies
    private GenerateEnemies generateEnemies;

    // Use Awake para inicialização
    void Start()
    {
        generateEnemies = FindObjectOfType<GenerateEnemies>(); // Encontrar o script GenerateEnemies na cena
        StartCoroutine(CheckSpawnBoss());
    }

    IEnumerator CheckSpawnBoss()
    {
        while (true)
        {
            // Verifica se o boss já foi spawnado e se o número de mobs mortos atingiu o limite
            if (!bossSpawned && generateEnemies.GetMobsKilled() >= 3)
            {
                Debug.Log("Spawnando Boss...");
                SpawnBoss();
                bossSpawned = true;
            }

            yield return new WaitForSeconds(5f); // Ajuste o intervalo conforme necessário
        }
    }

    void SpawnBoss()
    {
        // Ajuste as coordenadas conforme necessário
        float xPos = 182f + Random.Range(-5f, 5f); // Adicionando um deslocamento aleatório para x
        float y = 0.02f;
        float zPos = 42f + Random.Range(-5f, 5f); // Adicionando um deslocamento aleatório para z

        Instantiate(bossEnemy, new Vector3(xPos, y, zPos), Quaternion.identity);
    }

    
    
}

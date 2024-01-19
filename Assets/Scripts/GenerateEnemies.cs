using System.Collections;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartEnemySpawn());
    }

    IEnumerator StartEnemySpawn()
    {
        yield return new WaitForSeconds(10f); // Atraso de 10 segundos antes de começar a gerar inimigos
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            // Ajuste as coordenadas conforme necessário
            float xPos = 178.89f + Random.Range(-5f, 5f); // Adicionando um deslocamento aleatório para x
            float y = 0.02f;
            float zPos = 42f + Random.Range(-5f, 5f); // Adicionando um deslocamento aleatório para z

            Instantiate(theEnemy, new Vector3(xPos, y, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }
}

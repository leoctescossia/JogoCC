using System.Collections;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartEnemyDropAfterDelay(10f)); // Inicia a rotina após 10 segundos
    }

    IEnumerator StartEnemyDropAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
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

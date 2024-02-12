using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayMobsKilled : MonoBehaviour
{
    public TextMeshProUGUI mobsKilledText;
    private GenerateEnemies generateEnemies;

    // Atualize o texto para mostrar a contagem de mobs mortos

    void Start()
    {
        generateEnemies = FindObjectOfType<GenerateEnemies>();
        if (generateEnemies == null)
        {
            Debug.LogError("GenerateEnemies não foi encontrado na cena.");
        }
    }

    void Update()
    {
        mobsKilledText.text = "" + generateEnemies.GetMobsKilled(); 
    }
}

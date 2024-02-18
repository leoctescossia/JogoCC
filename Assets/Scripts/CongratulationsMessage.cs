using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; // Adicione esta linha para acessar o SceneManager

public class CongratulationsMessage : MonoBehaviour
{
    public TextMeshProUGUI congratulationsText;
    private GenerateEnemies generateEnemies;

    void Start()
    {
        generateEnemies = FindObjectOfType<GenerateEnemies>(); // Encontre o script GenerateEnemies na cena
        // Desativa o texto no início do jogo
        HideCongratulationsMessage();
    }

    // Método para mostrar a mensagem de parabéns
    public void ShowCongratulationsMessage()
    {
        congratulationsText.gameObject.SetActive(true);
        // Chame a função para redirecionar para o menu após 5 segundos
        Invoke("RedirectToMenu", 5f);
    }

    // Método para ocultar a mensagem de parabéns
    public void HideCongratulationsMessage()
    {
        congratulationsText.gameObject.SetActive(false);
    }

    // Método para redirecionar para o menu
    void RedirectToMenu()
    {
        // Carregue a cena do menu
        SceneManager.LoadScene("Menu");
    }

    void Update()
    {
        // Verifica se generateEnemies foi inicializado corretamente
        if (generateEnemies != null)
        {
            // Verifica se o boss já foi spawnado e se o número de mobs mortos atingiu o limite
            if (generateEnemies.GetMobsKilled() >= 51)
            {
                ShowCongratulationsMessage();
            }
        }
    }
}

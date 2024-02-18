using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public PlayerHealth playerHealth;  // Referência ao componente de saúde do jogador
    public GameObject gameoverMenu;
    public static bool isPaused;

    void Start()
    {
        gameoverMenu.SetActive(false);
    }

    void Update()
    {
        // Verifica se a saúde do jogador chegou a 0
        if (playerHealth != null && playerHealth.CurrentHealth <= 0)
        {
            // Se sim, chama a função de Game Over
            CallGameOver();
        }

    }

    public void CallGameOver()
    {
        gameoverMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        
        // Chama o método para voltar para o menu após 5 segundos
        Invoke("GameOverBackToMenu", 5f);
    }

    public void RestartGame()
    {
        // Recarrega a cena atual
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isPaused = false;
    }

    public void GameOverBackToMenu()
    {
        // Recarrega a cena do menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

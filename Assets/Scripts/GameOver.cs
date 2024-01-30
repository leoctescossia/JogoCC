using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public PlayerHealth playerHealth;  // Referência ao componente de saúde do jogador
    public GameObject gameoverMenu;
    public static bool isPaused;

    private void Start()
    {
        gameoverMenu.SetActive(false);
    }

    private void Update()
    {
        // Verifica se a saúde do jogador chegou a 0
        if (playerHealth != null && playerHealth.CurrentHealth <= 0)
        {
            // Se sim, chama a função de Game Over
            CallGameOver();
        }
    }

/*
    private void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus && isPaused)
        {
            // Se o jogo foi pausado e está minimizado, mantenha o tempo parado
            Time.timeScale = 0f;
        }
    }
*/
    private void CallGameOver()
    {
        gameoverMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void RestartGame()
    {
        CleanupObjects();
        // Recarrega a cena atual
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isPaused = false;
    }

    public void GameOverBackToMenu()
    {
        CleanupObjects();
        // Recarrega a cena do menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        isPaused = false;
    }

    private void CleanupObjects()
    {
        // Cancela todos os eventos Invoke pendentes
        CancelInvoke();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

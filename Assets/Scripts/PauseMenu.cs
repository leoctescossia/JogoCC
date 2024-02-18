using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public PlayerHealth playerHealth;  // Referência ao componente de saúde do jogador

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        // Verifica se a vida do jogador é maior que 0
        if (playerHealth.CurrentHealth > 0)
        {
            // Se sim, permite a interação com o botão "esc"
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused)
                {
                    ResumeGame();
                }
                else
                {
                    PausedGame();
                }
            }

            // Verifica se o jogo perdeu o foco
            if (!Application.isFocused && isPaused)
            {
                // Se o jogo perdeu o foco e está pausado, retoma o jogo
                ResumeGame();
            }
        }
    }


    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus && isPaused)
        {
            // Se o jogo foi pausado e está minimizado, mantenha o tempo parado
            Time.timeScale = 0f;
        }
    }

    public void PausedGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

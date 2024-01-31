using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
    public void BackToMenu()
    {  
        SceneManager.LoadScene("Menu");
    }
    public void GoToComandos()
    {
        SceneManager.LoadScene("Comandos");
    }

    public void QuitGame(){
        Application.Quit();
    }
}

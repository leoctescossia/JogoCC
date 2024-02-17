using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FasesMenu : MonoBehaviour
{
    public void Fase1(){
        SceneManager.LoadScene("History");
        Time.timeScale = 1f;
    }
    public void Fase2(){
        SceneManager.LoadScene("History 2");
        Time.timeScale = 1f;
    }
    public void Fase3(){
        SceneManager.LoadScene("History 3");
        Time.timeScale = 1f;
    }
    
}

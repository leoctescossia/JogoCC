using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FasesMenu : MonoBehaviour
{
    public void Fase1(){
        SceneManager.LoadScene("SampleScene");
    }
    public void Fase2(){
        SceneManager.LoadScene("Fase2");
    }
    public void Fase3(){
        SceneManager.LoadScene("Fase3");
    }
    
}

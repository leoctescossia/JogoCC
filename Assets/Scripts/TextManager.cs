using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    public float sceneDuration = 120f;  // Duração da cena em segundos

    private void Start()
    {
        Invoke("LoadNextScene", sceneDuration);
    }

    private void LoadNextScene()
    {
        // Carrega a próxima cena
        SceneManager.LoadScene("SampleScene"); // Substitua "NomeDaProximaCena" pelo nome da próxima cena
    }

     public void EndScene()
    {
        // Lógica para encerrar a cena
        Debug.Log("A cena está sendo encerrada...");
        // Adicione aqui qualquer outra lógica que você precise para encerrar a cena
    }
}

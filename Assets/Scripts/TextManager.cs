using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    public float sceneDuration; // Duração da cena em segundos

    private void Start()
    {
        Invoke("LoadNextScene", sceneDuration);
    }

    private void LoadNextScene()
    {
        // Carrega a próxima cena
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("SampleScene");
        //SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }

     public void EndScene()
    {
        // Lógica para encerrar a cena
        Debug.Log("A cena está sendo encerrada...");
        // Adicione aqui qualquer outra lógica que você precise para encerrar a cena
    }
}

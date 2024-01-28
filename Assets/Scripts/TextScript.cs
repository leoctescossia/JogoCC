using UnityEngine;

public class TextScript : MonoBehaviour
{
    public GameObject sceneManager;  // Referência ao objeto que gerencia a transição de cena
    public float visibilityThreshold = 20f;  // Ajuste conforme necessário

    private void Update()
    {
        // Verifica se o texto está visível na tela
        if (IsTextVisible())
        {
            // Texto ainda visível
        }
        else
        {
            // Texto não visível, inicia a transição de cena
            if (sceneManager != null)
            {
                sceneManager.GetComponent<TextManager>().EndScene();  // Substitua SceneManagerScript pelo nome do seu script de gerenciamento de cena
            }
        }
    }

    private bool IsTextVisible()
    {
        // Obtém as coordenadas do texto na tela
        Vector3 screenPoint = Camera.main.WorldToViewportPoint(transform.position);

        // Verifica se as coordenadas estão dentro dos limites da tela
        return screenPoint.x > 0 - visibilityThreshold &&
               screenPoint.x < 1 + visibilityThreshold &&
               screenPoint.y > 0 - visibilityThreshold &&
               screenPoint.y < 1 + visibilityThreshold &&
               screenPoint.z > 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNameTowardsCamera : MonoBehaviour
{
   void Update()
    {
        // Obtem a posição do objeto e a posição da câmera
        Vector3 objectPosition = transform.position;
        Vector3 cameraPosition = Camera.main.transform.position;

        // Calcula a direção da câmera em relação ao objeto
        Vector3 lookAtDirection = cameraPosition - objectPosition;

        // Ignora a rotação em roll (z-axis)
        lookAtDirection.y = 0f;

        // Rotaciona o objeto para sempre encarar a câmera
        transform.rotation = Quaternion.LookRotation(lookAtDirection);
    }
}

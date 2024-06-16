using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        // Movimiento lateral (izquierda y derecha)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calcula el vector de movimiento basado en la entrada horizontal del teclado
        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, 0.0f) * moveSpeed * Time.deltaTime;

        // Aplica el movimiento a la posición de la cámara
        transform.position += moveDirection;
    }
}
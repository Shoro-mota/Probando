using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform cameraTransform; // Transform de la cámara
    public float speed = 5f; // Velocidad de movimiento del personaje
    public Vector3 offset = new Vector3(0, 0, -5); // Desplazamiento respecto a la cámara

    void Update()
    {
        // Calcular la posición de destino
        Vector3 targetPosition = cameraTransform.position + offset;
        
        // Mover el personaje hacia la posición de destino
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
    }
}

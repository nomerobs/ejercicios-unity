using UnityEngine;

public class si17 : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento

    void Update()
    {
        // Dirección hacia la parte inferior derecha (X+, Y-)
        Vector3 direction = new Vector3(1, -1, 0).normalized;

        // Actualizar la posición del jugador
        transform.position = transform.position + direction * moveSpeed;
    }
}

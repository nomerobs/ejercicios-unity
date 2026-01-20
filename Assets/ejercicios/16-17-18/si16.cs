using UnityEngine;

public class si16 : MonoBehaviour
{
    void Update()
    {
        // Dirección hacia la parte inferior derecha (X+, Y-)
        Vector3 direction = new Vector3(1, -1, 0).normalized;

        // Actualizar la posición del jugador
        transform.position = transform.position + direction;
    }
}

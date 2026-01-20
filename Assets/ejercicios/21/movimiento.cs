using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
    Vector3 movement;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movement = new Vector3(0, 1, 0).normalized * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movement = new Vector3(-1, 0, 0).normalized * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement = new Vector3(0, -1, 0).normalized * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement = new Vector3(1, 0, 0).normalized * moveSpeed * Time.deltaTime;
        }
        else
        {
            movement = new Vector3(0, 0, 0).normalized * moveSpeed * Time.deltaTime;
        }

        // Mover al jugador
        transform.Translate(movement);
    }
}

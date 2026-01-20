using Unity.VisualScripting;
using UnityEngine;

public class movment3 : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
    Vector3 movement;
    public GameObject left;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movement = new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movement = new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement = new Vector3(0, -1, 0) * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement = new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime;
        }
        else
        {
            movement = new Vector3(0, 0, 0) * moveSpeed * Time.deltaTime;
        }


        transform.Translate(movement * Time.deltaTime * moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        transform.position = left.transform.position;
    }
}

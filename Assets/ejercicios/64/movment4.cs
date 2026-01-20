using UnityEngine;

public class movment4 : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
    Vector3 movement;
    public GameObject spawn;
    public AudioSource audioData;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spawn, transform.position, transform.rotation);
            audioData.Play(0);
        }


        transform.Translate(movement * Time.deltaTime * moveSpeed);
    }
}

using UnityEngine;

public class move46 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
   
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
    Vector3 movement;
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
}

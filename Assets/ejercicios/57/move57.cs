using UnityEngine;

public class move57 : MonoBehaviour
{
   
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    Vector3 movement;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement = new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime;
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

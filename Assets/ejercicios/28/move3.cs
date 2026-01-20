using UnityEngine;

public class move3 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 20f;
    Vector3 movement;
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement = new Vector3(0, 1, 0) * jumpForce * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
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


            transform.position = transform.position + movement;
    }
}

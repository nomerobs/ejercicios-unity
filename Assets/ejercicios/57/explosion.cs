using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class explosion : MonoBehaviour
{
    Rigidbody2D rb;         // El Rigidbody2D de este objeto
    public Transform target;       // El objeto del cual queremos alejarnos
    public float forceAmount = 10f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("si");
            Vector2 direction = transform.position - target.position;
            direction.Normalize();
            rb.AddForce(direction * forceAmount, ForceMode2D.Impulse);
        }
    }
}

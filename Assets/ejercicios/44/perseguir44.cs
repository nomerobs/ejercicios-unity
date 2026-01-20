using UnityEngine;

public class perseguir44 : MonoBehaviour
{
    public Transform objetivo;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direccion = objetivo.position - transform.position;
        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angulo;

        transform.position = transform.position + transform.up * 3f * Time.deltaTime;
    }
}

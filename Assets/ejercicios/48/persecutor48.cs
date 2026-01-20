using UnityEngine;

public class persecutor48 : MonoBehaviour
{
    public GameObject objetivo;
    public float maxDistancia;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 posicionActual = rb.position;
        Vector2 destino = Vector2.MoveTowards(
            posicionActual,
            objetivo.transform.position,
            maxDistancia * Time.fixedDeltaTime
        );

        rb.MovePosition(destino);
    }
}

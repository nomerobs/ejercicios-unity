using UnityEngine;

public class persecutor47 : MonoBehaviour
{
    public GameObject objetivo;
    public float maxDistancia;
    private void OnTriggerStay2D(Collider2D collision)
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, maxDistancia * Time.deltaTime);
    }
}

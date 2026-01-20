using UnityEngine;

public class persecutor : MonoBehaviour
{
    public GameObject objetivo;
    public float maxDistancia;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, maxDistancia * Time.deltaTime);
    }
}

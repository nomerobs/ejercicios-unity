using UnityEngine;

public class impulsoAlto : MonoBehaviour
{
    public float potencia;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Translate(new Vector3(0, 1, 0) * potencia * Time.deltaTime);
    }

}

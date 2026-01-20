using UnityEngine;

public class tabla : MonoBehaviour
{
    public float numero;

    void Start()
    {
        Debug.Log("Tabla de multiplicar del: " + numero);

        // Loop from 0 to 10
        for (int i = 0; i <= 10; i++)
        {
            float result = numero * i;
            Debug.Log(numero + " * " + i + " = " + result);
        }
    }
}

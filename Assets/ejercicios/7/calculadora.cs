using UnityEngine;
using static UnityEngine.Rendering.HDROutputUtils;

public class calculadora : MonoBehaviour
{

    public float numero1;
    public float numero2;
    public string operacion; // Puedes poner "+", "-", "*", "/"


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float resultado = 0f;
        bool operacionValida = true;

        switch (operacion)
        {
            case "+":
                resultado = numero1 + numero2;
                break;
            case "-":
                resultado = numero1 - numero2;
                break;
            case "*":
                resultado = numero1 * numero2;
                break;
            case "/":
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Debug.LogError("Error: División por cero.");
                    operacionValida = false;
                }
                break;
            default:
                Debug.LogError("Operación no válida. Usa '+', '-', '*', '/'");
                operacionValida = false;
                break;
        }

        if (operacionValida)
        {
            Debug.Log("Resultado: " + resultado);
        }

    }
}

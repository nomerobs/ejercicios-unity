using UnityEngine;

public class e9 : MonoBehaviour
{
    int operacion;

    float numberA;
    float numberB;


    void Start()
    {
        operacion = Random.Range(0, 4);

        numberA = Random.Range(0, 9) / 10f;
        numberB = Random.Range(0, 9) / 10f;


        if (operacion == 0)
        {
            Debug.Log(numberA + numberB);
        }
        else if (operacion == 1)
        {
            Debug.Log(numberA - numberB);
        }
        else if (operacion == 2)
        {
            Debug.Log(numberA * numberB);
        }
        else if (operacion == 3)
        {
            Debug.Log(numberA / numberB);
        }
        else
        {
            Debug.Log(numberA % numberB);
        }

    }
}

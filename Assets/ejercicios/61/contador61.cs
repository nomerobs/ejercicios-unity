using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class contador61 : MonoBehaviour
{
    int cuenta = 0;
    public Text enemigos;

    private void Start()
    {
        enemigos = GetComponent<Text>();
        enemigos.text = cuenta.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cuenta++;
            enemigos.text = cuenta.ToString();

            // Inicia la corutina correctamente
            StartCoroutine(contar());
        }
    }

    IEnumerator contar()
    {
        // Espera 3 segundos
        yield return new WaitForSeconds(3f);

        // Después de esperar, disminuye la cuenta
        cuenta--;
        enemigos.text = cuenta.ToString();
    }
}

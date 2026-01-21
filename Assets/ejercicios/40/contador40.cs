using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class contador40 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int cuenta;
    public Text contar;
    private void Start()
    {
        contar = GetComponent<Text>();
    }
    public void contador()
    {
        cuenta++;
        contar.text = cuenta.ToString();
    }
}

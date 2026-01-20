using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class contador : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int cuenta;
    public Text enemigos;
    private void Start()
    {
        enemigos = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cuenta++;
            enemigos.text = cuenta.ToString();
        }
    }
}

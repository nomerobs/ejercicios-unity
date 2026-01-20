using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transiciones : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Temporizador10Segundos());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("66_red", LoadSceneMode.Additive);
        }
    }
    IEnumerator Temporizador10Segundos()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("66_green", LoadSceneMode.Additive);
    }
    public void UIbutton()
    {
        SceneManager.LoadScene("66_blue", LoadSceneMode.Additive);
    }
}

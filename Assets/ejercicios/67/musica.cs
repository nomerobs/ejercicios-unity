using UnityEngine;
using UnityEngine.SceneManagement;

public class musica : MonoBehaviour
{
    private static musica instance;

    void Awake()
    {
        // Si ya hay una instancia, destruye este objeto para no duplicar
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // Si no hay instancia, este será el único objeto Musica
        instance = this;
        DontDestroyOnLoad(gameObject);

        // Asegurarse de que el AudioSource esté sonando
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null && !audio.isPlaying)
        {
            audio.Play();
        }
        else if (audio == null)
        {
            Debug.LogError("No hay AudioSource asignado al objeto Musica.");
        }
    }

    void Update()
    {
        // Cambiar de escena al presionar Espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string nextScene = currentScene.name == "e67_red" ? "e67_blue" : "e67_red";
            SceneManager.LoadScene(nextScene);
        }
    }
}

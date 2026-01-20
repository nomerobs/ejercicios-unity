using UnityEngine;

public class seguir : MonoBehaviour
{
    public GameObject siguiendo;
    // Update is called once per frame
    void Update()
    {
        transform.position = siguiendo.transform.position;
    }
}

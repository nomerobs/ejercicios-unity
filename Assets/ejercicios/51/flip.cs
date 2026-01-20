using UnityEngine;

public class flip : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, 180, 0);
        }
    }
}

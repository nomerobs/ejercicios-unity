using UnityEngine;

public class invertGravity : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics2D.gravity = -Physics2D.gravity;
        }
        
    }
}

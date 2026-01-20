using UnityEngine;

public class random100 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int count = 0;
        while (count < 100)
        {
            count++;
            Debug.Log(Random.Range(0, 10));
        }

    }

}

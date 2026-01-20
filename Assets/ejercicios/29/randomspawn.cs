using UnityEngine;

public class randomspawn : MonoBehaviour
{
    public GameObject boxPrefab;       // Assign your box prefab in the Inspector
    public float spawnHeight = 5f;     // Y position at top of screen
    public float minX = -8f;           // Left boundary
    public float maxX = 8f;            // Right boundary
    public float spawnInterval = 2f;   // Time between spawns

    private void Start()
    {
        // Start spawning boxes repeatedly
        InvokeRepeating("SpawnBox", 1f, spawnInterval);
    }

    void SpawnBox()
    {
        // Pick a random X position
        float randomX = Random.Range(minX, maxX);

        // Spawn position at top
        Vector3 spawnPos = new Vector3(randomX, spawnHeight, 0);

        // Instantiate the box
        Instantiate(boxPrefab, spawnPos, Quaternion.identity);
    }
}

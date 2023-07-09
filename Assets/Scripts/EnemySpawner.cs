using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class EnemySpawner : MonoBehaviour
{

    public GameObject theEnemy; // Enemy prefab to spawn
    public float minSpawnTime = 1f; // Minimum time between enemy spawns
    public float maxSpawnTime = 5f; // Maximum time between enemy spawns

    private void Start()
    {
        StartCoroutine(SpawnEnemies()); // Start spawning enemies using a coroutine
    }

    private IEnumerator SpawnEnemies()
    {
        while (true) // Keep spawning enemies indefinitely
        {
            float spawnTime = Random.Range(minSpawnTime, maxSpawnTime); // Generate a random spawn time within the specified range
            yield return new WaitForSeconds(spawnTime); // Wait for the spawn time

            Instantiate(theEnemy, transform.position, Quaternion.identity);  // Instantiate an enemy at the spawner's position with no rotation
        }
    }

}

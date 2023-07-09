using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coinPrefab;
    private float minSpawnDelay = 1f;  // Minimum spawn delay (in seconds)
    private float maxSpawnDelay = 5f;  // Maximum spawn delay (in seconds)
    private float nextSpawnTime;  // Next spawn time

    private void Start()
    {
        nextSpawnTime = Time.time + GetRandomSpawnDelay(); // Set the initial next spawn time
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime) // If the current time has exceeded the next spawn time
        {
            SpawnNewCoin(); // Spawn a new coin
            nextSpawnTime = Time.time + GetRandomSpawnDelay(); // Calculate the next spawn time

        }
    }

    private float GetRandomSpawnDelay()
    {
        return Random.Range(minSpawnDelay, maxSpawnDelay); // Generate a random spawn delay between the min and max values
    }

    private void SpawnNewCoin()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)); // Generate a random position within the specified range
        Instantiate(coinPrefab, randomPosition, Quaternion.identity); // Instantiate a coin at the random position with no rotation
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // If the trigger is triggered by an object with the "Player" tag

        {
            SpawnNewCoin(); // Spawn a new coin
        }
        
    }
   

}

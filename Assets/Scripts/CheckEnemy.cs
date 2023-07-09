using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEnemy : MonoBehaviour
{
    //Finish the game if there are no enemies left
    public PlayerManager playerManager; // Reference to the player manager script


    private void Start()
    {
        InvokeRepeating("CheckForEnemies", 0f, 1f); // Invoke the CheckForEnemies method repeatedly every 1 second
    }

    private void CheckForEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy"); // Find all game objects with the "Enemy" tag
        if (enemies.Length == 0) // If there are no enemies
        {
            playerManager.Death(); // Call the Death() method in the player manager script to finish the game
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private bool PlayerAlive = true; // Flag to track the player's alive state

    public GameObject gameovermenu; // Reference to the game over menu

    public void Death()
    {
        // Handle player's death

        if (PlayerAlive) // If the player is still alive
        {
            PlayerAlive = false; // Update the player's alive state to false

            gameovermenu.SetActive(true);  // Activate the game over menu
            Time.timeScale = 0f; // Pause the game by setting the time scale to zero


        }
    }

    

}

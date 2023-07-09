using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
   

    public bool gamepos = false;  // Flag to track the game's pause state
    public void PauseGame()
        //Pause Game And Resume
    {
        if(gamepos == true) // If the game is already paused
        {
            Time.timeScale = 1f; // Set the time scale back to normal (1)
            gamepos = false;    // Update the game's pause state to false

        }
        else // If the game is not paused
        {
            Time.timeScale = 0f; // Set the time scale to zero, effectively pausing the game
            gamepos = true;    // Update the game's pause state to true

        }
         
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float curringtime = 0f; // Variable to hold the current time
    float startingTime = 90f; // Starting time

    [SerializeField]
    Text cdt;       // Text object on the canvas to display the time

    public PlayerManager playerManager;  // Reference to the player manager script


    private bool timerIsRunning = true; // Flag to indicate whether the timer is running


    private void Start()
    {
        curringtime = startingTime; // Assign the starting time to the current time
    }

    private void Update()
    {
        
        if (timerIsRunning)  // If the timer is running
        {
            curringtime -= 1 * Time.deltaTime; // Decrease the current time
            cdt.text = curringtime.ToString("0"); // Write the time to the Text object on the canvas


            if (curringtime <= 0) // If the current time reaches zero or less
            {
                curringtime = 0; // Reset the current time to zero
                playerManager.Death(); // Call the Death() method in the player manager script
                timerIsRunning = false; // Stop the timer
            }
        }
        
    }
}

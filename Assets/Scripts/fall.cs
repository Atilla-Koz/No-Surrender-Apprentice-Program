using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public PlayerManager playerManager;  // Reference to the player manager script

    private void OnTriggerEnter(Collider other) // Check if the collider belongs to an object with the "Player" tag
    {
        //Ýf the Player Falls
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerManager>().Death(); // Call the Death() method in the player manager script
        }
    }
}

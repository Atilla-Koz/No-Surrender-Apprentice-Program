using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationC : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;


    //Start Called Before the first Frame Uptadete
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    //Update Ýs Called Per Frame 
    private void Update()
    {
        agent.destination = player.position;
    }
    
}

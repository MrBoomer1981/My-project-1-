using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Goto : MonoBehaviour
{
    public Transform goal;

    NavMeshAgent agent;
    
    void Start()
    {
        agent =  GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehavior : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform[] targets; 
    public Transform targetAux; 

    int index = 0; 

    void Start()
    {
       
        targetAux = targets[index];
        agent.destination = targetAux.position;
    }

    void Update()
    {
        
        if (agent.remainingDistance < 1)
        {
           
            index = index + 1;

           
            if (index >= targets.Length)
            {
                index = 0;
            }

            
            targetAux = targets[index];
            agent.destination = targetAux.position;
        }
    }
}
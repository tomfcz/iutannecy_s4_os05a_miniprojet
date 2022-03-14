using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentControlleur : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform positionprof;
    public Transform target1;
    public Transform target2;
    public Transform joueur3;
    private int targetqui=1;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        positionprof = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetqui == 1)
        {
            agent.destination = target1.position;
            if(positionprof.position==target1.position)
            {
                agent.SetDestination(target2.position);
            }
        }
        if (targetqui == 2)
        {
            agent.destination = target2.position;
            if (positionprof.position == target2.position)
            {
                agent.SetDestination(target1.position);
            }
        }

    }
}

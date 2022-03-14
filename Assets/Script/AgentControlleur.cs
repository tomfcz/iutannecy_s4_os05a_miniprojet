using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentControlleur : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform positionprof;
    public Transform[] checkpoints;
    public Transform joueur3;
    int i=0;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        positionprof = GetComponent<Transform>();
        agent.SetDestination(checkpoints[0].position);

    }

    // Update is called once per frame
    void Update()
    {
        if (i >= checkpoints.Length) return;
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            Debug.Log("YOU REACHED IT");
            Debug.Log(i);
            if (++i < checkpoints.Length)
            {
                this.agent.SetDestination(checkpoints[i].position);
            }
            else
            {
                agent.ResetPath();
                i = 0;
                this.agent.SetDestination(checkpoints[i].position);
            }
        }

    }
}

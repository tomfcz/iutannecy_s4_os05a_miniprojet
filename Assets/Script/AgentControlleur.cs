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
    public IASensor detection;
    GameObject pickup;
 
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {

        detection = GetComponent<IASensor>();
        agent = GetComponent<NavMeshAgent>();
        positionprof = GetComponent<Transform>();
        agent.SetDestination(checkpoints[0].position);
        pickup = GameObject.Find("Personnage");

    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<IASensor>().IsInSight(pickup))
        {
            Debug.Log("lol");
            if (i >= checkpoints.Length) return;
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
               
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
        else
        {
            this.agent.SetDestination(joueur3.position);
        }
            
        
    }
}

  

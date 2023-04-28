using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class DoritBehaviour : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent; // character controller
    public GameObject target;//game object have the location
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        /**
        float distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance < 3)
        {
            agent.enabled = false;//cancel the walking
            animator.SetInteger("Status", 1);//stand
        }
        if (Input.GetKeyDown(KeyCode.G)) //start walking
        {
            if (agent.enabled)
            {
                agent.SetDestination(target.transform.position);//find path to target
            }
            animator.SetInteger("Status", 0);//set animation walking


        }
        */

        float distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance < 3)
        {
            //agent.enabled = false;//cancel the walking
            animator.SetInteger("Status", 2);//talk
        }
        if (Input.GetKeyDown(KeyCode.Q)) //start walking
        {
            if (agent.enabled)
            {
                agent.SetDestination(target.transform.position);//find path to target
            }
            animator.SetInteger("Status", 1);//set animation walking


        }

    }
}

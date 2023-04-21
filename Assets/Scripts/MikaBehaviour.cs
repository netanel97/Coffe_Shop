using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MikaBehaviour : MonoBehaviour
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
        /*
        if (Input.GetKeyDown(KeyCode.X)){//phoneCall
            animator.SetInteger("Status", 0);
        }
        if (Input.GetKeyDown(KeyCode.Z))//Falling down
        {
            animator.SetInteger("Status", 1);
        }
        if (Input.GetKeyDown(KeyCode.C))//Stand Up
            //KeyCode is which key was pressed
        {
            animator.SetInteger("Status", 2);
        }

        if (Input.GetKeyDown(KeyCode.Q)) //start walking
        {
            agent.SetDestination(target.transform.position);
        }
        */

    }
}

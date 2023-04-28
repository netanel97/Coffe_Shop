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
    {   //first argument its the npc position,secound arg is position of the target
        float distance = Vector3.Distance(transform.position, target.transform.position);
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
        */  
        if(distance < 3)
        {
            Vector3 temp3 = new Vector3(target.transform.position.x, 9, target.transform.position.z);

            agent.nextPosition = temp3;
            Vector3 temp1 = new Vector3(target.transform.position.x, 17, target.transform.position.z);
            Vector3 temp2 = new Vector3(target.transform.position.x,0,target.transform.position.z);
            //agent.enabled = false;//cancel the walking
            //animator.SetInteger("Status", 4);//talking
            //swtich target pos
            if (target.transform.position.y > 10)
            {
                target.transform.position = temp2;
            }
            else
            {
                target.transform.position = temp1;
            }
            //set new dest
            agent.SetDestination(target.transform.position);//find path to target

        }
        if (Input.GetKeyDown(KeyCode.Q)) //start walking
        {
            if(agent.enabled){
                agent.SetDestination(target.transform.position);//find path to target
            }
            animator.SetInteger("Status", 3);//set animation walking


        }


    }
}

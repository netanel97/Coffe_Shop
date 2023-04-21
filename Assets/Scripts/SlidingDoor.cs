using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoorMotion : MonoBehaviour
{
    private AudioSource doorSound;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        doorSound = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
        animator.SetBool("OpenSlidingDoor", true);
        doorSound.Play();

    }
    public void OnTriggerExit(Collider other)
    {
        animator.SetBool("OpenSlidingDoor", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

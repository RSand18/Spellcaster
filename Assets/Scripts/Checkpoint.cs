using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    Animator checkpointAnim;
    AudioSource checkpointAudSrc;

    private bool isActivated = false;


    void Start()
    {
        checkpointAnim = GetComponent<Animator>();
        checkpointAudSrc = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isActivated = true;
            checkpointAnim.SetTrigger("CPActivate");
            checkpointAudSrc.Play();
        }
    }
}

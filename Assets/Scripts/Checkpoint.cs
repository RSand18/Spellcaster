using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    Animator checkpointAnim;
    private bool isActivated = false;

    private void UpdateAnimation()
    {
        if (isActivated)
        {

        }
    }

    void Start()
    {
        checkpointAnim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
       
    }

    public void SetIsActivated(bool value)
    {
        isActivated = value;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            checkpointAnim.SetTrigger("Activate");
            PlayerCharacter player = collision.GetComponent<PlayerCharacter>();
            player.SetCurrentCheckpoint(this);
            Debug.Log("Checkpoint");
        }
    }
}

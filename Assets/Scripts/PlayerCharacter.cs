using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    [SerializeField]
    private int lives = 3; //PascalCase or camelCase

    [SerializeField]
    private string name = "Mario";

    [SerializeField]
    private float jumpHeight = 5, speed = 5;

    private bool hasKey;

    [SerializeField]
    private bool isOnGround;

    private Rigidbody2D rigidBody2DInstance;
    private float horizontalInput;

	// Use this for initialization
	void Start ()
    {

        rigidBody2DInstance = GetComponent<Rigidbody2D>();

        //We have to initialize our rigidbody variable!
        rigidBody2DInstance.gravityScale = 5;

	}
	
	// Update is called once per frame
	void Update ()
    {
        //transform.Translate does NOT use physics, rigidbody does
        //transform.Translate(0, -0.01f, 0); 

        GetInput();
        Move();
	}
    private void GetInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
    }

    private void Move()
    {
        rigidBody2DInstance.velocity = new Vector2(horizontalInput, 0);
    }
}

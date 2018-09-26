using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    [SerializeField]
    private int lives = 3; //PAscalCase or camelCase

    [SerializeField]
    private string name = "Mario";


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		            
        Debug.Log("Hello.");
	}

    private void Move()
    {

    }
}

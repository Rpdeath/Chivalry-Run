using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePickAble : MonoBehaviour
{
    public Vector2 speed;

	private Vector2 movement;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		movement = new Vector2(
			speed.x * -1,
			speed.y * 0);

		GetComponent<Rigidbody2D>().velocity = movement;
		
		
	}
}

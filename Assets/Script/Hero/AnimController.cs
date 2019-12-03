using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {
	private Animator animator;
	private float velocity;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {


		int speedAnim = 0;

		if ( Input.GetAxis("Horizontal") > 0 ){
			GetComponent<SpriteRenderer>().flipX=false;
			speedAnim = 1;
		}
		if ( Input.GetAxis("Horizontal") < 0 ){
			GetComponent<SpriteRenderer>().flipX=true;
			speedAnim = 1;
		}

		

		animator.SetFloat("speed",speedAnim);
	}
}

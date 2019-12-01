using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHero : MonoBehaviour
{
	private Vector2 movement; 
	public Vector2 speed;
	private bool canJump;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
			float inputY = Input.GetAxis("Vertical");
			float inputX = Input.GetAxis("Horizontal");
			
			float movx = inputX*speed.x;
			
			if ( inputY <0 ){
				inputY = 0;
			}
			float movy = inputY*speed.y;
			
			movement = new Vector2(movx,movy);
			GetComponent<Rigidbody2D> ().velocity = movement;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHero : MonoBehaviour
{
	private Vector2 movement; 
	public Vector2 speedModifier;
	private Vector2 speed;
	private Vector3 pos;
	public float jumpVelocity = 5f;
	public float jumpCountDown = 5f;
	private float jumpCountDownTimer;
	private  bool isJumping = false;
	private  bool isFalling = false;
	public float maxJump = 3f;
	private float maxJumpTimer;
	
	
    // Start is called before the first frame update
    void Start()
    {
       Time.timeScale = 1;
	   jumpCountDownTimer = jumpCountDown;
	   maxJumpTimer = maxJump;
	   speed = speedModifier;
    }

    // Update is called once per frame
    void Update()
    {
			
			if ( isFalling ) {
				jumpCountDownTimer -= Time.deltaTime;
			
			}
			
			if ( isJumping ) {
				maxJumpTimer -= Time.deltaTime;
			
			}
			
			if ( GetComponent<Rigidbody2D>().velocity.y != 0 ) {
				speed.x = speedModifier.x/2;
			}else{
				speed.x = speedModifier.x;
			}
			
			if ( jumpCountDownTimer < 0 ){
					jumpCountDownTimer = jumpCountDown;
					
					isFalling = false;
					
			}
			
			if ( GetComponent<Rigidbody2D> ().velocity.y < 0 || maxJumpTimer < 0 ){
					maxJumpTimer = maxJump;
					isFalling = true;
					isJumping = false;
					
				}
				
			
			float inputY = Input.GetAxis("Vertical");
			float inputX = Input.GetAxis("Horizontal");
			float jump = 0f;
			
			if (inputY > 0 && isFalling == false ){
					jump = jumpVelocity;
					isJumping = true;
					
			}
			
			movement = new Vector2(inputX*speed.x,jump);
			GetComponent<Rigidbody2D> ().velocity = movement;
    }
}

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
    private bool isAttacking = false;
    public float maxJump = 3f;
	private float maxJumpTimer;
    public int massOnFalling=25;
    public int massOnJumping = 10;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
       Time.timeScale = 1;
	   jumpCountDownTimer = jumpCountDown;
	   maxJumpTimer = maxJump;
	   speed = speedModifier;
       animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
			
			if ( isFalling ) {
				jumpCountDownTimer -= Time.deltaTime;
				 GetComponent<Rigidbody2D>().mass=5000;
				 GetComponent<Rigidbody2D>().gravityScale = 25;
			
			}
			
			if ( isJumping ) {
				maxJumpTimer -= Time.deltaTime;
				 GetComponent<Rigidbody2D>().mass = 500;
				 GetComponent<Rigidbody2D>().gravityScale = 10;
			
			}

            if (GetComponent<Rigidbody2D>().velocity.y == 0 )
            {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            GetComponent<Rigidbody2D>().mass = 10;
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
        // animator.setJumping(isFalling || isJumping);
        // animator.setAttacking(isAttacking);
			
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

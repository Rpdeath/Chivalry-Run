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
    public int massOnFalling=25;
    public int massOnJumping = 10;
	public int gravityOnFalling=10;
    public int gravityOnJumping = 10;
	public int nbShoot = 0;
	public int maxShoot = 2;
	private bool isShooting = false;
	public float ShootCountDown = 1f;
	private float ShootCountDownTimer;
	

    // Start is called before the first frame update
    void Start()
    {
       Time.timeScale = 1;
	   jumpCountDownTimer = jumpCountDown;
	   maxJumpTimer = maxJump;
	   speed = speedModifier;
    }

	void Shoot(){
		float sizex = gameObject.GetComponent<BoxCollider2D>().bounds.size.x;
		float sizey = gameObject.GetComponent<BoxCollider2D>().bounds.size.x;
		Instantiate(Resources.Load("FireBall"), new Vector3(transform.position.x+(sizex/2), transform.position.y , 0), Quaternion.identity);
		ShootCountDownTimer = ShootCountDown;
		isShooting = true;
	}

    // Update is called once per frame
    void Update()
    {
			if (nbShoot > maxShoot){
				nbShoot = maxShoot;
			}

			if ( isFalling ) {
				jumpCountDownTimer -= Time.deltaTime;
				 GetComponent<Rigidbody2D>().mass=massOnFalling;
				 GetComponent<Rigidbody2D>().gravityScale = gravityOnFalling;
			
			}

			if (isShooting){
				ShootCountDownTimer -= Time.deltaTime;
			}
			
			if ( isJumping ) {
				maxJumpTimer -= Time.deltaTime;
				 GetComponent<Rigidbody2D>().mass = massOnJumping;
				 GetComponent<Rigidbody2D>().gravityScale = gravityOnJumping;
			
			}


			

            if (GetComponent<Rigidbody2D>().velocity.y == 0 )
            {
            GetComponent<Rigidbody2D>().gravityScale = 10;
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

			if ( ShootCountDownTimer < 0 ){
					ShootCountDownTimer = ShootCountDown;
					isShooting = false;
			}
			
			if ( GetComponent<Rigidbody2D> ().velocity.y < 0 || maxJumpTimer < 0 ){
					maxJumpTimer = maxJump;
					isFalling = true;
					isJumping = false;
					
				}
			
			float inputY = Input.GetAxis("Vertical");

			if (Input.touchCount > 0) { 
				Touch p = Input.GetTouch(0);
				Debug.Log(p); 
				Debug.Log(p.position);
			} 
 
	
			

			float inputX = Input.GetAxis("Horizontal");
			float jump = 0f;
			
			if (inputY > 0 && isFalling == false ){
					jump = jumpVelocity;
					isJumping = true;
					
			}
			
			if (inputY < 0 && isShooting == false){
				if (nbShoot > 0){
				nbShoot -=1;
				Shoot();
				}
			}
			movement = new Vector2(inputX*speed.x,jump);
			GetComponent<Rigidbody2D> ().velocity = movement;
    }
}

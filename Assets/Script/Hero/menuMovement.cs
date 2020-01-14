using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuMovement : MonoBehaviour
{
	private Vector2 movement; 
	public Vector2 speedModifier;
	private Vector2 speed;

    private Vector3 coinBasGauche;
	private Vector3 coinBasDroit;
	private Vector3 coinHautGauche;
	private Vector3 coinHautDroit;
    private Vector3 size;





    // Start is called before the first frame update
    void Start()
    {
	    speed = speedModifier;
        coinBasGauche = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		coinBasDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));
		coinHautGauche = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, 0));
		coinHautDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));
		size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
		size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > coinBasDroit.x/2 - (size.x)){
			gameObject.transform.position = new Vector3(
											coinBasDroit.x/2 - (size.x),
											transform.position.y ,
											transform.position.z);
            speed.x = 0;	
		}
		movement = new Vector2(speed.x,0);
		GetComponent<Rigidbody2D> ().velocity = movement;
    }
}

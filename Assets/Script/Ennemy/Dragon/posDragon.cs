using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posDragon : MonoBehaviour {

	public Vector2 movement;
	private Vector3 coinBasGauche;
	private Vector3 coinBasDroit;
	private Vector3 coinHautGauche;
	private Vector3 coinHautDroit;
	private Vector3 size;

	void Start()
	{
		// Conversion du monde de la caméra au monde du pixel pour chaque coin
		coinBasGauche = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		coinBasDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));
		coinHautGauche = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, 0));
		coinHautDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));
		
		

		}
	
	// Update is called once per frame
	void Update () {
		movement = GetComponent<Rigidbody2D>().velocity;

		size.x = gameObject.GetComponent<BoxCollider2D>().bounds.size.x;
		size.y = gameObject.GetComponent<BoxCollider2D>().bounds.size.x;
		
		// Blocage en haut
		if (transform.position.y > coinHautDroit.y + (size.y /2)){
			Destroy(gameObject);
		}
		// Blocage en bas
		if (transform.position.y < coinBasDroit.y - (size.y /2)){
			Destroy(gameObject);
		}

		

		// Blocage a gauche
		if (transform.position.x < coinBasGauche.x - (size.x /2)){
			Destroy(gameObject);
			GameObject.FindGameObjectsWithTag("CoinText")[0].GetComponent<Coin>().currentscore+=1;
			GameObject.FindGameObjectsWithTag("Data")[0].GetComponent<Data_Coin>().currentscore+=1;
		}
	}
}

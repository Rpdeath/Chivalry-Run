using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class posHero : MonoBehaviour
{
  public Vector2 movement;
	private Vector3 coinBasGauche;
	private Vector3 coinBasDroit;
	private Vector3 coinHautGauche;
	private Vector3 coinHautDroit;
	private Vector3 size;
	public int life = 5;

	void Start()
	{
		// Conversion du monde de la caméra au monde du pixel pour chaque coin
		coinBasGauche = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		coinBasDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));
		coinHautGauche = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, 0));
		coinHautDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));
		size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
		size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
		gameObject.transform.position = new Vector3(
											coinBasDroit.x/2 - (size.x),
											transform.position.y ,
											transform.position.z);
		}
	
	// Update is called once per frame
	void Update () {
		movement = GetComponent<Rigidbody2D>().velocity;

		size.x = gameObject.GetComponent<BoxCollider2D>().bounds.size.x;
		size.y = gameObject.GetComponent<BoxCollider2D>().bounds.size.y;
		
		// Blocage en haut
		if (transform.position.y > coinHautDroit.y - (size.y /2)){
			gameObject.transform.position = new Vector3(
											transform.position.x,
											coinHautDroit.y - (size.y /2) ,
											transform.position.z);
		}
		// Blocage en bas
		if (transform.position.y < coinBasDroit.y + (size.y /2)){
			gameObject.transform.position = new Vector3(
											transform.position.x,
											coinBasDroit.y + (size.y /2) ,
											transform.position.z);
		}

		// Blocage a droite
		if (transform.position.x > coinBasDroit.x - (size.x /2)){
			gameObject.transform.position = new Vector3(
											coinBasDroit.x - (size.x /2),
											transform.position.y,
											transform.position.z);
		}

		// Blocage a gauche
		if (transform.position.x < coinBasGauche.x - (size.x /2)){
			this.life--;
			gameObject.transform.position = new Vector3(
											0,
											transform.position.y,
											transform.position.z);
		}

		if (life==0){
			GameObject.FindGameObjectsWithTag("life1")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life2")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life3")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life4")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life5")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			SceneManager.LoadScene("EndGame");
		}
		if (life>=1){
			GameObject.FindGameObjectsWithTag("life1")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life2")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life3")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life4")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life5")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
		}
		if (life>=2){
			GameObject.FindGameObjectsWithTag("life1")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life2")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life3")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life4")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life5")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
		}
		if (life>=3){
			GameObject.FindGameObjectsWithTag("life1")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life2")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life3")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life4")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
			GameObject.FindGameObjectsWithTag("life5")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
		}
		if (life>=4){
			GameObject.FindGameObjectsWithTag("life1")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life2")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life3")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life4")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life5")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,0);
		}
		if (life>=5){
			GameObject.FindGameObjectsWithTag("life1")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life2")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life3")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life4")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
			GameObject.FindGameObjectsWithTag("life5")[0].GetComponent<SpriteRenderer>().color=new Color(255,255,255,255);
		}


		

	 
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorDragon : MonoBehaviour {

	private Vector3 coinHautDroit;
	private Vector3 coinBasDroit;
	public int nbSpawn;
	private Vector2 size;
	public GameObject grass;

	// Use this for initialization

	void Start () {
		coinHautDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));
		coinBasDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
		size.x = grass.GetComponent<BoxCollider2D>().bounds.size.x;
		size.y = grass.GetComponent<BoxCollider2D>().bounds.size.y;

		Texture2D texture = new Texture2D(0,0);
		texture.LoadImage(Resources.Load("dragon.png"));

		float y = (grass.transform.position.y + (size.x/2));

		if(GameObject.FindGameObjectsWithTag("Dragon").Length < 2 && Random.Range(0,100) == 50 ) {
			Instantiate(Resources.Load("Ennemy_Dragon"), new Vector3(coinHautDroit.x+Random.Range(0,10), y , 0), Quaternion.identity);
		}
	}
}

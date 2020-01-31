using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorDragon : MonoBehaviour {

	private Vector3 coinHautDroit;
	private Vector3 coinBasDroit;
	public int nbSpawn;
	private Vector2 size;
	public int random=500;
	private int givedLife = 0;
	private int givedLife20 = 0;
	// Use this for initialization

	void Start () {
		coinHautDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));
		coinBasDroit = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.FindGameObjectsWithTag("Dragon").Length < nbSpawn && Random.Range(0,random) == random/2 ) {
			Instantiate(Resources.Load("Ennemy_Dragon"), new Vector3(coinHautDroit.x+Random.Range(0,10), coinHautDroit.y/4 , 0), Quaternion.identity);
		}	
		if (GameObject.FindGameObjectsWithTag("Data")[0].GetComponent<Data_Coin>().currentscore>0){
		if (GameObject.FindGameObjectsWithTag("Data")[0].GetComponent<Data_Coin>().currentscore%20==0 && nbSpawn<4){
			nbSpawn+=1;
			givedLife20+=1;
			Instantiate(Resources.Load("Tookable_Coin"), new Vector3(coinHautDroit.x+Random.Range(0,10), coinHautDroit.y/Random.Range(6,10) , 0), Quaternion.identity);
			GameObject.FindGameObjectsWithTag("Data")[0].GetComponent<Data_Coin>().currentscore+=1;
		}
		}
		if (GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<posHero>().life < 3 && GameObject.FindGameObjectsWithTag("Data")[0].GetComponent<Data_Coin>().currentscore<20){
			if (GameObject.FindGameObjectsWithTag("CoinLife").Length < 1 && givedLife<2){
				givedLife+=1;
				Instantiate(Resources.Load("Tookable_Coin"), new Vector3(coinHautDroit.x+Random.Range(0,10), coinHautDroit.y/Random.Range(6,10) , 0), Quaternion.identity);
			}
		}

	}
}
	
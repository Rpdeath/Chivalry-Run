using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posTookAble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player"){
            GameObject.FindGameObjectsWithTag("CoinText")[0].GetComponent<Coin>().currentscore+=5;
			GameObject.FindGameObjectsWithTag("Data")[0].GetComponent<Data_Coin>().currentscore+=5;
            GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<posHero>().life+=1;
            GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<moveHero>().nbShoot+=1;
            Destroy(gameObject);
        }else{
        }
    }
}

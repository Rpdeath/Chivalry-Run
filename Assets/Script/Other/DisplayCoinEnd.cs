using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayCoinEnd : MonoBehaviour
{
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>(); 
        txt.text=GameObject.FindGameObjectsWithTag("Data")[0].GetComponent<Data_Coin>().currentscore.ToString();
        Destroy(GameObject.FindGameObjectsWithTag("Data")[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

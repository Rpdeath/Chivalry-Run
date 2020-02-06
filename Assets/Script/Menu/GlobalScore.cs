using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>(); 
        txt.text=PlayerPrefs.GetInt("GlobalCoin").ToString();
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}

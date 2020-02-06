using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preferences : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("GlobalCoin")){
        }else{
            PlayerPrefs.SetInt("GlobalCoin",0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

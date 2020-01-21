using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data_Coin : MonoBehaviour
{
    public int currentscore=0;
 
     // Use this for initialization
     void Start () {
     }
     
     // Update is called once per frame
     void Update () {
        if (currentscore<0) {
            currentscore = 0;
        }
     }

}

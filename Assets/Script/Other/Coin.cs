    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class Coin : MonoBehaviour
    {
        Text txt;
        public int currentscore=0;
    
        // Use this for initialization
        void Start () {
            txt = gameObject.GetComponent<Text>(); 
            txt.text=  currentscore.ToString();
        }
        
        // Update is called once per frame
        void Update () {
            if (currentscore<0) {
            currentscore = 0;
        }
            txt.text= currentscore.ToString();  
        }

    }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using	UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     Invoke("gotomenu",3.0f);	
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void gotomenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

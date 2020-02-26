using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using	UnityEngine.SceneManagement;

public class ClickButtonHelp : MonoBehaviour
{
   public void onClick(){	
		SceneManager.LoadScene("Help");
	}
}

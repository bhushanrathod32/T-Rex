using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	
	public void Quit () 
	{
		Debug.Log("QUIT");
		Application.Quit();
	}
	
	public void Restart () 
	{
		Debug.Log("RESTART");
		SceneManager.LoadScene(1);
	}
}

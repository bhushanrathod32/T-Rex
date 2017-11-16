using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour {

	public void startGame () 
	{
		Debug.Log("START");
		SceneManager.LoadScene(1);
	}
}

using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour {

	public Text scoreFinal;

	// Use this for initialization
	void Start () 
	{
		scoreFinal.text = PlayerPrefs.GetInt("Score").ToString();
	}
}

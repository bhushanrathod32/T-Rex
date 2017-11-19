using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

	public float playerScore = 0;
	public Text scoreText;
	
	
	// Update is called once per frame
	void Update () {
		playerScore += Time.deltaTime;
		scoreText.text = (playerScore * 10).ToString("0");
	}
	
	void OnDisable()
	{
		PlayerPrefs.SetInt("Score", (int)(playerScore * 10));
	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour {

	float speed = -6f;
	Rigidbody2D myBody;

	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		myBody.velocity = new Vector2 (speed, 0);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			SceneManager.LoadScene(2);
			return;
		}

	}

}

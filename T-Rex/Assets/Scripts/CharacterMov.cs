using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMov : MonoBehaviour {

	[SerializeField] float jumpForce = 4f;
	float forwardForce = 0f;

	Rigidbody2D myBody;
	bool canJump;


	// Use this for initialization
	void Start () 
	{
		myBody = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () 
	{
		bool canJump = Input.GetKey(KeyCode.Space);
		if (canJump) 
		{
			Jump();
		}
	}

	public void Jump()
	{
		if (canJump) 
		{
			canJump = false;

			forwardForce = 0f;

			myBody.velocity = new Vector2 (forwardForce, jumpForce);

		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		canJump = true;
	}
}

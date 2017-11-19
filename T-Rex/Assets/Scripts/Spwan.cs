using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwan : MonoBehaviour {

	public GameObject[] enemy;
	//float randY;
	Vector2 wheretoSpawn;
	public float spwanRate = 2f;
	public float spwanMin = 1.5f;
	public float spwanMax = 2f;
	float nextSpawn = 0.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		if(Time.time > nextSpawn)
		{
			//nextSpawn = Time.time + spwanRate;
			nextSpawn = Time.time + Random.Range (spwanMin, spwanMax);
			//randY = Random.Range (-1.6f, -3.3f);
			wheretoSpawn = new Vector2(transform.position.x, transform.position.y);
			Instantiate(enemy[Random.Range(0, enemy.GetLength(0))], wheretoSpawn, Quaternion.identity);
		}

	}
}

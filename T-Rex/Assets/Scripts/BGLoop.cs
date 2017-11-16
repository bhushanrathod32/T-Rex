using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGLoop : MonoBehaviour {
	
	public float speed = 0.1f;
	
	private Material mat;
	private Vector2 offset = Vector2.zero;

	// Use this for initialization
	void Start () 
	{
		
		mat = GetComponent<Renderer>().material;
		offset = mat.GetTextureOffset("_MainTex");
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		offset.x = offset.x + speed * Time.deltaTime;
		mat.SetTextureOffset("_MainTex", offset);
		
	}
}

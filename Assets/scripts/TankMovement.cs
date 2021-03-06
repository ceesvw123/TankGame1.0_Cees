﻿using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {
	public float rotationSpeed = 0.5f;
	public float moveSpeed = 0.35f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) 
		{
			transform.Translate(Vector3.forward * moveSpeed);

		}
		if (Input.GetKey(KeyCode.S)) 
		{
			transform.Translate(-Vector3.forward * moveSpeed);
			
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			transform.Rotate(-Vector3.up * rotationSpeed);
			
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			transform.Rotate(Vector3.up * rotationSpeed);
			
		}
	}
}

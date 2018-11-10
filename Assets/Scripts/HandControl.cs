using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControl : MonoBehaviour {

	public Rigidbody2D bodyRigidBody;
	public string whichHand = "Left";
	public float radius = 1.0f;

	public Rigidbody2D rigidBody;

	Vector3 origin;

	// Use this for initialization
	void Start () {
		// use our starting point as the center point for our range of motion
		Debug.Log(origin);
	}
	
	// Update is called once per frame
	void Update () {
		origin = bodyRigidBody.position;

		float horizontal = Input.GetAxis(whichHand + "Horizontal");
		float vertical = Input.GetAxis(whichHand + "Vertical");

		rigidBody.MovePosition(origin + new Vector3(horizontal * radius, vertical * radius, 0));
		// rigidBody.position = origin + new Vector3(horizontal * radius, vertical * radius, 0);
	}

}

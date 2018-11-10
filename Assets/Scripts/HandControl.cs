using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControl : MonoBehaviour {

	public string whichHand = "Left";
	public float radius = 1.0f;

	public RelativeJoint2D arm;
	public Rigidbody2D shoulder;

    Camera cam;

    void Start()
    {
    	cam = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
		Vector3 shoulderPos = cam.WorldToScreenPoint(shoulder.position);
		Vector2 mouse = new Vector2(Input.mousePosition.x - shoulderPos.x, Input.mousePosition.y - shoulderPos.y);
		arm.linearOffset = -3 * mouse / mouse.magnitude;
		// arm.angularOffset = 
		// rigidBody.MovePosition(origin + new Vector3(horizontal * radius, vertical * radius, 0));
		// rigidBody.position = origin + new Vector3(horizontal * radius, vertical * radius, 0);
	}

}

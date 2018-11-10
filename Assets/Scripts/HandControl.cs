using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControl : MonoBehaviour {

	public Rigidbody2D bodyRigidBody;
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

		// float horizontal = Input.GetAxis(whichHand + "Horizontal");
		// float vertical = Input.GetAxis(whichHand + "Vertical");

		arm.linearOffset = -3 * mouse / mouse.magnitude;
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour {

	public HingeJoint2D hookAttachJoint;
	public string which = "Left";

	private bool hooked = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Release the bumper to let go of the object
		if (hooked && Input.GetButton(which + "Bumper")) {
			hookAttachJoint.enabled = false;
			hooked = false;
		}
	}

	// Hold down the bumper to attach to an object on hit
	void OnCollisionEnter2D(Collision2D collision) {
		if (hooked || Input.GetButton(which + "Bumper")) { return; }
		hooked = true;
		Rigidbody2D collidingRb = collision.gameObject.GetComponent<Rigidbody2D>();
		hookAttachJoint.connectedBody = collidingRb;
		hookAttachJoint.enabled = true;
	}
}

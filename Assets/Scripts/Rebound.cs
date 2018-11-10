using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionExit2D(Collision2D collision) {
		// the velocity of the object hitting us, relatively; in this case absolute since the rebound box
		Vector3 relativeVelocity = collision.relativeVelocity;
		
	}
}

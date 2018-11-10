using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(Input.GetAxis("LeftHorizontal") +", " + Input.GetAxis("LeftVertical") + "    " + Input.GetAxis("RightHorizontal") +", " + Input.GetAxis("RightVertical"));
		// Debug.Log(Input.GetAxis("LeftTrigger") +", " + Input.GetAxis("RightTrigger")); // note from Morgan - looks like these chill at 0 until the triggers are pressed, and then their baseline is -1. Weird.
		// Debug.Log(Input.GetButton("LeftBumper") + ", " + Input.GetButton("RightBumper"));
	}
}

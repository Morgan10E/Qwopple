﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPosition = player.transform.position;
		transform.position = new Vector3(playerPosition.x, playerPosition.y, transform.position.z);
	}
}

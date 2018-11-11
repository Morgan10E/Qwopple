using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCounter : MonoBehaviour {

	public GameObject player;
	private float playerStartingPosition;
	private Text distanceCounter;

	// Use this for initialization
	void Start () {
		playerStartingPosition = player.transform.position.x;
		distanceCounter = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		distanceCounter.text = (player.transform.position.x - playerStartingPosition).ToString("0.##");
	}
}

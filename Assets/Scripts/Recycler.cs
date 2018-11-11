using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycler : MonoBehaviour {

	public Spawner spawner;
	public GameObject player;
	public Rigidbody2D recyclerRigidBody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		recyclerRigidBody.MovePosition(player.transform.position);
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Debris") {
			// give the object to the spawner to reuse

			// for now we'll just destroy it so it doesn't hang around forever xp
			Destroy(other.gameObject);
		}
	}
}

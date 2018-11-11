using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject player;
	public GameObject[] debrisPrefabs;
	// public int defaultCacheSize = 64;

	public float spawnDistanceFromPlayer = 100f;
	public float verticalSpawnRange = 50f;
	public float spawnRangeHeight = 20f;
	public float minScale = 0.2f;
	public float maxScale = 3f;
	public float minSpeed = 1f;
	public float maxSpeed = 5f;
	public float maxAngularSpeed = 1f;

	public float timeBetweenSpawns = 0.5f;
	private float nextSpawn;

	// private List<GameObject> debrisCache;

	// Use this for initialization
	void Start () {
		// debrisCache = new List<GameObject>(64);

		// for (int i = 0; i < defaultCacheSize; i++) {
		// 	GameObject debris = Instantiate(debrisPrefabs[Random.Range(0, debrisPrefabs.Length)]);

		// 	debrisCache[i] = debris;
		// }
		nextSpawn = Time.time + timeBetweenSpawns;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn) {
			GameObject debris = Instantiate(debrisPrefabs[Random.Range(0, debrisPrefabs.Length)]);
			// debris.transform.parent = transform;
			float scale = Random.Range(minScale, maxScale);
			float speed = Random.Range(minSpeed, maxSpeed);
			debris.transform.localScale = new Vector3(scale, scale, 1);
			
			Rigidbody2D rb = debris.GetComponent<Rigidbody2D>();
			Vector3 spawnPosition = new Vector3(player.transform.position.x + spawnDistanceFromPlayer, player.transform.position.y + Random.Range(-verticalSpawnRange, verticalSpawnRange), 0);
			rb.position = spawnPosition;
			rb.velocity = new Vector3(-speed, 0, 0);
			rb.angularVelocity = Random.Range(-maxAngularSpeed, maxAngularSpeed);

			nextSpawn = Time.time + timeBetweenSpawns;

			minSpeed += 0.2f;
			maxSpeed += 0.2f;
			maxAngularSpeed += 0.02f;
			timeBetweenSpawns = Mathf.Max(0.15f, timeBetweenSpawns - 0.01f);
		}
	}
}

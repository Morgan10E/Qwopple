using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

	public Dictionary<Vector2, Transform> coordinates;

	// Use this for initialization
	void Start () {
		coordinates = new Dictionary<Vector2, Transform>();
	}

	public bool TilePlaced(Vector2 location) {
		return coordinates.ContainsKey(location);
	}

	public Transform PlacedTile(Vector2 location) {
		return coordinates[location];
	}

	public void PlaceTile(Transform tile) {
		coordinates[tile.position] = tile;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiling : MonoBehaviour {

	public float offset = 2f;

	public bool hasNorthTile;
	public bool hasEastTile;
	public bool hasSouthTile;
	public bool hasWestTile;

	private Vector3 spriteSize;
	private Camera mainCam;

	public TileManager tileManager;
	

	// Use this for initialization
	void Start () {
		mainCam = Camera.main;

		SpriteRenderer sr = GetComponent<SpriteRenderer>();
		spriteSize = sr.bounds.size;

		tileManager.PlaceTile(transform);
	}
	
	// Update is called once per frame
	void Update () {
		// if this piece is surrounded by tiles, or the camera isn't in our tile, we don't do anything
		if (hasNorthTile && hasEastTile && hasSouthTile && hasWestTile) return;
	
		if (!hasEastTile || !hasWestTile) {
			float camHorizontalExtend = mainCam.orthographicSize * Screen.width / Screen.height;
			if (!hasEastTile) {
				float rightEdgePosition = transform.position.x + spriteSize.x/2;
				if (mainCam.transform.position.x + camHorizontalExtend > rightEdgePosition - offset) {
					Transform newTile = PlaceTile(new Vector2(1,0));
					newTile.GetComponent<Tiling>().hasWestTile = true;
					hasEastTile = true;
				}
			}
			if (!hasWestTile) {
				float leftEdgePosition = transform.position.x - spriteSize.x/2;
				if (mainCam.transform.position.x - camHorizontalExtend < leftEdgePosition + offset) {
					Transform newTile = PlaceTile(new Vector2(-1,0));
					newTile.GetComponent<Tiling>().hasEastTile = true;
					hasWestTile = true;
				}
			}
		}

		if (!hasNorthTile || !hasSouthTile) {
			float camVerticalExtend = mainCam.orthographicSize * Screen.height/Screen.width;
			if (!hasNorthTile) {
				float topEdgePosition = transform.position.y + spriteSize.y/2;
				if (mainCam.transform.position.y + camVerticalExtend > topEdgePosition - offset) {
					Transform newTile = PlaceTile(new Vector2(0,1));
					newTile.GetComponent<Tiling>().hasSouthTile = true;
					hasNorthTile = true;
				}
			} 
			if (!hasSouthTile) {
				float bottomEdgePosition = transform.position.y - spriteSize.y/2;
				if (mainCam.transform.position.y - camVerticalExtend < bottomEdgePosition + offset) {
					Transform newTile = PlaceTile(new Vector2(0,-1));
					newTile.GetComponent<Tiling>().hasNorthTile = true;
					hasSouthTile = true;
				}
			}
		}
	}

	Transform PlaceTile(Vector2 relativePosition) {
		Vector3 newPosition = new Vector3(transform.position.x + relativePosition.x * spriteSize.x, transform.position.y + relativePosition.y * spriteSize.y, transform.position.z);

		Transform newTile;
		if (tileManager.TilePlaced(newPosition)) {
			Debug.Log("Duplicate! Getting preexisting tile");
			newTile = tileManager.PlacedTile(newPosition);
		} else {
			newTile = Instantiate(transform, newPosition, transform.rotation);
			// tileManager.PlaceTile(newTile);
		} 
		newTile.parent = transform.parent;

		return newTile;
	}
}

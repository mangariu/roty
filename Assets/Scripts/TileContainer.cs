﻿using UnityEngine;
using System.Collections;
using System;

public class TileContainer : MonoBehaviour {
	#region singleton
	private static TileContainer _instance;
	public static TileContainer Instance {
		get {
			if (!_instance) {
				_instance = GameObject.FindObjectOfType(typeof(TileContainer));
				if (!_instance) {
					GameObject container = new GameObject();
					container.name = "TileContainer";
					_instance = container.AddComponent(typeof(TileContainer));
				}
			}
			return _instance;
		}
	}
	#endregion
	public Tile[] tiles;
	public int size;
	// Use this for initialization
	void Start () {
		size = Math.Sqrt(tiles.Length);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Tile getTile(int x, int y) {
		return tiles[size * y + x];
	}

	public Tile getTile(Vector2 v) {
		return getTile(v.x, v.y);
	}
}

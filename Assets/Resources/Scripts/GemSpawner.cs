﻿using UnityEngine;
using System.Collections;

public class GemSpawner : MonoBehaviour {

	public GameObject[] prefabs;

	// Use this for initialization
	void Start () {

		// infinite coin spawning function, asynchronous
		StartCoroutine(SpawnGems());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator SpawnGems() {
		while (true) {

			// number of coins we could spawn vertically
			int gemsThisRow = Random.Range(1, 2);

			// instantiate all gems in this row separated by some random amount of space
			for (int i = 0; i < gemsThisRow; i++) {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);
			}

			// pause 1-9 seconds until the next gem spawns
			yield return new WaitForSeconds(Random.Range(3, 6));
		}
	}
}

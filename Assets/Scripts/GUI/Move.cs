﻿using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	float speed = 1.0f;
	
	void Update() {
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
	}
}

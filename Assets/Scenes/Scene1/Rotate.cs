﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float rotationSpeed = 1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, rotationSpeed, 0);
	}
}

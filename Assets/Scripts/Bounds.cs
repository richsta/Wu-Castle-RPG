﻿using UnityEngine;
using System.Collections;

public class Bounds : MonoBehaviour {

    private BoxCollider2D bounds;
    private CameraController theCamera;

	// Use this for initialization
	void Start () {
        bounds = GetComponent<BoxCollider2D>();
        theCamera = FindObjectOfType<CameraController>();
        theCamera.setBounds(bounds);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

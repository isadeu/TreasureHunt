﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour {


	// Use this for initialization
	void Start () {

		//rb = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnTriggerEnter (Collider c) {
		if (c.gameObject.tag == "Player") {
			print ("colliding with other");	
		}
	//	print ("oOOh");
		//SceneManager.LoadScene ("win");
	}
}

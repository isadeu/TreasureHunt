using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distancetwo : MonoBehaviour {

	public Transform player;
	public Text clueTextTwo;
	//public bool texton;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (player) {
			float dist = Vector3.Distance (player.position, transform.position);
			print ("distance to other: " + dist);
			if (dist >= 6f) {
				//print ("distance is too far 6");
				clueTextTwo.text = "You are too far from the tree";
			}
			if (dist < 6f) {
				clueTextTwo.text = " notjing ";
			}
		}
	}
}

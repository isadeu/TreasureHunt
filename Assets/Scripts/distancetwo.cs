using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distancetwo : MonoBehaviour {
	//this is the cube
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
			if (dist <= 3f) {
				//print ("distance is too far 6");
				clueTextTwo.text = "There's always food by the computer!";
			}
			if (dist > 3f) {
				clueTextTwo.text = " Cube";
			}
		}
	}
}

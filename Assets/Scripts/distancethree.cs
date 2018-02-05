using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distancethree : MonoBehaviour {

	public Transform player;
	public Text clueTextThree;
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
				clueTextThree.text = "You are so far from the computer!";
			}
			if (dist < 6f) {
				clueTextThree.text = " Nothing ";
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour {

	public Transform player;
	public Text clueText;
	//public bool texton;


	// Use this for initialization
	void Start () {
		//texton = false;
		//SetClueText ();	

	}
	
	// Update is called once per frame
	void Update () {
		if (player) {
			float dist = Vector3.Distance (player.position, transform.position);
			print ("distance to other: " + dist);
			if (dist >= 6f) {
				print ("distance is too far 6");
				clueText.text = "You are so far from the computer!";
				//texton = true;
			}
			if (dist < 6f) {
				clueText.text = " nothing ";
			
			}
			//} else {
			//	clueText.text = "option2";
				//texton = false;
	
		
		
		}
	}
	/*
	void SetClueText(){
		if (texton = true) {
			clueText.text = " h ";
			//clueText.text = "You are too far from the tree!";
		} 
		if (texton = false){
			clueText.text = " g ";
		}

	}*/

}

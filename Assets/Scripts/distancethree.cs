using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distancethree : MonoBehaviour {
	//this is the computer
	public Transform player;
	public Text clueTextThree;
	public bool insidecol;
	//public bool texton;


	// Use this for initialization
	void Start () {
		insidecol = false;

	}

	// Update is called once per frame
	void Update () {
		/*if (insidecol == true) {
			clueTextThree.text = "Maybe the food is by the lamp instead...";
		}

		if (insidecol == false) {
			clueTextThree.text = "Maybe the food is by the lamp instead...";

		}*/

		if (player) {
			float dist = Vector3.Distance (player.position, transform.position);
			print ("distance to other: " + dist);
			if (dist <= 6f) {
				//print ("distance is too far 6");
				clueTextThree.text = "Maybe the food is by the lamp instead...";
			}
			if (dist > 6f) {
				clueTextThree.text = " Computer";
			}
		}

	}
	/*void OnTriggerStay(Collider c){
		if (c.gameObject.tag == "Player") {
			insidecol = true;
			
		} else {
			insidecol =false;
		}
	}

	void OnTriggerExit(Collider c){
		if (c.gameObject.tag == "Player") {
			insidecol = false;
		}
	}*/
	

		
			//print ("inside the collider");
			
		//}
	
	}


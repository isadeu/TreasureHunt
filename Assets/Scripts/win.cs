using System.Collections;
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
	void OnTriggerStay (Collider c) {
		if (c.gameObject.tag == "Player"){
			print ("inside the collider");
			if (Input.GetKey(KeyCode.Space)) {
				print ("detected the space");
				print ("colliding with other");	
				SceneManager.LoadScene ("win");
			}
		}
	//	print ("oOOh");
		//SceneManager.LoadScene ("win");
	}
}

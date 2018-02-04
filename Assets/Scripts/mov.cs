using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour {

	public float speed;
	void Start () { 
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			Vector3 targetTransform = Vector3.forward;
			transform.position += targetTransform;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			Vector3 targetTransform = Vector3.right;
			transform.position += targetTransform;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			Vector3 targetTransform = Vector3.left;
			transform.position += targetTransform;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			Vector3 targetTransform = Vector3.back;
			transform.position += targetTransform;
		}
		
	}
}
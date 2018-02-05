using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {


	private Vector3 rotateval;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A)) {
			rotateval = new Vector3 (0, 90,0);
			transform.eulerAngles = transform.eulerAngles - rotateval;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			rotateval = new Vector3 (0,-90,0);
			transform.eulerAngles = transform.eulerAngles - rotateval;
		}
		
	}
}

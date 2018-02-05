using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {


	public GameObject player;
	private Vector3 rotateval;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetKeyDown (KeyCode.A)) {
			rotateval = new Vector3 (0, 90,0);
			transform.eulerAngles = transform.eulerAngles - rotateval;
			player.transform.Rotate (new Vector3 (0,-90,0));
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			//rotateval = new Vector3 (0,-90,0);
			//transform.eulerAngles = transform.eulerAngles - rotateval;

			player.transform.Rotate(0,90,0);
			//player.transform.Rotate (new Vector3 (0,-90,0));
		}


		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;

		transform.Rotate(0, x, 0);
	*/	
	}
}

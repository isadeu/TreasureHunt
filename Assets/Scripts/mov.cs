using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour {

	public float speed;
	public GameObject player;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown (KeyCode.W)) {
			Vector3 targetTransform = Vector3.forward; //new Vector3 (0, 0, 1, Space.Self);
			player.transform.position += targetTransform;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			Vector3 targetTransform = Vector3.right;
			player.transform.position += targetTransform;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			Vector3 targetTransform = Vector3.left;
			player.transform.position += targetTransform;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			Vector3 targetTransform = Vector3.back;
			player.transform.position += targetTransform;
		}*/


		
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		
	}
}
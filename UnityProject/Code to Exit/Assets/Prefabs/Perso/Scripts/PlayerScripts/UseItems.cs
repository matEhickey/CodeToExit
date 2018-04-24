using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItems : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		RaycastHit hit;

		if(Physics.Raycast(transform.position, fwd, out hit)) {
			if (hit.collider.gameObject.tag == "Console") {
				Debug.Log ("lll");
			}
		}
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Console") {
			Debug.Log ("boop");
		}
	}
}

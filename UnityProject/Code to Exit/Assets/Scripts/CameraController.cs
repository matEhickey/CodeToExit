using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public Transform target;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		//offset = transform.position - player.transform.position;
		transform.LookAt(player.transform.position);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		//transform.position = player.transform.position + offset;
		transform.LookAt(player.transform.position);
		/*Vector3 relPos = target.position - transform.position;
		Quaternion rot = Quaternion.LookRotation (relPos);
		transform.rotation = rot;
		transform.Rotate (rot, 1f, Space.World);
		print (rot);*/
	}
}

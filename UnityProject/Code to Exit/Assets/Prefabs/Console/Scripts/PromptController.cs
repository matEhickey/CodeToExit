using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;



public class PromptController : MonoBehaviour {

	public GameObject text;
	public GameObject player;
	public Camera playerCamera;
	public Camera problemCamera;

	private GameObject[] nodeNames;


	bool showMessage = false;
	bool inUse = false;

	private GameObject walls;

	// Use this for initialization
	void Start () {
		text.SetActive (false);
		problemCamera.enabled = false;
		nodeNames = new GameObject[0];

		if (Application.loadedLevelName == "Lvl2") {
			walls = GameObject.Find ("Walls");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (showMessage && Input.GetButtonDown( "Cancel" ))  {
			UseInterface ();
		}
	}

	public void UseInterface() {
		text.SetActive(true);

		playerCamera.enabled = false;
		problemCamera.enabled = true;
		inUse = true;
		player.GetComponent<BasicBehaviour> ().isAllowedToMove = false;
		showMessage = false;

		if(Application.loadedLevelName == "Lvl2"){
			foreach(GameObject nn in nodeNames){
				nn.SetActive (true);
			}
			walls.SetActive (false);
		}
	}

	public void Quit() {
		text.SetActive(false);
		problemCamera.enabled = false;
		playerCamera.enabled = true;
		inUse = false;
		showMessage = true;

		if (Application.loadedLevelName == "Lvl1"){
			player.GetComponent<BasicBehaviour> ().isAllowedToMove = true;
		}else if(Application.loadedLevelName == "Lvl2"){
			walls.SetActive (true);
			if (GameObject.Find ("Graph")) {
				if (!GameObject.Find ("Graph").GetComponent<solveGraph> ().isSolving)
					player.GetComponent<BasicBehaviour> ().isAllowedToMove = true;

				nodeNames = GameObject.FindGameObjectsWithTag ("nodeName");
				foreach (GameObject nn in nodeNames) {
					nn.SetActive (false);
				}
			} else {
				player.GetComponent<BasicBehaviour> ().isAllowedToMove = true;
			}
		}

	}

	void OnTriggerEnter(Collider other) {
			showMessage = true;
	}


	void OnTriggerExit(Collider other) {
		showMessage = false;
	}

	void OnGUI() {
		if (showMessage && !inUse) {
			GUI.Label (new Rect (Screen.width / 2 - 100f, Screen.height / 2 - 100f, 200f, 200f), "Press escape to open the editor");
		}
	}
}

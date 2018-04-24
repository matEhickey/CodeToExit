using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CredButtonScript : MonoBehaviour {


	public UnityEngine.UI.Text textcredit;
	public UnityEngine.UI.Image imageCode;

		
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TaskOnClick(){
		textcredit.enabled = true;
		imageCode.enabled = false;
	}
}

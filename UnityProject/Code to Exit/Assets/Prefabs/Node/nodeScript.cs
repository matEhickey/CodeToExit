using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PairOf{

}

public class nodeScript : MonoBehaviour {
	[SerializeField] public string name = "_";
	[SerializeField] public List<GameObject> nodeConnected;
	[SerializeField] public List<GameObject> chemins;
	// Use this for initialization
	void Start () {
		transform.Find ("nodeName").GetComponent<TextMesh> ().text = name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMoover : MonoBehaviour {
	private Animator anim;
	bool activated = false;
	[SerializeField] private GameObject graph;

	List<string> chemin;

	// Use this for initialization
	void Start () {
		this.anim = this.GetComponent<Animator> ();
	}
	
	public void activate(List<string> chemin){
		activated = true;
		this.chemin = chemin;
		this.GetComponent<Animation> ().Play ();
	}

	public void Update(){
		if (!this.GetComponent<Animation> ().IsPlaying ("MooverLvl2") && activated) {
			activated = false;
			this.GetComponent<Animation> ().Stop ();
			graph.GetComponent<solveGraph> ().resolve(chemin);
		}
	}

}

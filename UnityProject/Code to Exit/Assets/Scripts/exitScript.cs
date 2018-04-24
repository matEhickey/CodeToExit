using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitScript : MonoBehaviour {
	[SerializeField] private string nextLevel;
	private bool show = false;
	private AsyncOperation asyncop;
	// Use this for initialization
	void OnTriggerEnter(Collider other) {
		show = true;
		asyncop = SceneManager.LoadSceneAsync (nextLevel, LoadSceneMode.Single);
		asyncop.allowSceneActivation = false;
		GameObject.Find ("Perso").GetComponent<BasicBehaviour> ().isAllowedToMove = false;
	}
	void OnGUI(){
		if(show)
			GUI.Label (new Rect (Screen.width / 2 - 100f, Screen.height / 2 - 100f, 200f, 200f), "Loading next level");
	}

	void Update(){
		if (asyncop != null) {
			if (asyncop.progress == (float)0.9) {
				StartCoroutine (launchAnim());
			}
		}
	}

	IEnumerator launchAnim(){
		show = false;
		GameObject.Find ("Exit").GetComponentInChildren<Animator> ().SetBool ("animating", true);
		yield return new WaitForSeconds(0.2f);
		asyncop.allowSceneActivation = true;
	}
}

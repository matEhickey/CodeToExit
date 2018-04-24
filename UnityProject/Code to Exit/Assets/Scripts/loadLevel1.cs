using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel1 : MonoBehaviour {

	// Use this for initialization
	public void load(){

		SceneManager.LoadScene ("firstCo", LoadSceneMode.Single);

	}
}

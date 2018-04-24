using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour {

	public void returnToMenu(){
		SceneManager.LoadScene ("menu", LoadSceneMode.Single);
	}

	public void quitGame(){
		//print (Application.loadedLevelName);

		//nettoie player id si server != main
		if (PlayerPrefs.GetInt ("changedIP") == 1) {
			PlayerPrefs.DeleteKey ("player_id");
		}

		Application.Quit ();
	}
}

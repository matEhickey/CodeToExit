using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeIP : MonoBehaviour {
	[SerializeField] private Text text;
	[SerializeField] private GameObject panel;

	[SerializeField] private InputField ipMess;
	[SerializeField] private string ip ;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("ip")) {
			if (PlayerPrefs.GetString ("ip") != ip) {
				PlayerPrefs.DeleteKey ("player_id");
			}
		}
			
		PlayerPrefs.SetString ("ip", ip);
		PlayerPrefs.SetInt ("changedIP", 0);
		refreshIP ();
	}

	void refreshIP(){
		text.text = PlayerPrefs.GetString("ip");
	}
	
	public void showPanelIP(){
		panel.SetActive (true);
	}

	public void setIP(){
		string newip = ipMess.text;
		PlayerPrefs.SetString ("ip", newip);
		PlayerPrefs.SetInt ("changedIP", 1);
		refreshIP ();
	}
}

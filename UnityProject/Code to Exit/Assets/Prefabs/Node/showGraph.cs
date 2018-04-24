using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showGraph : MonoBehaviour {
	[SerializeField] private GameObject graph;
	[SerializeField] private Button buttonLaunchAnim;
	[SerializeField] private Button buttonHideGraph;

	
	public void switchGraphDisplay(){
		graph.SetActive (true);
		//buttonLaunchAnim.interactable = enable;
		buttonHideGraph.gameObject.SetActive(false);
	}
}

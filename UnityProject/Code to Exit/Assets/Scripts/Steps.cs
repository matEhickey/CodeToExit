using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour {

	private List<GameObject> steps;

	public List<int> init;

	private int nbStep = 45;

	public Material mat;


	// Use this for initialization
	void Start () {
		init = new List<int> ();
		for (int i = 0; i < nbStep; i++) {
			int randomI = Random.Range (i, init.Count);
			init.Add (randomI);
		}

		Shuffle (init);

		Refresh ();
	}


	void destroySteps(){
		foreach(GameObject step in steps){
			Destroy(step);
		}
	}

	void printInit(){
		string s = "";
		foreach(int i in init){
			s += i+" ";
		}
		print (s);
	}


	public void Refresh(){
		printInit ();

		if(!object.Equals(steps,null)){
			destroySteps ();
		}


		steps = new List<GameObject> ();
		for (int i = 0; i < init.Count; i++) {
			GameObject step = GameObject.CreatePrimitive(PrimitiveType.Cube);
			step.transform.position = new Vector3 (0.0f,i*0.1f,20.0f);
			step.transform.localScale = new Vector3 (5.0f,0.1f,5f+init[i]);
			step.name = "Step" + (i+1);

			Renderer rend = step.GetComponent<MeshRenderer>();
			if (rend != null){
				rend.material = mat;
			}

			step.transform.parent = GameObject.Find("Steps").transform;
			steps.Add (step);
		}



	}

	public void Solve(){
		init.Sort();
		init.Reverse ();
		Refresh ();
	}

	// Update is called once per frame
	void Update () {
		
	}


	void Shuffle<T>(IList<T> list)  
	{  
		int n = list.Count;  
		while (n > 1) {  
			n--;  
			int k = Random.Range(0,n + 1);  
			T value = list[k];  
			list[k] = list[n];  
			list[n] = value;  
		}  
	}
}

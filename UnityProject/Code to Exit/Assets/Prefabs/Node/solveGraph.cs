using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solveGraph : MonoBehaviour {

	[SerializeField] private GameObject moover;
	[SerializeField] private GameObject perso;
	[SerializeField] private GameObject begin;
	[SerializeField] private GameObject end;

	private GameObject actual;
	private Vector3 positionInit;

	private List<string> solution;

	private List<Transform> cheminRetour;

	public bool isSolving = false;

	void Start(){
		
		//StartCoroutine (tryToResolve ());
		positionInit = moover.transform.position;

	}

	IEnumerator retourApresErreur (){
		cheminRetour.Reverse ();
		for (int i = 0; i < cheminRetour.Count && cheminRetour[i].position != begin.transform.position; i++) {
			print ("chemin retour "+i);
			moover.transform.position = cheminRetour[i].position+ new Vector3 (0, -4f, 0);
			perso.transform.position = moover.transform.position;
			yield return new WaitForSeconds(0.5f);
		}
		print ("resetPosition");
		moover.transform.position = positionInit;
		perso.transform.position = moover.transform.position;
		perso.GetComponent<BasicBehaviour> ().isAllowedToMove = true;
		isSolving = false;
	}

	IEnumerator tryToResolve()
	{

		perso.GetComponent<BasicBehaviour> ().isAllowedToMove = false;

		bool error = true;
		if (solution[0] == begin.GetComponent<nodeScript> ().name) {
			actual = begin;
			error = false;
		}

		for (int i = 0; i< solution.Count && !error; i++) {

			if (true) {
				if (i > 0) {
					print ("finding next to " + actual.GetComponent<nodeScript> ().name);
					print ("try to fetch " + solution [i]);

					int nodeSolutionIndexTemp = 0;
					bool nodeSoluceFound = false;
					int nodeSolutionIndex = 0;


					foreach (GameObject nodeConnected in actual.GetComponent<nodeScript> ().nodeConnected) {
						
						if (nodeConnected.GetComponent<nodeScript> ().name == solution [i]) {
							nodeSoluceFound = true;
							nodeSolutionIndex = nodeSolutionIndexTemp;
						}
						nodeSolutionIndexTemp++;
					}

					if (nodeSoluceFound) {
						print ("found : " + nodeSolutionIndex);
						cheminRetour.Add (actual.transform);
						//actual.transform.FindChild ("Sphere").GetComponent<Animator> ().Play("Sphere");
						actual = actual.GetComponent<nodeScript> ().nodeConnected [nodeSolutionIndex];

						//actual.transform.FindChild ("Sphere").GetComponent<Animator> ().Stop();

					} else {
						error = true;
						print ("not found");
					}
				}



				moover.transform.position = actual.transform.position + new Vector3 (0, -4f, 0);
				perso.transform.position = moover.transform.position;
				yield return new WaitForSeconds (1f);
			} else {
				//erreur, solution impossie
				error=true;
			}
		}


		if (actual.GetComponent<nodeScript> ().name != end.GetComponent<nodeScript> ().name)
			error = true;
		else {
			isSolving = false;
		}
		


		if (error) {
			StartCoroutine (retourApresErreur ());
		} else {
			perso.GetComponent<BasicBehaviour> ().isAllowedToMove = true;
		}
	}
		

	// Use this for initialization
	public void resolve(List<string> chemin){
		if(GameObject.Find ("showGraphButton") != null)
			GameObject.Find ("showGraphButton").GetComponent<showGraph> ().switchGraphDisplay ();
		
		isSolving = true;
		solution = chemin;//new List<string>(){"A", "B","A","C","D","G","H","G","I","G","D","E","F","E","J","K","J","L","M","N","M","L","O","P","O","Q"};

		cheminRetour = new List<Transform> ();

		StartCoroutine (tryToResolve());

	}

	public void resolveCheat(){
		resolve (new List<string>(){"A", "B","A","C","D","G","H","G","I","G","D","E","F","E","J","K","J","L","M","N","M","L","O","P","O","Q"});
	}
}

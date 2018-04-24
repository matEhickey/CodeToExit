using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;



public class sendExecution : MonoBehaviour {
	[SerializeField] private InputField textarea;

	[SerializeField] private InputField terminal;
	private string language;
	private string script;
	private string problem;

	[SerializeField] Steps steps;
	bool wasAnError = false;

	void Start(){
		this.GetComponent<Button> ().interactable = false;

	}

	public void sendScript(){
		script = textarea.text;
		this.send ();
	}

	public void setLanguage(String lang){
		if (lang == "beginC") {
			language = "c";
		}else if(lang == "beginJava"){
			language = "java";
		}
		else {
			language = "cpp";
		}
	}

	public void setProbleme(string prob){
		problem = prob;
	}

	void send() {
		try{
			//see https://docs.unity3d.com/Manual/UnityWebRequest-RetrievingTextBinaryData.html for more unity way
					
			// Create a request using a URL that can receive a post.
			String url = "http://"+PlayerPrefs.GetString("ip")+"/gameServer/Execution/createExecution.php";
			print(url);
			WebRequest request = WebRequest.Create (url);
			// Set the Method property of the request to POST.
			request.Method = "POST";
			request.Timeout = 5000;
			// Create POST data and convert it to a byte array.




			string postData = "language="+language+"&problem_id="+problem+"&player_id="+PlayerPrefs.GetInt("player_id")+"&script="+(script.Replace("&","##PBAMT1##").Replace("+","##PBAMT2##"));
			byte[] byteArray = Encoding.UTF8.GetBytes (postData);
			// Set the ContentType property of the WebRequest.
			request.ContentType = "application/x-www-form-urlencoded";
			// Set the ContentLength property of the WebRequest.
			request.ContentLength = byteArray.Length;
			// Get the request stream.
			Stream dataStream = request.GetRequestStream ();
			// Write the data to the request stream.
			dataStream.Write (byteArray, 0, byteArray.Length);
			// Close the Stream object.
			dataStream.Close ();
			// Get the response.
			WebResponse response = request.GetResponse ();
			// Display the status.
			print (((HttpWebResponse)response).StatusDescription);
			// Get the stream containing content returned by the server.
			dataStream = response.GetResponseStream ();
			// Open the stream using a StreamReader for easy access.
			StreamReader reader = new StreamReader (dataStream);
			// Read the content.
			string responseFromServer = reader.ReadToEnd ();

			// Clean up the streams.
			reader.Close ();
			dataStream.Close ();
			response.Close ();


			//string responseFromServer = "coucou";
			terminal.text = responseFromServer;

			// Display the content.
			if (SceneManager.GetActiveScene().name == "Lvl1"){
				solveLevel1(responseFromServer);
			}else if(SceneManager.GetActiveScene().name == "Lvl2"){
				solveLevel2(responseFromServer);
			}


		}
		catch(Exception e){
			print (e);
			wasAnError = true;
		}
	}

	void OnGUI()
	{
		if (wasAnError) {
			GUI.Box (new Rect (0, 0, Screen.width, Screen.height / 8), "There was an error with the network. \nThe server is maybe 500, or code took to mush time to compile/execute.");
			StartCoroutine (wait10sBeforeDropErrorMessage ());
		}
	}

	IEnumerator wait10sBeforeDropErrorMessage (){
		yield return new WaitForSeconds (10f);

		wasAnError = false;
	}


	void solveLevel1(string responseFromServer){

		string pattern = @"(?:\d{1,2}[ ]*){45}";
		Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);

		MatchCollection matches = rgx.Matches(responseFromServer);
		//print("matchCount : "+matches.Count);

		List<int> newSteps = new List<int>();

		if (matches.Count == 1)
		{
			//print("found : "+matches[0].Value.Split(' ').Length);
			foreach(string i in matches[0].Value.Split(' ')){
				int n;
				if(int.TryParse(i, out n)){ 
					newSteps.Add(n);
				}
			}
		}

		print("new steps: ");
		foreach(int i in newSteps){
			print(i);
		}

		this.steps.init = newSteps;
		this.steps.Refresh();
	}


	void solveLevel2(string responseFromServer){

		print (responseFromServer);

		string pattern = @"(?:[A-Z]{1}[ ]*)+";
		Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);

		MatchCollection matches = rgx.Matches(responseFromServer);
		print("matchCount : "+matches.Count);

		List<string> chemin = new List<string>();

		if (matches.Count == 1)
		{
			//print("found : "+matches[0].Value.Split(' ').Length);
			foreach(string i in matches[0].Value.Split(' ')){
				if (i != "")
					chemin.Add (i);
			}
		}

		//print ("resolution niveau 2");
		GameObject.Find ("Moover").GetComponent<activateMoover> ().activate (chemin);
	}
}

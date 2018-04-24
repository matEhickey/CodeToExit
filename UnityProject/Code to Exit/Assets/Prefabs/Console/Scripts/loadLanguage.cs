using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.Text;
using System.IO;
using SimpleJSON;


public class loadLanguage : MonoBehaviour {

	[SerializeField] private string probleme;
	[SerializeField] private string scriptName;
	[SerializeField] private Button runButton;
	[SerializeField] private InputField textareaCode;
	[SerializeField] private InputField textareaDescr;

	private InputField txt;
	private bool wasAnError = false;
	private string errorDescription;


	void Start(){
		txt = GameObject.Find ("CodeInput").GetComponent<UnityEngine.UI.InputField> ();
	}

	public void loadScript(){
		StartCoroutine (routineloadScript());

	}

	IEnumerator routineloadScript(){
		try{
			// Create a request using a URL that can receive a post. 
			print("http://"+PlayerPrefs.GetString("ip")+"/gameServer/Problem/showOneJson.php?id="+probleme);
			WebRequest request = WebRequest.Create ("http://"+PlayerPrefs.GetString("ip")+"/gameServer/Problem/showOneJson.php?id="+probleme);
			// Set the Method property of the request to POST.
			request.Method = "POST";
			request.Timeout = 5000;

			// Create POST data and convert it to a byte array.
			string postData = "";
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
			//print (((HttpWebResponse)response).StatusDescription);

			// Get the stream containing content returned by the server.
			dataStream = response.GetResponseStream ();
			// Open the stream using a StreamReader for easy access.
			StreamReader reader = new StreamReader (dataStream);
			// Read the content.
			string responseFromServer = reader.ReadToEnd ();
			// Display the content.




			JSONNode reponse = JSON.Parse(responseFromServer);

			print (reponse);

			txt.text = reponse[scriptName];


			// Clean up the streams.
			reader.Close ();
			dataStream.Close ();
			response.Close ();



			runButton.interactable = true;
			runButton.GetComponent<sendExecution>().setLanguage(scriptName);
			runButton.GetComponent<sendExecution>().setProbleme(probleme);

			textareaCode.interactable = true;
			textareaDescr.text = reponse["description"];

		}
		catch(Exception e){
			//print (e);
			errorDescription = e.ToString ();
			wasAnError = true;

		}

		yield return new WaitForSeconds(0.0f);

	}

	void OnGUI()
	{
		if (wasAnError) {
			GUI.Box (new Rect (0, 0, Screen.width, Screen.height / 4), "There was an error with the network. Maybe the IP is wrong, or server is 500. : \n\n"+errorDescription);
			StartCoroutine (wait10sBeforeDropErrorMessage ());
		}
	}

	IEnumerator wait10sBeforeDropErrorMessage (){
		yield return new WaitForSeconds (10f);

		wasAnError = false;
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;

public class initScript : MonoBehaviour {



	int createUser() {

		int myId = 0;
		try{
			// Create a request using a URL that create a user id
			WebRequest request = WebRequest.Create ("http://"+PlayerPrefs.GetString("ip")+"/gameServer/Player/createPlayer.php");
			// Set the Method property of the request to POST.
			request.Method = "POST";
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
			print (((HttpWebResponse)response).StatusDescription);
			// Get the stream containing content returned by the server.
			dataStream = response.GetResponseStream ();
			// Open the stream using a StreamReader for easy access.
			StreamReader reader = new StreamReader (dataStream);
			// Read the content.
			string responseFromServer = reader.ReadToEnd ();
			// Display the content.
			print ("my number : "+responseFromServer);

			myId = Int32.Parse(responseFromServer);



			// Clean up the streams.
			reader.Close ();
			dataStream.Close ();
			response.Close ();
		}
		catch(Exception e){
			print (e);
		}

		return(myId);
	}







	// Use this for initialization
	void Start () {


		if(PlayerPrefs.HasKey("player_id") && PlayerPrefs.GetInt("changedIP") == 0){
			print("there is already an id in main server :"+PlayerPrefs.GetInt("player_id"));
		}
		else{
			int id = createUser ();
			PlayerPrefs.SetInt("player_id", id);
		}

		SceneManager.LoadScene ("Lvl1", LoadSceneMode.Single);
	}
		


}

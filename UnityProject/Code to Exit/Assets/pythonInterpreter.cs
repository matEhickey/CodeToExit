using System; 
using System.IO; 
using System.Diagnostics; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pythonInterpreter : MonoBehaviour {
	[SerializeField] private InputField inputField;
	[SerializeField] private InputField outputField;
	private string pythonPath = null;
	private string tmpFilePath = @"C:\tmp\script.py";

	void Start(){
		print (Directory.GetCurrentDirectory());
		pythonPath = @"./Python27/pythonw.exe";
		inputField.text = "import __future__\nfor i in range(50): \n\tprint(\"Hello world\",i)";
	}

	public void execute(){
		GetComponent<Button> ().interactable = false;
		StartCoroutine (execution());
	}

	IEnumerator execution(){

		System.IO.File.WriteAllText (tmpFilePath,inputField.text);

		// Create new process start info 
		ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(pythonPath); 

		// make sure we can read the output from stdout 
		myProcessStartInfo.UseShellExecute = false; 
		myProcessStartInfo.RedirectStandardOutput = true; 

		// start python app with 0 arguments  
		myProcessStartInfo.Arguments = tmpFilePath; 
		//myProcessStartInfo.WindowStyle = ProcessWindowStyle.Minimized;

		Process myProcess = new Process(); 
		// assign start information to the process 
		myProcess.StartInfo = myProcessStartInfo; 

		// start the process 
		myProcess.Start(); 

		// Read the standard output of the app we called.  
		// in order to avoid deadlock we will read output first 
		// and then wait for process terminate: 
		StreamReader myStreamReader = myProcess.StandardOutput; 
		string myString = myStreamReader.ReadToEnd ();     

		// wait exit signal from the app we called and then close it. 
		myProcess.WaitForExit(); 
		myProcess.Close(); 

		// write the output we got from python app 
		print(myString); 
		outputField.text = myString;
		GetComponent<Button> ().interactable = true;
		yield return new WaitForSeconds(0.0f);
	}
}

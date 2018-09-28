using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReceiveName3 : MonoBehaviour {

	public OSC osc;
	string Name1;
	//	string Index = "/track1name";


	// Use this for initialization
	void Start () {

		osc.SetAddressHandler( "/Track3" , OnReceiveName1 );

	}

	// Update is called once per frame
	void Update () {

		//		Name1 = message.ToString ();
		//
		//		GetComponent<TextMesh>().text = Name1.ToString();

	}

	void OnReceiveName1(OscMessage message){

		Name1 = message.ToString ();

		if (Name1.Contains ("/track1name")) {

			Name1.Replace ("/track1name", "");

		}

		GetComponent<TextMesh>().text = Name1;


	}




}
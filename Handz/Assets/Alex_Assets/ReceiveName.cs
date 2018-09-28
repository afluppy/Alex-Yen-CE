using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReceiveName : MonoBehaviour {
    
   	public OSC osc;
	string Name1;
//	string Index = "/track1name";


	// Use this for initialization
	void Start () {
		
		osc.SetAddressHandler( "/Track1" , OnReceiveName1 );
   
    }
	
	// Update is called once per frame
	void Update () {
		
//		if (Name1.Contains ("/Track1")) {
//
//			Name1.Replace ("/Track1", "");
//
//		}

		GetComponent<TextMesh>().text = Name1;

	}

	void OnReceiveName1(OscMessage message){

		Name1 = message.ToString ();

		if (Name1.Contains ("/Track1")) {

			Name1.Replace ("/Track1", "");

		}

		GetComponent<TextMesh>().text = Name1;


	}

   


}


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReceivePan2 : MonoBehaviour {

	public OSC osc;
	public GameObject Sphere2;
	public float Pan2;
	public GameObject IsAutoOn;
	public bool isImgOn;
	public Vector3 currentPosition;


	//	string Index = "/track1name";


	// Use this for initialization
	void Start () {

		osc.SetAddressHandler( "/Track2Pan" , OnReceiveName1 );
		IsAutoOn.GetComponent<IsAutoOn>();


		currentPosition = Sphere2.transform.position;



	}

	// Update is called once per frame
	void Update () {
		if (isImgOn == false) {
			MovePan ();

			//			GameObject Sphere1 = GameObject.Find ("Sphere1");
			//			ReceiveFreq1 Freq1Script = Sphere1.GetComponent<ReceiveFreq1> ();
			//			Freq1 = Freq1Script.Freq1;

			//			Freq1 = GameObject.Find ("Sphere1").GetComponent<ReceiveFreq1> ().Freq1;
			//
			//			currentPosition = Sphere1.transform.position;

			currentPosition.x = Pan2;
			currentPosition.y = Sphere2.GetComponent<ReceiveFreq2> ().Freq2;

			Sphere2.transform.position = currentPosition;

		}

		//		Freq1 = ReceiveFreq1.Freq1;

	}

	void OnReceiveName1(OscMessage message){

		Pan2 = message.GetFloat(0);

	}

	void MovePan (){

		//		Sphere1.transform.localPosition = new Vector3 (Pan1, currentPosition[1], 0f);



	}

}

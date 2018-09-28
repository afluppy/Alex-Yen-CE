using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReceiveFreq1 : MonoBehaviour {

	public OSC osc;
	public GameObject Sphere1;
	public float Freq1;
	public GameObject IsAutoOn;
	public bool isImgOn;
	public Vector3 currentPosition;
	public float Pan1;
	//	string Index = "/track1name";


	// Use this for initialization
	void Start () {

		osc.SetAddressHandler( "/Track1Freq" , OnReceiveName1 );
		IsAutoOn.GetComponent<IsAutoOn>();

	}

	// Update is called once per frame
	void Update () {
		if (isImgOn == false) {
			MovePan ();

//			GameObject Sphere1 = GameObject.Find ("Sphere1");
//			ReceivePan1 Pan1Script = Sphere1.GetComponent<ReceivePan1> ();
//			Pan1 = Pan1Script.Pan1;

//			Pan1 = GameObject.Find ("Sphere1").GetComponent<ReceivePan1> ().Pan1;


		}


	}

	void OnReceiveName1(OscMessage message){

		Freq1 = message.GetFloat(0);

	}

	void MovePan (){

//		Sphere1.transform.localPosition = new Vector3 (currentPosition[0], Freq1, 0f);
//		Sphere1.transform.position[1] = Freq1;


	}

}

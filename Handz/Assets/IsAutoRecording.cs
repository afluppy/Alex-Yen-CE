using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IsAutoRecording : MonoBehaviour {

	public bool isImgOn;
	public Text img;
	public GameObject Sphere;
	public GameObject Sphere2;
	public GameObject Sphere3;
	public GameObject IsAutoOn;

	void Awake () {

//		Sphere.GetComponent<SendPositionOnUpdate>().enabled = true;
//		Sphere2.GetComponent<SendPositionOnUpdate2> ().enabled = true;
//		Sphere3.GetComponent<SendPositionOnUpdate3>().enabled = true;

	}

	void Start () {

		img.enabled = false;
		isImgOn = false;

//		Sphere.GetComponent<SendPositionOnUpdate>().enabled = true;
//		Sphere2.GetComponent<SendPositionOnUpdate2> ().enabled = true;
//		Sphere3.GetComponent<SendPositionOnUpdate3>().enabled = true;
//
//		Sphere.GetComponent<ReceivePan1>().enabled = false;
		//		Sphere2.GetComponent<ReceivePan2>().enabled = false;
		//		Sphere3.GetComponent<ReceivePan3>().enabled = false;
		//		RightController = GetComponent (EnableAutomation);
	}

	void Update () {

		if (OVRInput.GetDown (OVRInput.Button.Two)) {

			if (isImgOn == false) {

				img.enabled = true;
				isImgOn = true;

				IsAutoOn.GetComponent<IsAutoOn> ().enabled = false;

				Sphere.GetComponent<SendPositionOnUpdate>().enabled = true;
				Sphere2.GetComponent<SendPositionOnUpdate2>().enabled = true;
				Sphere3.GetComponent<SendPositionOnUpdate3>().enabled = true;
//
				Sphere.GetComponent<ReceivePan1>().enabled = false;
						Sphere2.GetComponent<ReceivePan2>().enabled = false;
				//		Sphere3.GetComponent<ReceivePan3>().enabled = false;

				Sphere.GetComponent<ReceiveFreq1>().enabled = false;
						Sphere2.GetComponent<ReceiveFreq2>().enabled = false;
				//		Sphere3.GetComponent<ReceiveFreq3>().enabled = false;

			}

			else {

				img.enabled = false;
				isImgOn = false;

				IsAutoOn.GetComponent<IsAutoOn> ().enabled = true;

				Sphere.GetComponent<SendPositionOnUpdate>().enabled = false;
				Sphere2.GetComponent<SendPositionOnUpdate2>().enabled = false;
				Sphere3.GetComponent<SendPositionOnUpdate3>().enabled = false;
//
				Sphere.GetComponent<ReceivePan1>().enabled = true;
						Sphere2.GetComponent<ReceivePan2>().enabled = true;
				//		Sphere3.GetComponent<ReceivePan3>().enabled = false;

				Sphere.GetComponent<ReceiveFreq1>().enabled = true;
						Sphere2.GetComponent<ReceiveFreq2>().enabled = true;
				//		Sphere3.GetComponent<ReceiveFreq3>().enabled = true;
			}


		}

		if (Input.GetKeyDown ("i")) {

			if (isImgOn == true) {

				img.enabled = false;
				isImgOn = false;

			}

			else {

				img.enabled = true;
				isImgOn = true;

			}


		}
	}
}
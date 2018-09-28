using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IsAutoOn : MonoBehaviour {

	public bool isImgOn;
	public Text img;
	public GameObject Sphere;
	public GameObject Sphere2;
	public GameObject Sphere3;

//	public GameObject RightController;

	void Awake () {
		
		Sphere.GetComponent<SendPositionOnUpdate>().enabled = true;
		Sphere2.GetComponent<SendPositionOnUpdate2> ().enabled = true;
		Sphere3.GetComponent<SendPositionOnUpdate3>().enabled = true;

	}

	void Start () {

		img.enabled = false;
		isImgOn = false;
//		GetComponent (Sphere<SendPositionOnUpdate>);
		Sphere.GetComponent<SendPositionOnUpdate>().enabled = true;
		Sphere2.GetComponent<SendPositionOnUpdate2> ().enabled = true;
		Sphere3.GetComponent<SendPositionOnUpdate3>().enabled = true;

		Sphere.GetComponent<ReceivePan1>().enabled = false;
		Sphere2.GetComponent<ReceivePan2>().enabled = false;
//		Sphere3.GetComponent<ReceivePan3>().enabled = false;

		Sphere.GetComponent<ReceiveFreq1>().enabled = false;
		Sphere2.GetComponent<ReceiveFreq2>().enabled = false;
		//		Sphere3.GetComponent<ReceiveFreq3>().enabled = false;
	}

	void Update () {

		if (OVRInput.GetDown (OVRInput.Button.One)) {

			if (isImgOn == false) {

				img.enabled = true;
				isImgOn = true;
			    
				Sphere.GetComponent<SendPositionOnUpdate>().enabled = false;
				Sphere2.GetComponent<SendPositionOnUpdate2>().enabled = false;
				Sphere3.GetComponent<SendPositionOnUpdate3>().enabled = false;

				Sphere.GetComponent<ReceivePan1>().enabled = true;
						Sphere2.GetComponent<ReceivePan2>().enabled = true;
				//		Sphere3.GetComponent<ReceivePan3>().enabled = false;

				Sphere.GetComponent<ReceiveFreq1>().enabled = true;
						Sphere2.GetComponent<ReceiveFreq2>().enabled = true;
				//		Sphere3.GetComponent<ReceiveFreq3>().enabled = true;


			}

			else {

				img.enabled = false;
				isImgOn = false;

				Sphere.GetComponent<SendPositionOnUpdate>().enabled = true;
				Sphere2.GetComponent<SendPositionOnUpdate2>().enabled = true;
				Sphere3.GetComponent<SendPositionOnUpdate3>().enabled = true;

				Sphere.GetComponent<ReceivePan1>().enabled = false;
						Sphere2.GetComponent<ReceivePan2>().enabled = false;
				//		Sphere3.GetComponent<ReceivePan3>().enabled = false;

				Sphere.GetComponent<ReceiveFreq1>().enabled = false;
						Sphere2.GetComponent<ReceiveFreq2>().enabled = false;
				//		Sphere3.GetComponent<ReceiveFreq3>().enabled = false;
			}
		
		
		}

		if (Input.GetKeyDown ("o")) {

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
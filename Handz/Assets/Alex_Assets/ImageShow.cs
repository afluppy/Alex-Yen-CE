using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageShow : MonoBehaviour {

	public bool isImgOn;
	public Image img;

	void Start () {

		img.enabled = false;
		isImgOn = false;
	}

	void Update () {

		if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick)) {

			if (isImgOn == true) {

				img.enabled = false;
				isImgOn = false;
			}

			else {

				img.enabled = true;
				isImgOn = true;
			}
		}

		if (Input.GetKeyDown("h")) {

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
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HelpText : MonoBehaviour {

	public bool isImgOn;
	public Text img;

	void Start () {

		img.enabled = true;
		isImgOn = true;
	}

	void Update () {

		if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick)) {

			if (isImgOn == false) {

				img.enabled = true;
				isImgOn = true;
			}

			else {

				img.enabled = false;
				isImgOn = false;
			}
		}

		if (Input.GetKeyDown("h")) {

			if (isImgOn == false) {

				img.enabled = true;
				isImgOn = true;
			}

			else {

				img.enabled = false;
				isImgOn = false;
			}
	}
			}}
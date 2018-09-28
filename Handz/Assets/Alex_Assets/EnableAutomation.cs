using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAutomation : MonoBehaviour {


	public OSC osc;
	public bool AutoEnabled;
	public bool RecordingAuto;
//	public text ;

	// Use this for initialization
	void Start () {
		
	}

	// sends osc message to enable automation
	void EnableAuto () {

		AutoEnabled = true;
		OscMessage message = new OscMessage();

		message.address = "/EnableAuto";
		message.values.Add(127);
		osc.Send(message);

	}

	void DisableAuto () {

		AutoEnabled = false;
		OscMessage message = new OscMessage();

		message.address = "/EnableAuto";
		message.values.Add(0);
		osc.Send(message);

	}

	void RecordAuto () {
		
		RecordingAuto = true;
		OscMessage message = new OscMessage();

		message.address = "/RecordAuto";
		message.values.Add(127);
		osc.Send(message);

	}

	void StopRecordAuto () {

		RecordingAuto = false;
		OscMessage message = new OscMessage();

		message.address = "/RecordAuto";
		message.values.Add(0);
		osc.Send(message);

	}

	// Update is called once per frame
	void Update () {

		if (OVRInput.GetDown (OVRInput.Button.One)) {
			if (AutoEnabled == false) {

				EnableAuto();
			}

			else {

				DisableAuto();
		}
	}

		if (OVRInput.GetDown (OVRInput.Button.Two)) {
			if (RecordingAuto == false) {

				RecordAuto();
			}

			else {

				StopRecordAuto();
			}
		}

//		if (OVRInput.Get (OVRInput.Axis1D.SecondaryHandTrigger) < 1) {
//			StopRecordAuto ();
//
//		}
}
}

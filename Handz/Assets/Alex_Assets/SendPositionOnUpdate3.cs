using UnityEngine;
using System.Collections;

public class SendPositionOnUpdate3 : MonoBehaviour {

	public OSC osc;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		OscMessage message = new OscMessage();

		message.address = "/UpdateXYZBall3";
		message.values.Add(transform.position.x);
		message.values.Add(transform.position.y);
		message.values.Add(transform.position.z);
		osc.Send(message);

		message = new OscMessage();
		message.address = "/UpdateBall3Vol";
		message.values.Add(transform.localScale.x);
		osc.Send(message);




	}


}
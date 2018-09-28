using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {

	public float grabRadius;
	public LayerMask grabMask;

	private GameObject grabbedObject;
	private bool grabbing;

	public KeyCode increaseAlpha;
	public KeyCode decreaseAlpha;
	public float alphaLevel = .5f ;


	// Use this for initialization
	void GrabObject() {
		grabbing = true;

		RaycastHit[] hits;

		hits = Physics.SphereCastAll (transform.position, grabRadius, transform.forward, 0f, grabMask);

			if (hits.Length > 0){

			int closestHit = 0;

				for (int i = 0; i < hits.Length; i++) {
					if (hits[i].distance > hits[closestHit].distance) closestHit = 1; 

				}

				grabbedObject = hits[closestHit].transform.gameObject;
			grabbedObject.GetComponent<Rigidbody> ().isKinematic = true;
			grabbedObject.transform.position = transform.position;
			grabbedObject.transform.parent = transform;

			}}
				

	void DropObject() {
		grabbing = false;
			
		if (grabbedObject != null){
			grabbedObject.transform.parent = null;
			grabbedObject.GetComponent<Rigidbody> ().isKinematic = true;

			grabbedObject = null;
			
		}}

	void StretchObject() {
		grabbedObject.transform.localScale += new Vector3 (0.005F, 0.005F, 0.005F);
	}

	void ShrinkObject() {
		grabbedObject.transform.localScale += new Vector3 (-0.005F, -0.005F, -0.005F);
	}

	void TransparentObject() {
		
	}

	// Update is called once per frame
	void Update () {
		if (!grabbing && Input.GetAxis ("Oculus_GearVR_RIndexTrigger") == 1) GrabObject();
		if (grabbing && Input.GetAxis ("Oculus_GearVR_RIndexTrigger") < 1) DropObject();
		if (grabbing && Input.GetAxis ("Oculus_GearVR_LIndexTrigger") == 1) StretchObject();
		if (grabbing && Input.GetAxis ("LTopTrigger") == 1) ShrinkObject();
		if (grabbing) TransparentObject ();
		}
	}


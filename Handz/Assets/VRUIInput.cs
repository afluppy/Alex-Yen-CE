using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(SteamVR_LaserPointer))]
public class VRUIInput : MonoBehaviour
{
	private SteamVR_LaserPointer laserPointer;
	private SteamVR_TrackedController trackedController;

	public float grabRadius;
	public LayerMask grabMask;

	private GameObject grabbedObject;
	private bool grabbing;

	public KeyCode increaseAlpha;
	public KeyCode decreaseAlpha;
	public float alphaLevel = .5f ;


	private void OnEnable()
	{
		laserPointer = GetComponent<SteamVR_LaserPointer>();
		laserPointer.PointerIn -= HandlePointerIn;
		laserPointer.PointerIn += HandlePointerIn;
		laserPointer.PointerOut -= HandlePointerOut;
		laserPointer.PointerOut += HandlePointerOut;

		trackedController = GetComponent<SteamVR_TrackedController>();
		if (trackedController == null)
		{
			trackedController = GetComponentInParent<SteamVR_TrackedController>();
		}
		trackedController.TriggerClicked -= HandleTriggerClicked;
		trackedController.TriggerClicked += HandleTriggerClicked;
	}

//	void GrabObject() {
//		grabbing = true;
//
//		RaycastHit[] hits;
//
//		hits = Physics.SphereCastAll (transform.position, grabRadius, transform.forward, 0f, grabMask);
//
//		if (hits.Length > 0){
//
//			int closestHit = 0;
//
//			for (int i = 0; i < hits.Length; i++) {
//				if (hits[i].distance > hits[closestHit].distance) closestHit = 1; 
//
//			}
//
//			grabbedObject = hits[closestHit].transform.gameObject;
//			grabbedObject.GetComponent<Rigidbody> ().isKinematic = true;
//			grabbedObject.transform.position = transform.position;
//			grabbedObject.transform.parent = transform;
//
//		}}
//
//
//	void DropObject() {
//		grabbing = false;
//
//		if (grabbedObject != null){
//			grabbedObject.transform.parent = null;
//			grabbedObject.GetComponent<Rigidbody> ().isKinematic = true;
//
//			grabbedObject = null;
//
//		}}
//
//	void StretchObject() {
//		grabbedObject.transform.localScale += new Vector3 (0.005F, 0.005F, 0.005F);
//	}
//
//	void ShrinkObject() {
//		grabbedObject.transform.localScale += new Vector3 (-0.005F, -0.005F, -0.005F);
//	}
//
//
//	// Update is called once per frame
//	void Update () {
//		if (!grabbing && Input.GetAxis ("Oculus_GearVR_RIndexTrigger") == 1) GrabObject();
//		if (grabbing && Input.GetAxis ("Oculus_GearVR_RIndexTrigger") < 1) DropObject();
//		if (grabbing && Input.GetAxis ("Oculus_GearVR_LIndexTrigger") == 1) StretchObject();
//		if (grabbing && Input.GetAxis ("LTopTrigger") == 1) ShrinkObject();
//	}
//}

	private void HandleTriggerClicked(object sender, ClickedEventArgs e)
	{
		if (EventSystem.current.currentSelectedGameObject != null)
		{
			ExecuteEvents.Execute(EventSystem.current.currentSelectedGameObject, new PointerEventData(EventSystem.current), ExecuteEvents.submitHandler);
		}

	}

	private void HandlePointerIn(object sender, PointerEventArgs e)
	{
		var button = e.target.GetComponent<Button>();
		if (button != null)
		{
			button.Select();
			Debug.Log("HandlePointerIn", e.target.gameObject);
		}
	}

	private void HandlePointerOut (object sender, PointerEventArgs e)
	{

		var button = e.target.GetComponent<Button> ();
		if (button != null) {
			EventSystem.current.SetSelectedGameObject (null);
			Debug.Log ("HandlePointerOut", e.target.gameObject);
		}
	}
}

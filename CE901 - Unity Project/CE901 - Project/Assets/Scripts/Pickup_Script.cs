using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_Script : MonoBehaviour {

	public float distance = 1.5f;
	public float maxDistance = 2.0f;
	public float minDistance = 1.0f;
	public float rotSpeed = 50.0f;
	public float lerpSmooth;

	public bool carrying;

	GameObject mainCamera;
	Camera mcCamera;
	GameObject carriedObject;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		mcCamera = mainCamera.GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (carrying) {
			carry (carriedObject);
			checkDrop();
			// Mouse Wheel Movement
			if (Input.GetAxis ("Mouse ScrollWheel") > 0f) {
				// Scroll Up
				if (distance < maxDistance) {
					distance += 0.1f;
				}
			} else if (Input.GetAxis ("Mouse ScrollWheel") < 0f) {
				// Scroll Down
				if(distance > minDistance){
					distance -= 0.1f;
				}
			}
			// Rotation
			if (Input.GetKey (KeyCode.Q) && Input.GetMouseButton (0)) {
				// Rotating Y AXIS Positively
				carriedObject.transform.Rotate (Vector3.up * rotSpeed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.Q)) {
				// Rotating X AXIS Positively
				carriedObject.transform.Rotate (Vector3.right * rotSpeed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.R) && Input.GetMouseButton (0)) {
				// Rotating Y AXIS Negatively
				carriedObject.transform.Rotate (-Vector3.up * rotSpeed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.R)) {
				// Rotating X AXIS Negatively
				carriedObject.transform.Rotate (-Vector3.right * rotSpeed * Time.deltaTime);
			} else if(Input.GetKey(KeyCode.F) && Input.GetMouseButton(0)){
				// Rotating Z AXIS Positively
				carriedObject.transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
			} else if(Input.GetKey(KeyCode.F)){
				// Rotating Z AXIS Negatively
				carriedObject.transform.Rotate(-Vector3.forward * rotSpeed * Time.deltaTime);
			}
		} else {
			pickup ();
		}
	}

	void carry(GameObject o){
		rb = o.GetComponent<Rigidbody> ();
		rb.isKinematic = true;
		o.transform.position = Vector3.Lerp(o.transform.position, (mainCamera.transform.position + (transform.up * 0.10f)) + mainCamera.transform.forward * distance, Time.deltaTime * lerpSmooth);
	}

	void checkDrop(){
		if (Input.GetKeyDown (KeyCode.E)) {
			dropObject();
		}
	}

	void dropObject(){
		carrying = false;
		rb.isKinematic = false;
		carriedObject = null;
	}

	void pickup(){
		if(Input.GetKeyDown(KeyCode.E)){
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			Ray ray = mcCamera.ScreenPointToRay (new Vector3 (x, y));
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 2.0f)) {
				Interactable p = hit.collider.GetComponent<Interactable> ();
				if (p != null) {
					carrying = true;
					carriedObject = p.gameObject;
				}
			}
		}
	}
}

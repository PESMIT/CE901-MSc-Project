using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection_Trigger : MonoBehaviour {

	GameObject platformBody1, platformBody2;
	CanvasScript csScript;
	Light platformLight1, platformLight2;
	private bool platform2Exists;
	public bool platform1Chosen, platform2Chosen;

	// Use this for initialization
	void Start () {

		csScript = GameObject.Find ("Player").GetComponent<CanvasScript> ();

		if (GameObject.Find ("Platform_1")!= null) {
			platformBody1 = GameObject.Find ("Platform_1");
			platformLight1 = platformBody1.GetComponentInChildren<Light> ();
			platformLight1.color = Color.blue;
		}
		if (GameObject.Find ("Platform_2")!= null) {
			platformBody2 = GameObject.Find ("Platform_2");
			platformLight2 = platformBody2.GetComponentInChildren<Light> ();
			platformLight2.color = Color.blue;
			platform2Exists = true;
		}
			
	}

	void OnTriggerStay(Collider other){
		if (other.tag == "Objects") {
			if (this.gameObject.name == "Platform_1") {
				platformLight1.color = Color.green;
				platform1Chosen = true;
				if (platform2Exists) {
					platformLight2.color = Color.red;
					platform2Chosen = false;
				}
			} else {
				platformLight1.color = Color.red;
				platform1Chosen = false;
				if (platform2Exists) {
					platformLight2.color = Color.green;
					platform2Chosen = true;
				}
			}
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Objects") {
			csScript.RemoveTeleporterCanvas ();
			platformLight1.color = Color.white;
			platform1Chosen = false;
			if (platform2Exists) {
				platformLight2.color = Color.white;
				platform2Chosen = false;
			}
		}
	}
}

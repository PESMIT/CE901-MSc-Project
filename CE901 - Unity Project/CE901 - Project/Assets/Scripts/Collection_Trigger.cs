using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection_Trigger : MonoBehaviour {

	// ROOM ONE ASSETS
	GameObject platformBody_R1_1, platformBody_R1_2;
	CanvasScript csScript;
	Light platformLight_R1_1, platformLight_R1_2;
	private bool platform2Exists;
	public bool platform1Chosen, platform2Chosen;

	// TODO: ROOM TWO ASSETS

	// Use this for initialization
	void Start () {
		csScript = GameObject.Find ("Player").GetComponent<CanvasScript> ();

		// ROOM ONE ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if (GameObject.Find ("Platform_R1_1")!= null) {
			platformBody_R1_1 = GameObject.Find ("Platform_R1_1");
			platformLight_R1_1 = platformBody_R1_1.GetComponentInChildren<Light> ();
			platformLight_R1_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if (GameObject.Find ("Platform_R1_2")!= null) {
			platformBody_R1_2 = GameObject.Find ("Platform_R1_2");
			platformLight_R1_2 = platformBody_R1_2.GetComponentInChildren<Light> ();
			platformLight_R1_2.color = Color.blue;
			platform2Exists = true;
		}

		// TODO: ROOM TWO ASSET REFERENCE
			
	}

	void OnTriggerStay(Collider other){

		// ROOM ONE - TRIGGER COLLISIONS
		if (other.tag == "Objects") {
			if (this.gameObject.name == "Platform_R1_1") {
				platformLight_R1_1.color = Color.green;
				platform1Chosen = true;
				if (platform2Exists) {
					platformLight_R1_2.color = Color.red;
					platform2Chosen = false;
				}
			} else {
				platformLight_R1_1.color = Color.red;
				platform1Chosen = false;
				if (platform2Exists) {
					platformLight_R1_2.color = Color.green;
					platform2Chosen = true;
				}
			}
		}

		// TODO: ROOM TWO - TRIGGER COLLISIONS
	}

	void OnTriggerExit(Collider other){

		// ROOM ONE - TRIGGER EXITS
		if (other.tag == "Objects") {
			csScript.RemoveTeleporterCanvas ();
			platformLight_R1_1.color = Color.white;
			platform1Chosen = false;
			if (platform2Exists) {
				platformLight_R1_2.color = Color.white;
				platform2Chosen = false;
			}
		}

		// TODO: ROOM TWO - TRIGGER EXITS
	}
}

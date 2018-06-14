using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection_Trigger : MonoBehaviour {

	// GENERIC ASSETS
	CanvasScript csScript;

	// ROOM ONE ASSETS
	GameObject platformBody_R1_1, platformBody_R1_2;
	Light platformLight_R1_1, platformLight_R1_2;
	private bool platform_R1_2_Exists;
	public bool platform_R1_1_Chosen, platform_R1_2_Chosen;

	// ROOM TWO ASSETS
	GameObject platformBody_R2_1, platformBody_R2_2;
	Light platformLight_R2_1, platformLight_R2_2;
	private bool platform_R2_2_Exists;
	public bool platform_R2_1_Chosen, platform_R2_2_Chosen;

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
			platform_R1_2_Exists = true;
		}

		// TODO: ROOM TWO ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R2_1")!= null){
			platformBody_R2_1 = GameObject.Find ("Platform_R2_1");
			platformLight_R2_1 = platformBody_R2_1.GetComponentInChildren<Light> ();
			platformLight_R2_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R2_2")!= null){
			platformBody_R2_2 = GameObject.Find ("Platform_R2_2");
			platformLight_R2_2 = platformBody_R2_2.GetComponentInChildren<Light> ();
			platformLight_R2_2.color = Color.blue;
			platform_R2_2_Exists = true;
		}
			
	}

	void OnTriggerStay(Collider other){

		// ROOM ONE - TRIGGER COLLISIONS
		if (other.tag == "Objects") {
			if (this.gameObject.name == "Platform_R1_1") {
				platformLight_R1_1.color = Color.green;
				platform_R1_1_Chosen = true;
				if (platform_R1_2_Exists) {
					platformLight_R1_2.color = Color.red;
					platform_R1_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R1_2"){
				platformLight_R1_1.color = Color.red;
				platform_R1_1_Chosen = false;
				if (platform_R1_2_Exists) {
					platformLight_R1_2.color = Color.green;
					platform_R1_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM TWO - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R2_1") {
				platformLight_R2_1.color = Color.green;
				platform_R2_1_Chosen = true;
				if (platform_R2_2_Exists) {
					platformLight_R2_2.color = Color.red;
					platform_R2_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R2_2"){
				platformLight_R2_1.color = Color.red;
				platform_R2_1_Chosen = false;
				if (platform_R2_2_Exists) {
					platformLight_R2_2.color = Color.green;
					platform_R2_2_Chosen = true;
				}
			}
		}
	}

	void OnTriggerExit(Collider other){

		// ROOM ONE - TRIGGER EXITS
		if (other.tag == "Objects" && this.gameObject.name == "Platform_R1_1" || this.gameObject.name == "Platform_R1_2") {
			csScript.RemoveTeleporterCanvas ();
			platformLight_R1_1.color = Color.white;
			platform_R1_1_Chosen = false;
			if (platform_R1_2_Exists) {
				platformLight_R1_2.color = Color.white;
				platform_R1_2_Chosen = false;
			}
		}

		// TODO: ROOM TWO - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R2_1" || this.gameObject.name == "Platform_R2_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R2_1.color = Color.white;
			platform_R2_1_Chosen = false;
			if (platform_R2_2_Exists) {
				platformLight_R2_2.color = Color.white;
				platform_R2_2_Chosen = false;
			}
		}
	}
}

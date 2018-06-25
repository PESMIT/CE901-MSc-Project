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

	// ROOM THREE ASSETS
	GameObject platformBody_R3_1, platformBody_R3_2;
	Light platformLight_R3_1, platformLight_R3_2;
	private bool platform_R3_2_Exists;
	public bool platform_R3_1_Chosen, platform_R3_2_Chosen;

	// ROOM FOUR ASSETS
	GameObject platformBody_R4_1, platformBody_R4_2;
	Light platformLight_R4_1, platformLight_R4_2;
	private bool platform_R4_2_Exists;
	public bool platform_R4_1_Chosen, platform_R4_2_Chosen;

	// ROOM FIVE ASSETS
	GameObject platformBody_R5_1, platformBody_R5_2;
	Light platformLight_R5_1, platformLight_R5_2;
	private bool platform_R5_2_Exists;
	public bool platform_R5_1_Chosen, platform_R5_2_Chosen;

	// ROOM SIX ASSETS
	GameObject platformBody_R6_1, platformBody_R6_2;
	Light platformLight_R6_1, platformLight_R6_2;
	private bool platform_R6_2_Exists;
	public bool platform_R6_1_Chosen, platform_R6_2_Chosen;

	// ROOM SEVEN ASSETS
	GameObject platformBody_R7_1, platformBody_R7_2;
	Light platformLight_R7_1, platformLight_R7_2;
	private bool platform_R7_2_Exists;
	public bool platform_R7_1_Chosen, platform_R7_2_Chosen;

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

		// TODO: ROOM THREE ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R3_1")!= null){
			platformBody_R3_1 = GameObject.Find ("Platform_R3_1");
			platformLight_R3_1 = platformBody_R3_1.GetComponentInChildren<Light> ();
			platformLight_R3_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R3_2")!= null){
			platformBody_R3_2 = GameObject.Find ("Platform_R3_2");
			platformLight_R3_2 = platformBody_R3_2.GetComponentInChildren<Light> ();
			platformLight_R3_2.color = Color.blue;
			platform_R3_2_Exists = true;
		}

		// TODO: ROOM FOUR ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R4_1")!= null){
			platformBody_R4_1 = GameObject.Find ("Platform_R4_1");
			platformLight_R4_1 = platformBody_R4_1.GetComponentInChildren<Light> ();
			platformLight_R4_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R4_2")!= null){
			platformBody_R4_2 = GameObject.Find ("Platform_R4_2");
			platformLight_R4_2 = platformBody_R4_2.GetComponentInChildren<Light> ();
			platformLight_R4_2.color = Color.blue;
			platform_R4_2_Exists = true;
		}

		// TODO: ROOM FIVE ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R5_1")!= null){
			platformBody_R5_1 = GameObject.Find ("Platform_R5_1");
			platformLight_R5_1 = platformBody_R5_1.GetComponentInChildren<Light> ();
			platformLight_R5_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R5_2")!= null){
			platformBody_R5_2 = GameObject.Find ("Platform_R5_2");
			platformLight_R5_2 = platformBody_R5_2.GetComponentInChildren<Light> ();
			platformLight_R5_2.color = Color.blue;
			platform_R5_2_Exists = true;
		}
		// TODO: ROOM SIX ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R6_1")!= null){
			platformBody_R6_1 = GameObject.Find ("Platform_R6_1");
			platformLight_R6_1 = platformBody_R6_1.GetComponentInChildren<Light> ();
			platformLight_R6_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R6_2")!= null){
			platformBody_R6_2 = GameObject.Find ("Platform_R6_2");
			platformLight_R6_2 = platformBody_R6_2.GetComponentInChildren<Light> ();
			platformLight_R6_2.color = Color.blue;
			platform_R6_2_Exists = true;
		}
		// TODO: ROOM SEVEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R7_1")!= null){
			platformBody_R7_1 = GameObject.Find ("Platform_R7_1");
			platformLight_R7_1 = platformBody_R7_1.GetComponentInChildren<Light> ();
			platformLight_R7_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R7_2")!= null){
			platformBody_R7_2 = GameObject.Find ("Platform_R7_2");
			platformLight_R7_2 = platformBody_R7_2.GetComponentInChildren<Light> ();
			platformLight_R7_2.color = Color.blue;
			platform_R7_2_Exists = true;
		}

			
	}

	void OnTriggerStay(Collider other){

		// ROOM ONE - TRIGGER COLLISIONS
		if (other.tag == "Objects") {
			if (this.gameObject.name == "Platform_R1_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R1_1.color = Color.green;
				platform_R1_1_Chosen = true;
				if (platform_R1_2_Exists) {
					platformLight_R1_2.color = Color.red;
					platform_R1_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R1_2"){
				csScript.RemoveTutorialOne ();
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
				csScript.RemoveTutorialOne ();
				platformLight_R2_1.color = Color.green;
				platform_R2_1_Chosen = true;
				if (platform_R2_2_Exists) {
					platformLight_R2_2.color = Color.red;
					platform_R2_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R2_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R2_1.color = Color.red;
				platform_R2_1_Chosen = false;
				if (platform_R2_2_Exists) {
					platformLight_R2_2.color = Color.green;
					platform_R2_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM THREE - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R3_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R3_1.color = Color.green;
				platform_R3_1_Chosen = true;
				if (platform_R3_2_Exists) {
					platformLight_R3_2.color = Color.red;
					platform_R3_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R3_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R3_1.color = Color.red;
				platform_R3_1_Chosen = false;
				if (platform_R3_2_Exists) {
					platformLight_R3_2.color = Color.green;
					platform_R3_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM FOUR - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R4_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R4_1.color = Color.green;
				platform_R4_1_Chosen = true;
				if (platform_R4_2_Exists) {
					platformLight_R4_2.color = Color.red;
					platform_R4_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R4_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R4_1.color = Color.red;
				platform_R4_1_Chosen = false;
				if (platform_R4_2_Exists) {
					platformLight_R4_2.color = Color.green;
					platform_R4_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM FIVE - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R5_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R5_1.color = Color.green;
				platform_R5_1_Chosen = true;
				if (platform_R5_2_Exists) {
					platformLight_R5_2.color = Color.red;
					platform_R5_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R5_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R5_1.color = Color.red;
				platform_R5_1_Chosen = false;
				if (platform_R5_2_Exists) {
					platformLight_R5_2.color = Color.green;
					platform_R5_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM SIX - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R6_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R6_1.color = Color.green;
				platform_R6_1_Chosen = true;
				if (platform_R6_2_Exists) {
					platformLight_R6_2.color = Color.red;
					platform_R6_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R6_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R6_1.color = Color.red;
				platform_R6_1_Chosen = false;
				if (platform_R6_2_Exists) {
					platformLight_R6_2.color = Color.green;
					platform_R6_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM SEVEN - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R7_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R7_1.color = Color.green;
				platform_R7_1_Chosen = true;
				if (platform_R7_2_Exists) {
					platformLight_R7_2.color = Color.red;
					platform_R7_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R7_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R7_1.color = Color.red;
				platform_R7_1_Chosen = false;
				if (platform_R7_2_Exists) {
					platformLight_R7_2.color = Color.green;
					platform_R7_2_Chosen = true;
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

		// TODO: ROOM THREE - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R3_1" || this.gameObject.name == "Platform_R3_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R3_1.color = Color.white;
			platform_R3_1_Chosen = false;
			if (platform_R3_2_Exists) {
				platformLight_R3_2.color = Color.white;
				platform_R3_2_Chosen = false;
			}
		}

		// TODO: ROOM FOUR - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R4_1" || this.gameObject.name == "Platform_R4_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R4_1.color = Color.white;
			platform_R4_1_Chosen = false;
			if (platform_R4_2_Exists) {
				platformLight_R4_2.color = Color.white;
				platform_R4_2_Chosen = false;
			}
		}

		// TODO: ROOM FIVE - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R5_1" || this.gameObject.name == "Platform_R5_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R5_1.color = Color.white;
			platform_R5_1_Chosen = false;
			if (platform_R5_2_Exists) {
				platformLight_R5_2.color = Color.white;
				platform_R5_2_Chosen = false;
			}
		}

		// TODO: ROOM SIX - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R6_1" || this.gameObject.name == "Platform_R6_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R6_1.color = Color.white;
			platform_R6_1_Chosen = false;
			if (platform_R6_2_Exists) {
				platformLight_R6_2.color = Color.white;
				platform_R6_2_Chosen = false;
			}
		}

		// TODO: ROOM SEVEN - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R7_1" || this.gameObject.name == "Platform_R7_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R7_1.color = Color.white;
			platform_R7_1_Chosen = false;
			if (platform_R7_2_Exists) {
				platformLight_R7_2.color = Color.white;
				platform_R7_2_Chosen = false;
			}
		}
	}
}

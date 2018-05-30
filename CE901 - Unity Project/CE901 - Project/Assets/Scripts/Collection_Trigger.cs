using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection_Trigger : MonoBehaviour {

	GameObject lightBodyOrange, lightBodyRed;
	Light cLightOrange, cLightRed;

	// Use this for initialization
	void Start () {
		lightBodyOrange = GameObject.Find ("Orange_Platform_Light");
		cLightOrange = lightBodyOrange.GetComponent<Light> ();

		lightBodyRed = GameObject.Find ("Red_Platform_Light");
		cLightRed = lightBodyRed.GetComponent<Light> ();

		print ("I have found the game object");
		cLightOrange.color = Color.blue;
		cLightRed.color = Color.blue;
	}

	void OnTriggerStay(Collider other){
		if (other.tag == "Objects") {
			if (this.gameObject.name == "Orange_Platform") {
				cLightOrange.color = Color.green;
				cLightRed.color = Color.red;
			} else {
				cLightOrange.color = Color.red;
				cLightRed.color = Color.green;
			}
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Objects") {
			cLightOrange.color = Color.white;
			cLightRed.color = Color.white;
		}
	}
}

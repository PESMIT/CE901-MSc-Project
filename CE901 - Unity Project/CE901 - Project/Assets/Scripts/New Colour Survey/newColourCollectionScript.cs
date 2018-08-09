using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newColourCollectionScript : MonoBehaviour {

	GameObject optionPad1, optionPad2;
	Light optionPad1Light, optionPad2Light;
	GameObject cube;
	Rigidbody cubeRB;

	public bool optionPad1_Chosen, optionPad2_Chosen;

	newColourGameManager ncGM;

	// Use this for initialization
	void Start () {
		optionPad1 = GameObject.Find ("Option Pad 1");
		optionPad2 = GameObject.Find ("Option Pad 2");
		optionPad1Light = optionPad1.GetComponentInChildren<Light> ();
		optionPad2Light = optionPad2.GetComponentInChildren<Light> ();
		optionPad1_Chosen = false;
		optionPad2_Chosen = false;

		cube = GameObject.Find ("Cube");
		cubeRB = cube.GetComponent<Rigidbody> ();
	}

	void OnTriggerStay(Collider other){
		if (other.name == "Cube") {
			if (this.name == "Option Pad 1") {
				optionPad1Light.color = Color.green;
				optionPad2Light.color = Color.white;
				optionPad1_Chosen = true;
				optionPad2_Chosen = false;
			} else if (this.name == "Option Pad 2") {
				optionPad1Light.color = Color.white;
				optionPad2Light.color = Color.green;
				optionPad1_Chosen = false;
				optionPad2_Chosen = true;
			}
		}
	}

	void OnTriggerExit(Collider other){
		optionPad1Light.color = Color.white;
		optionPad2Light.color = Color.white;
		optionPad1_Chosen = false;
		optionPad2_Chosen = false;
	}

	public void resetPads(){
		cube.transform.position = new Vector3 (0, 1, 4);
		cubeRB.velocity = new Vector3 (0, 0, 0);
		optionPad1_Chosen = false;
		optionPad2_Chosen = false;
		optionPad1Light.color = Color.white;
		optionPad2Light.color = Color.white;
	}
}

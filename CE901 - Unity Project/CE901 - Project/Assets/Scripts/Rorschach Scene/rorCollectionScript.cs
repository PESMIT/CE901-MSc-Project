using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rorCollectionScript : MonoBehaviour {

	GameObject optionPad1, optionPad2, optionPad3, optionPad4;
	Light optionPad1Light, optionPad2Light, optionPad3Light, optionPad4Light;
	GameObject cube;
	Rigidbody cubeRB;

	public bool optionPad1_Chosen, optionPad2_Chosen, optionPad3_Chosen, optionPad4_Chosen;

	rorGameManager rorGM;

	// Use this for initialization
	void Start () {
		optionPad1 = GameObject.Find ("Option Pad 1");
		optionPad2 = GameObject.Find ("Option Pad 2");
		optionPad3 = GameObject.Find ("Option Pad 3");
		optionPad4 = GameObject.Find ("Option Pad 4");

		optionPad1Light = optionPad1.GetComponentInChildren<Light> ();
		optionPad2Light = optionPad2.GetComponentInChildren<Light> ();
		optionPad3Light = optionPad3.GetComponentInChildren<Light> ();
		optionPad4Light = optionPad4.GetComponentInChildren<Light> ();


		cube = GameObject.Find ("Cube");
		cubeRB = cube.GetComponent<Rigidbody> ();

		optionPad1_Chosen = false;
		optionPad2_Chosen = false;
		optionPad3_Chosen = false;
		optionPad4_Chosen = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other)
	{
		if (other.name == "Cube") {
			if (this.name == "Option Pad 1") {
				optionPad1Light.color = Color.green;
				optionPad2Light.color = Color.white;
				optionPad3Light.color = Color.white;
				optionPad4Light.color = Color.white;

				optionPad1_Chosen = true;
				optionPad2_Chosen = false;
				optionPad3_Chosen = false;
				optionPad4_Chosen = false;

			} else if (this.name == "Option Pad 2") {
				optionPad1Light.color = Color.white;
				optionPad2Light.color = Color.green;
				optionPad3Light.color = Color.white;
				optionPad4Light.color = Color.white;

				optionPad1_Chosen = false;
				optionPad2_Chosen = true;
				optionPad3_Chosen = false;
				optionPad4_Chosen = false;

			} else if (this.name == "Option Pad 3") {
				optionPad1Light.color = Color.white;
				optionPad2Light.color = Color.white;
				optionPad3Light.color = Color.green;
				optionPad4Light.color = Color.white;

				optionPad1_Chosen = false;
				optionPad2_Chosen = false;
				optionPad3_Chosen = true;
				optionPad4_Chosen = false;

			} else if (this.name == "Option Pad 4") {
				optionPad1Light.color = Color.white;
				optionPad2Light.color = Color.white;
				optionPad3Light.color = Color.white;
				optionPad4Light.color = Color.green;

				optionPad1_Chosen = false;
				optionPad2_Chosen = false;
				optionPad3_Chosen = false;
				optionPad4_Chosen = true;

			}
		}
	}

	void OnTriggerExit(Collider other){
		optionPad1Light.color = Color.white;
		optionPad2Light.color = Color.white;
		optionPad3Light.color = Color.white;
		optionPad4Light.color = Color.white;

		optionPad1_Chosen = false;
		optionPad2_Chosen = false;
		optionPad3_Chosen = false;
		optionPad4_Chosen = false;
	}

	public void resetPads()
	{
		cube.transform.position = new Vector3 (0, 1, 0);
		cubeRB.velocity = new Vector3 (0, 0, 0);

		optionPad1_Chosen = false;
		optionPad2_Chosen = false;
		optionPad3_Chosen = false;
		optionPad4_Chosen = false;

		optionPad1Light.color = Color.white;
		optionPad2Light.color = Color.white;
		optionPad3Light.color = Color.white;
		optionPad4Light.color = Color.white;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter_Script : MonoBehaviour {

	// Room One Assets
	GameObject platform_R1_1, platform_R1_2, teleporterPad_R1_1, sphere_R1_1;
	Collection_Trigger choice1, choice2;

	// Room Two Assets
	GameObject platform_R2_1, platform_R2_2, teleporter_R2_1, sphere_R2_1;

	// Generic Assets
	GameObject player;
	CanvasScript playerCS;
	Material m_Material;

	// Use this for initialization
	void Start () {
		playerCS = GameObject.Find ("Player").GetComponent<CanvasScript> ();
		player = GameObject.Find ("Player");

		// Room One Assets
		platform_R1_1 = GameObject.Find ("Platform_R1_1");
		platform_R1_2 = GameObject.Find ("Platform_R1_2");
		teleporterPad_R1_1 = GameObject.Find ("TelePad_R1_1");
		sphere_R1_1 = GameObject.Find ("Sphere_R1_1");
		choice1 = platform_R1_1.GetComponent<Collection_Trigger> ();
		choice2 = platform_R1_2.GetComponent<Collection_Trigger> ();

		// Room Two Assets
		platform_R2_1 = GameObject.Find("Platform_R2_1");
		platform_R2_2 = GameObject.Find("Platform_R2_2");


		m_Material = GetComponent<Renderer> ().material;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Room One Assets - Material Updates
		if (choice1.platform1Chosen || choice1.platform2Chosen || choice2.platform1Chosen || choice2.platform2Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
		}

		if (choice1.platform1Chosen || choice1.platform2Chosen || choice2.platform1Chosen || choice2.platform2Chosen) {
			m_Material.color = Color.green;
		} 
		else {m_Material.color = Color.black;}

		// TODO: Room Two Assets - Material Updates
	}

	void OnTriggerEnter(Collider other){

		// Room One Assets - Collision with Player Hitbox

		if (choice1.platform1Chosen && !choice2.platform2Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform 1 Chosen - Now Teleporting");
				player.transform.position = teleporterPad_R1_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R1_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R1_1, 0.1f);
			}
		}
		else if (!choice1.platform1Chosen && choice2.platform2Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform 2 Chosen - Now Teleporting");
				player.transform.position = teleporterPad_R1_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R1_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R1_1, 0.1f);
			}
		}
		else if(other.name == "Player_Position"){
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}


		// TODO : Room Two Assets - Collision with Player Hitbox

	}
}

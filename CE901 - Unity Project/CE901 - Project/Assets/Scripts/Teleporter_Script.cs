using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter_Script : MonoBehaviour {

	// Room One Assets
	GameObject platform_R1_1, platform_R1_2,teleporterPad_R1_1, sphere_R1_1;
	Collection_Trigger choice_R1_1, choice_R1_2;
	bool tele_R1;

	// Room Two Assets
	GameObject platform_R2_1, platform_R2_2,teleporterPad_R2_1, sphere_R2_1;
	Collection_Trigger choice_R2_1, choice_R2_2;
	bool tele_R2;

	// Room Three Assets
	GameObject platform_R3_1, platform_R3_2,teleporterPad_R3_1, sphere_R3_1;
	Collection_Trigger choice_R3_1, choice_R3_2;
	bool tele_R3;

	// Generic Assets
	GameObject player;
	CanvasScript playerCS;
	Material teleMaterial_R1_1;
	Material teleMaterial_R2_1;
	Material teleMaterial_R3_1;

	// Use this for initialization
	void Start () {
		playerCS = GameObject.Find ("Player").GetComponent<CanvasScript> ();
		player = GameObject.Find ("Player");

		// Room One Assets
		platform_R1_1 = GameObject.Find ("Platform_R1_1");
		platform_R1_2 = GameObject.Find ("Platform_R1_2");
		teleporterPad_R1_1 = GameObject.Find ("TelePad_R1_1");
		sphere_R1_1 = GameObject.Find ("Sphere_R1_1");
		choice_R1_1 = platform_R1_1.GetComponent<Collection_Trigger> ();
		choice_R1_2 = platform_R1_2.GetComponent<Collection_Trigger> ();

		// Room One Teleporter Materia
		teleMaterial_R1_1 = GameObject.Find("Teleporter_R1_1").GetComponent<Renderer> ().material;

		// Room Two Assets
		platform_R2_1 = GameObject.Find("Platform_R2_1");
		platform_R2_2 = GameObject.Find("Platform_R2_2");
		teleporterPad_R2_1 = GameObject.Find ("TelePad_R2_1");
		sphere_R2_1 = GameObject.Find ("Sphere_R2_1");
		choice_R2_1 = platform_R2_1.GetComponent<Collection_Trigger> ();
		choice_R2_2 = platform_R2_2.GetComponent<Collection_Trigger> ();

		// Room Two Teleporter Materia
		teleMaterial_R2_1 = GameObject.Find("Teleporter_R2_1").GetComponent<Renderer> ().material;

		// Room Three Assets
		platform_R3_1 = GameObject.Find("Platform_R3_1");
		platform_R3_2 = GameObject.Find("Platform_R3_2");
		teleporterPad_R3_1 = GameObject.Find ("TelePad_R3_1");
		sphere_R3_1 = GameObject.Find ("Sphere_R3_1");
		choice_R3_1 = platform_R3_1.GetComponent<Collection_Trigger> ();
		choice_R3_2 = platform_R3_2.GetComponent<Collection_Trigger> ();

		// Room Three Teleporter Materia
		teleMaterial_R3_1 = GameObject.Find("Teleporter_R3_1").GetComponent<Renderer> ().material;



	}
	
	// Update is called once per frame
	void Update () 
	{
		// Room One Assets - Material Updates
		if (choice_R1_1.platform_R1_1_Chosen || choice_R1_1.platform_R1_2_Chosen || choice_R1_2.platform_R1_1_Chosen || choice_R1_2.platform_R1_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R1_1.color = Color.green;
		}
		else {teleMaterial_R1_1.color = Color.black;}

		// TODO: Room Two Assets - Material Updates
		if(choice_R2_1.platform_R2_1_Chosen || choice_R2_1.platform_R2_2_Chosen || choice_R2_2.platform_R2_1_Chosen || choice_R2_2.platform_R2_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R2_1.color = Color.green;
		} 
		else {teleMaterial_R2_1.color = Color.black;}

		// TODO: Room Three Assets - Material Updates
		if(choice_R3_1.platform_R3_1_Chosen || choice_R3_1.platform_R3_2_Chosen || choice_R3_2.platform_R3_1_Chosen || choice_R3_2.platform_R3_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R3_1.color = Color.green;
		} 
		else {teleMaterial_R3_1.color = Color.black;}
	}

	void OnTriggerEnter(Collider other){

		// Room One Assets - Collision with Player Hitbox
		if (choice_R1_1.platform_R1_1_Chosen && !choice_R1_2.platform_R1_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R1_1 Chosen - Now Teleporting");
				player.transform.position = teleporterPad_R1_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R1_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R1_1, 0.1f);
			}
		}
		else if (!choice_R1_1.platform_R1_1_Chosen && choice_R1_2.platform_R1_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R1_2 Chosen - Now Teleporting");
				player.transform.position = teleporterPad_R1_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
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
		if (choice_R2_1.platform_R2_1_Chosen && !choice_R2_2.platform_R2_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R2_1 Chosen - Now Teleporting");
				player.transform.position = teleporterPad_R2_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R2_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R2_1, 0.1f);
			}
		} else if (!choice_R2_1.platform_R2_1_Chosen && choice_R2_2.platform_R2_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R2_2 Chosen - Now Teleporting");
				player.transform.position = teleporterPad_R2_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R2_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R2_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room Three Assets - Collision with Player Hitbox
		if (choice_R3_1.platform_R3_1_Chosen && !choice_R3_2.platform_R3_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R3_1 Chosen - Now Teleporting");
				SceneManager.LoadSceneAsync ("MainMenu");
//				player.transform.position = teleporterPad_R3_1.transform.position;
//				playerCS.RemoveTeleporterCanvas ();
//				playerCS.DisplayChoiceText ();
//				sphere_R3_1.transform.position = Vector3.zero;
//				Object.Destroy (sphere_R3_1, 0.1f);
			}
		} else if (!choice_R3_1.platform_R3_1_Chosen && choice_R3_2.platform_R3_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R3_2 Chosen - Now Teleporting");
				SceneManager.LoadSceneAsync ("MainMenu");
//				player.transform.position = teleporterPad_R3_1.transform.position;
//				playerCS.RemoveTeleporterCanvas ();
//				playerCS.DisplayChoiceText ();
//				sphere_R3_1.transform.position = Vector3.zero;
//				Object.Destroy (sphere_R3_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}
	}
}

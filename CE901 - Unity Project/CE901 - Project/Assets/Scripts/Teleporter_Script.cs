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

	// Room Four Assets
	GameObject platform_R4_1, platform_R4_2,teleporterPad_R4_1, sphere_R4_1;
	Collection_Trigger choice_R4_1, choice_R4_2;
	bool tele_R4;

	// Room Five Assets
	GameObject platform_R5_1, platform_R5_2,teleporterPad_R5_1, sphere_R5_1;
	Collection_Trigger choice_R5_1, choice_R5_2;
	bool tele_R5;

	// Room Six Assets
	GameObject platform_R6_1, platform_R6_2,teleporterPad_R6_1, sphere_R6_1;
	Collection_Trigger choice_R6_1, choice_R6_2;
	bool tele_R6;

	// Room Seven Assets
	GameObject platform_R7_1, platform_R7_2,teleporterPad_R7_1, sphere_R7_1;
	Collection_Trigger choice_R7_1, choice_R7_2;
	bool tele_R7;

	// Generic Assets
	GameObject player;
	CanvasScript playerCS;
	Choice_Tracker playerCT;
	Material teleMaterial_R1_1;
	Material teleMaterial_R2_1;
	Material teleMaterial_R3_1;
	Material teleMaterial_R4_1;
	Material teleMaterial_R5_1;
	Material teleMaterial_R6_1;
	Material teleMaterial_R7_1;

	// Use this for initialization
	void Start () {
		playerCS = GameObject.Find ("Player").GetComponent<CanvasScript> ();
		playerCT = GameObject.Find ("Player").GetComponent<Choice_Tracker> ();
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

		// Room Four Assets
		platform_R4_1 = GameObject.Find("Platform_R4_1");
		platform_R4_2 = GameObject.Find("Platform_R4_2");
		teleporterPad_R4_1 = GameObject.Find ("TelePad_R4_1");
		sphere_R4_1 = GameObject.Find ("Sphere_R4_1");
		choice_R4_1 = platform_R4_1.GetComponent<Collection_Trigger> ();
		choice_R4_2 = platform_R4_2.GetComponent<Collection_Trigger> ();

		// Room Four Teleporter Materia
		teleMaterial_R4_1 = GameObject.Find("Teleporter_R4_1").GetComponent<Renderer> ().material;

		// Room Five Assets
		platform_R5_1 = GameObject.Find("Platform_R5_1");
		platform_R5_2 = GameObject.Find("Platform_R5_2");
		teleporterPad_R5_1 = GameObject.Find ("TelePad_R5_1");
		sphere_R5_1 = GameObject.Find ("Sphere_R5_1");
		choice_R5_1 = platform_R5_1.GetComponent<Collection_Trigger> ();
		choice_R5_2 = platform_R5_2.GetComponent<Collection_Trigger> ();

		// Room Five Teleporter Materia
		teleMaterial_R5_1 = GameObject.Find("Teleporter_R5_1").GetComponent<Renderer> ().material;

		// Room Six Assets
		platform_R6_1 = GameObject.Find("Platform_R6_1");
		platform_R6_2 = GameObject.Find("Platform_R6_2");
		teleporterPad_R6_1 = GameObject.Find ("TelePad_R6_1");
		sphere_R6_1 = GameObject.Find ("Sphere_R6_1");
		choice_R6_1 = platform_R6_1.GetComponent<Collection_Trigger> ();
		choice_R6_2 = platform_R6_2.GetComponent<Collection_Trigger> ();

		// Room Six Teleporter Materia
		teleMaterial_R6_1 = GameObject.Find("Teleporter_R6_1").GetComponent<Renderer> ().material;

		// Room Seven Assets
		platform_R7_1 = GameObject.Find("Platform_R7_1");
		platform_R7_2 = GameObject.Find("Platform_R7_2");
		teleporterPad_R7_1 = GameObject.Find ("TelePad_R7_1");
		sphere_R7_1 = GameObject.Find ("Sphere_R7_1");
		choice_R7_1 = platform_R7_1.GetComponent<Collection_Trigger> ();
		choice_R7_2 = platform_R7_2.GetComponent<Collection_Trigger> ();

		// Room Seven Teleporter Materia
		teleMaterial_R7_1 = GameObject.Find("Teleporter_R7_1").GetComponent<Renderer> ().material;



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

		// TODO: Room Four Assets - Material Updates
		if(choice_R4_1.platform_R4_1_Chosen || choice_R4_1.platform_R4_2_Chosen || choice_R4_2.platform_R4_1_Chosen || choice_R4_2.platform_R4_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R4_1.color = Color.green;
		} 
		else {teleMaterial_R4_1.color = Color.black;}

		// TODO: Room Five Assets - Material Updates
		if(choice_R5_1.platform_R5_1_Chosen || choice_R5_1.platform_R5_2_Chosen || choice_R5_2.platform_R5_1_Chosen || choice_R5_2.platform_R5_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R5_1.color = Color.green;
		} 
		else {teleMaterial_R5_1.color = Color.black;}

		// TODO: Room Six Assets - Material Updates
		if(choice_R6_1.platform_R6_1_Chosen || choice_R6_1.platform_R6_2_Chosen || choice_R6_2.platform_R6_1_Chosen || choice_R6_2.platform_R6_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R6_1.color = Color.green;
		} 
		else {teleMaterial_R6_1.color = Color.black;}

		// TODO: Room Seven Assets - Material Updates
		if(choice_R7_1.platform_R7_1_Chosen || choice_R7_1.platform_R7_2_Chosen || choice_R7_2.platform_R7_1_Chosen || choice_R7_2.platform_R7_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R7_1.color = Color.green;
		} 
		else {teleMaterial_R7_1.color = Color.black;}
	}

	void OnTriggerEnter(Collider other){

		// Room One Assets - Collision with Player Hitbox
		if (choice_R1_1.platform_R1_1_Chosen && !choice_R1_2.platform_R1_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R1_1 Chosen - Now Teleporting");
				playerCT.R1_Choice_1_Taken = true;
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
				playerCT.R1_Choice_2_Taken = true;
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
				playerCT.R2_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R2_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R2_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R2_1, 0.1f);
			}
		} else if (!choice_R2_1.platform_R2_1_Chosen && choice_R2_2.platform_R2_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R2_2 Chosen - Now Teleporting");
				playerCT.R2_Choice_2_Taken = true;
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
				playerCT.R3_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R3_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R3_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R3_1, 0.1f);
			}
		} else if (!choice_R3_1.platform_R3_1_Chosen && choice_R3_2.platform_R3_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R3_2 Chosen - Now Teleporting");
				playerCT.R3_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R3_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R3_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R3_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room Four Assets - Collision with Player Hitbox
		if (choice_R4_1.platform_R4_1_Chosen && !choice_R4_2.platform_R4_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R4_1 Chosen - Now Teleporting");
				playerCT.R4_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R4_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R4_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R4_1, 0.1f);
			}
		} else if (!choice_R4_1.platform_R4_1_Chosen && choice_R4_2.platform_R4_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R4_2 Chosen - Now Teleporting");
				playerCT.R4_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R4_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R4_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R4_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room Five Assets - Collision with Player Hitbox
		if (choice_R5_1.platform_R5_1_Chosen && !choice_R5_2.platform_R5_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R5_1 Chosen - Now Teleporting");
				playerCT.R5_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R5_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R5_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R5_1, 0.1f);
			}
		} else if (!choice_R5_1.platform_R5_1_Chosen && choice_R5_2.platform_R5_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R5_2 Chosen - Now Teleporting");
				playerCT.R5_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R5_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R5_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R5_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room Six Assets - Collision with Player Hitbox
		if (choice_R6_1.platform_R6_1_Chosen && !choice_R6_2.platform_R6_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R6_1 Chosen - Now Teleporting");
				playerCT.R6_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R6_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R6_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R6_1, 0.1f);
			}
		} else if (!choice_R6_1.platform_R6_1_Chosen && choice_R6_2.platform_R6_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R6_2 Chosen - Now Teleporting");
				playerCT.R6_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R6_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R6_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R6_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room Seven Assets - Collision with Player Hitbox
		if (choice_R7_1.platform_R7_1_Chosen && !choice_R7_2.platform_R7_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R7_1 Chosen - Now Teleporting");
				playerCT.R7_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R7_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R7_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R7_1, 0.1f);
			}
		} else if (!choice_R7_1.platform_R7_1_Chosen && choice_R7_2.platform_R7_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R7_2 Chosen - Now Teleporting");
				playerCT.R7_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R7_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCS.DisplayChoiceText ();
				sphere_R7_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R7_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}
	}
}

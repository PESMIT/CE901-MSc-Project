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

	// Room EIGHT Assets
	GameObject platform_R8_1, platform_R8_2,teleporterPad_R8_1, sphere_R8_1;
	Collection_Trigger choice_R8_1, choice_R8_2;
	bool tele_R8;

	// Room NINE Assets
	GameObject platform_R9_1, platform_R9_2,teleporterPad_R9_1, sphere_R9_1;
	Collection_Trigger choice_R9_1, choice_R9_2;
	bool tele_R9;

	// Room TEN Assets
	GameObject platform_R10_1, platform_R10_2,teleporterPad_R10_1, sphere_R10_1;
	Collection_Trigger choice_R10_1, choice_R10_2;
	bool tele_R10;

	// ROOMS 11-20 - TOWER OF ROOMS
	// Room ELEVEN Assets
	GameObject platform_R11_1, platform_R11_2,teleporterPad_R11_1, sphere_R11_1;
	Collection_Trigger choice_R11_1, choice_R11_2;
	bool tele_R11;

	// Room TWELVE Assets
	GameObject platform_R12_1, platform_R12_2,teleporterPad_R12_1, sphere_R12_1;
	Collection_Trigger choice_R12_1, choice_R12_2;
	bool tele_R12;

	// Room THIRTEEN Assets
	GameObject platform_R13_1, platform_R13_2,teleporterPad_R13_1, sphere_R13_1;
	Collection_Trigger choice_R13_1, choice_R13_2;
	bool tele_R13;

	// Room FOURTEEN Assets
	GameObject platform_R14_1, platform_R14_2,teleporterPad_R14_1, sphere_R14_1;
	Collection_Trigger choice_R14_1, choice_R14_2;
	bool tele_R14;

	// Room FIFTHTEEN Assets
	GameObject platform_R15_1, platform_R15_2,teleporterPad_R15_1, sphere_R15_1;
	Collection_Trigger choice_R15_1, choice_R15_2;
	bool tele_R15;

	// Room SIXTEEN Assets
	GameObject platform_R16_1, platform_R16_2,teleporterPad_R16_1, sphere_R16_1;
	Collection_Trigger choice_R16_1, choice_R16_2;
	bool tele_R16;

	// Room SEVENTEEN Assets
	GameObject platform_R17_1, platform_R17_2,teleporterPad_R17_1, sphere_R17_1;
	Collection_Trigger choice_R17_1, choice_R17_2;
	bool tele_R17;

	// Room EIGHTEEN Assets
	GameObject platform_R18_1, platform_R18_2,teleporterPad_R18_1, sphere_R18_1;
	Collection_Trigger choice_R18_1, choice_R18_2;
	bool tele_R18;

	// Room NINETEEN Assets
	GameObject platform_R19_1, platform_R19_2,teleporterPad_R19_1, sphere_R19_1;
	Collection_Trigger choice_R19_1, choice_R19_2;
	bool tele_R19;

	// Room TWENTY Assets
	GameObject platform_R20_1, platform_R20_2,teleporterPad_R20_1, sphere_R20_1;
	Collection_Trigger choice_R20_1, choice_R20_2;
	bool tele_R20;

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
	Material teleMaterial_R8_1;
	Material teleMaterial_R9_1;
	Material teleMaterial_R10_1;

	// ROOMS 11-20 - TOWER OF ROOMS
	Material teleMaterial_R11_1;
	Material teleMaterial_R12_1;
	Material teleMaterial_R13_1;
	Material teleMaterial_R14_1;
	Material teleMaterial_R15_1;
	Material teleMaterial_R16_1;
	Material teleMaterial_R17_1;
	Material teleMaterial_R18_1;
	Material teleMaterial_R19_1;
	Material teleMaterial_R20_1;

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

		// Room Eight Assets
		platform_R8_1 = GameObject.Find("Platform_R8_1");
		platform_R8_2 = GameObject.Find("Platform_R8_2");
		teleporterPad_R8_1 = GameObject.Find ("TelePad_R8_1");
		sphere_R8_1 = GameObject.Find ("Sphere_R8_1");
		choice_R8_1 = platform_R8_1.GetComponent<Collection_Trigger> ();
		choice_R8_2 = platform_R8_2.GetComponent<Collection_Trigger> ();

		// Room Eight Teleporter Materia
		teleMaterial_R8_1 = GameObject.Find("Teleporter_R8_1").GetComponent<Renderer> ().material;

		// Room Nine Assets
		platform_R9_1 = GameObject.Find("Platform_R9_1");
		platform_R9_2 = GameObject.Find("Platform_R9_2");
		teleporterPad_R9_1 = GameObject.Find ("TelePad_R9_1");
		sphere_R9_1 = GameObject.Find ("Sphere_R9_1");
		choice_R9_1 = platform_R9_1.GetComponent<Collection_Trigger> ();
		choice_R9_2 = platform_R9_2.GetComponent<Collection_Trigger> ();

		// Room Nine Teleporter Material
		teleMaterial_R9_1 = GameObject.Find("Teleporter_R9_1").GetComponent<Renderer> ().material;

		// Room TEN Assets
		platform_R10_1 = GameObject.Find("Platform_R10_1");
		platform_R10_2 = GameObject.Find("Platform_R10_2");
		teleporterPad_R10_1 = GameObject.Find ("TelePad_R10_1");
		sphere_R10_1 = GameObject.Find ("Sphere_R10_1");
		choice_R10_1 = platform_R10_1.GetComponent<Collection_Trigger> ();
		choice_R10_2 = platform_R10_2.GetComponent<Collection_Trigger> ();

		// Room TEN Teleporter Material
		teleMaterial_R10_1 = GameObject.Find("Teleporter_R10_1").GetComponent<Renderer> ().material;

		// ROOMS 11-20 - TOWER OF ROOMS
		// Room ELEVEN Assets
		platform_R11_1 = GameObject.Find ("Platform_R11_1");
		platform_R11_2 = GameObject.Find ("Platform_R11_2");
		teleporterPad_R11_1 = GameObject.Find ("TelePad_R11_1");
		sphere_R11_1 = GameObject.Find ("Sphere_R11_1");
		choice_R11_1 = platform_R11_1.GetComponent<Collection_Trigger> ();
		choice_R11_2 = platform_R11_2.GetComponent<Collection_Trigger> ();

		// Room ELEVEN Teleporter Materia
		teleMaterial_R11_1 = GameObject.Find("Teleporter_R11_1").GetComponent<Renderer> ().material;

		// Room TWELVE Assets
		platform_R12_1 = GameObject.Find("Platform_R12_1");
		platform_R12_2 = GameObject.Find("Platform_R12_2");
		teleporterPad_R12_1 = GameObject.Find ("TelePad_R12_1");
		sphere_R12_1 = GameObject.Find ("Sphere_R12_1");
		choice_R12_1 = platform_R12_1.GetComponent<Collection_Trigger> ();
		choice_R12_2 = platform_R12_2.GetComponent<Collection_Trigger> ();

		// Room TWELVE Teleporter Material
		teleMaterial_R12_1 = GameObject.Find("Teleporter_R12_1").GetComponent<Renderer> ().material;

		// Room THIRTEEN Assets
		platform_R13_1 = GameObject.Find("Platform_R13_1");
		platform_R13_2 = GameObject.Find("Platform_R13_2");
		teleporterPad_R13_1 = GameObject.Find ("TelePad_R13_1");
		sphere_R13_1 = GameObject.Find ("Sphere_R13_1");
		choice_R13_1 = platform_R13_1.GetComponent<Collection_Trigger> ();
		choice_R13_2 = platform_R13_2.GetComponent<Collection_Trigger> ();

		// Room THIRTEEN Teleporter Material
		teleMaterial_R13_1 = GameObject.Find("Teleporter_R13_1").GetComponent<Renderer> ().material;

		// Room FOURTEEN Assets
		platform_R14_1 = GameObject.Find("Platform_R14_1");
		platform_R14_2 = GameObject.Find("Platform_R14_2");
		teleporterPad_R14_1 = GameObject.Find ("TelePad_R14_1");
		sphere_R14_1 = GameObject.Find ("Sphere_R14_1");
		choice_R14_1 = platform_R14_1.GetComponent<Collection_Trigger> ();
		choice_R14_2 = platform_R14_2.GetComponent<Collection_Trigger> ();

		// Room FOURTEEN Teleporter Material
		teleMaterial_R14_1 = GameObject.Find("Teleporter_R14_1").GetComponent<Renderer> ().material;

		// Room FIFTHTEEN Assets
		platform_R15_1 = GameObject.Find("Platform_R15_1");
		platform_R15_2 = GameObject.Find("Platform_R15_2");
		teleporterPad_R15_1 = GameObject.Find ("TelePad_R15_1");
		sphere_R15_1 = GameObject.Find ("Sphere_R15_1");
		choice_R15_1 = platform_R15_1.GetComponent<Collection_Trigger> ();
		choice_R15_2 = platform_R15_2.GetComponent<Collection_Trigger> ();

		// Room FIFTHTEEN Teleporter Material
		teleMaterial_R15_1 = GameObject.Find("Teleporter_R15_1").GetComponent<Renderer> ().material;

		// Room SIXTEEN Assets
		platform_R16_1 = GameObject.Find("Platform_R16_1");
		platform_R16_2 = GameObject.Find("Platform_R16_2");
		teleporterPad_R16_1 = GameObject.Find ("TelePad_R16_1");
		sphere_R16_1 = GameObject.Find ("Sphere_R16_1");
		choice_R16_1 = platform_R16_1.GetComponent<Collection_Trigger> ();
		choice_R16_2 = platform_R16_2.GetComponent<Collection_Trigger> ();

		// Room SIXTEEN Teleporter Material
		teleMaterial_R16_1 = GameObject.Find("Teleporter_R16_1").GetComponent<Renderer> ().material;

		// Room SEVENTEEN Assets
		platform_R17_1 = GameObject.Find("Platform_R17_1");
		platform_R17_2 = GameObject.Find("Platform_R17_2");
		teleporterPad_R17_1 = GameObject.Find ("TelePad_R17_1");
		sphere_R17_1 = GameObject.Find ("Sphere_R17_1");
		choice_R17_1 = platform_R17_1.GetComponent<Collection_Trigger> ();
		choice_R17_2 = platform_R17_2.GetComponent<Collection_Trigger> ();

		// Room SEVENTEEN Teleporter Materia
		teleMaterial_R17_1 = GameObject.Find("Teleporter_R17_1").GetComponent<Renderer> ().material;

		// Room EIGHTEEN Assets
		platform_R18_1 = GameObject.Find("Platform_R18_1");
		platform_R18_2 = GameObject.Find("Platform_R18_2");
		teleporterPad_R18_1 = GameObject.Find ("TelePad_R18_1");
		sphere_R18_1 = GameObject.Find ("Sphere_R18_1");
		choice_R18_1 = platform_R18_1.GetComponent<Collection_Trigger> ();
		choice_R18_2 = platform_R18_2.GetComponent<Collection_Trigger> ();

		// Room EIGHTEEN Teleporter Material
		teleMaterial_R18_1 = GameObject.Find("Teleporter_R18_1").GetComponent<Renderer> ().material;

		// Room NINETEEN Assets
		platform_R19_1 = GameObject.Find("Platform_R19_1");
		platform_R19_2 = GameObject.Find("Platform_R19_2");
		teleporterPad_R19_1 = GameObject.Find ("TelePad_R19_1");
		sphere_R19_1 = GameObject.Find ("Sphere_R19_1");
		choice_R19_1 = platform_R19_1.GetComponent<Collection_Trigger> ();
		choice_R19_2 = platform_R19_2.GetComponent<Collection_Trigger> ();

		// Room NINETEEN Teleporter Material
		teleMaterial_R19_1 = GameObject.Find("Teleporter_R19_1").GetComponent<Renderer> ().material;

		// Room TWENTY Assets
		platform_R20_1 = GameObject.Find("Platform_R20_1");
		platform_R20_2 = GameObject.Find("Platform_R20_2");
		teleporterPad_R20_1 = GameObject.Find ("TelePad_R20_1");
		sphere_R20_1 = GameObject.Find ("Sphere_R20_1");
		choice_R20_1 = platform_R20_1.GetComponent<Collection_Trigger> ();
		choice_R20_2 = platform_R20_2.GetComponent<Collection_Trigger> ();

		// Room TWENTY Teleporter Material
		teleMaterial_R20_1 = GameObject.Find("Teleporter_R20_1").GetComponent<Renderer> ().material;


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

		// TODO: Room Eight Assets - Material Updates
		if(choice_R8_1.platform_R8_1_Chosen || choice_R8_1.platform_R8_2_Chosen || choice_R8_2.platform_R8_1_Chosen || choice_R8_2.platform_R8_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R8_1.color = Color.green;
		} 
		else {teleMaterial_R8_1.color = Color.black;}

		// TODO: Room Nine Assets - Material Updates
		if(choice_R9_1.platform_R9_1_Chosen || choice_R9_1.platform_R9_2_Chosen || choice_R9_2.platform_R9_1_Chosen || choice_R9_2.platform_R9_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R9_1.color = Color.green;
		} 
		else {teleMaterial_R9_1.color = Color.black;}

		// TODO: Room Ten Assets - Material Updates
		if(choice_R10_1.platform_R10_1_Chosen || choice_R10_1.platform_R10_2_Chosen || choice_R10_2.platform_R10_1_Chosen || choice_R10_2.platform_R10_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R10_1.color = Color.green;
		} 
		else {teleMaterial_R10_1.color = Color.black;}

		// ROOMS 11-20 - TOWER OF ROOMS
		// Room ELEVEN Assets - Material Updates
		if (choice_R11_1.platform_R11_1_Chosen || choice_R11_1.platform_R11_2_Chosen || choice_R11_2.platform_R11_1_Chosen || choice_R11_2.platform_R11_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R11_1.color = Color.green;
		}
		else {teleMaterial_R11_1.color = Color.black;}

		// Room TWELVE Assets - Material Updates
		if(choice_R12_1.platform_R12_1_Chosen || choice_R12_1.platform_R12_2_Chosen || choice_R12_2.platform_R12_1_Chosen || choice_R12_2.platform_R12_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R12_1.color = Color.green;
		} 
		else {teleMaterial_R12_1.color = Color.black;}

		// Room THIRTEEN Assets - Material Updates
		if(choice_R13_1.platform_R13_1_Chosen || choice_R13_1.platform_R13_2_Chosen || choice_R13_2.platform_R13_1_Chosen || choice_R13_2.platform_R13_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R13_1.color = Color.green;
		} 
		else {teleMaterial_R13_1.color = Color.black;}

		// TODO: Room FOURTEEN Assets - Material Updates
		if(choice_R14_1.platform_R14_1_Chosen || choice_R14_1.platform_R14_2_Chosen || choice_R14_2.platform_R14_1_Chosen || choice_R14_2.platform_R14_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R14_1.color = Color.green;
		} 
		else {teleMaterial_R14_1.color = Color.black;}

		// TODO: Room FIFTHTEEN Assets - Material Updates
		if(choice_R15_1.platform_R15_1_Chosen || choice_R15_1.platform_R15_2_Chosen || choice_R15_2.platform_R15_1_Chosen || choice_R15_2.platform_R15_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R15_1.color = Color.green;
		} 
		else {teleMaterial_R15_1.color = Color.black;}

		// TODO: Room SIXTEEN Assets - Material Updates
		if(choice_R16_1.platform_R16_1_Chosen || choice_R16_1.platform_R16_2_Chosen || choice_R16_2.platform_R16_1_Chosen || choice_R16_2.platform_R16_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R16_1.color = Color.green;
		} 
		else {teleMaterial_R16_1.color = Color.black;}

		// TODO: Room SEVENTEEN Assets - Material Updates
		if(choice_R17_1.platform_R17_1_Chosen || choice_R17_1.platform_R17_2_Chosen || choice_R17_2.platform_R17_1_Chosen || choice_R17_2.platform_R17_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R17_1.color = Color.green;
		} 
		else {teleMaterial_R17_1.color = Color.black;}

		// TODO: Room EIGHTEEN Assets - Material Updates
		if(choice_R18_1.platform_R18_1_Chosen || choice_R18_1.platform_R18_2_Chosen || choice_R18_2.platform_R18_1_Chosen || choice_R18_2.platform_R18_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R18_1.color = Color.green;
		} 
		else {teleMaterial_R18_1.color = Color.black;}

		// TODO: Room NINETEEN Assets - Material Updates
		if(choice_R19_1.platform_R19_1_Chosen || choice_R19_1.platform_R19_2_Chosen || choice_R19_2.platform_R19_1_Chosen || choice_R19_2.platform_R19_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R19_1.color = Color.green;
		} 
		else {teleMaterial_R19_1.color = Color.black;}

		// TODO: Room TWENTY Assets - Material Updates
		if(choice_R20_1.platform_R20_1_Chosen || choice_R20_1.platform_R20_2_Chosen || choice_R20_2.platform_R20_1_Chosen || choice_R20_2.platform_R20_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R20_1.color = Color.green;
		} 
		else {teleMaterial_R20_1.color = Color.black;}

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
				sphere_R2_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R2_1, 0.1f);
			}
		} else if (!choice_R2_1.platform_R2_1_Chosen && choice_R2_2.platform_R2_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R2_2 Chosen - Now Teleporting");
				playerCT.R2_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R2_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
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
				sphere_R3_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R3_1, 0.1f);
			}
		} else if (!choice_R3_1.platform_R3_1_Chosen && choice_R3_2.platform_R3_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R3_2 Chosen - Now Teleporting");
				playerCT.R3_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R3_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
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
				sphere_R4_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R4_1, 0.1f);
			}
		} else if (!choice_R4_1.platform_R4_1_Chosen && choice_R4_2.platform_R4_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R4_2 Chosen - Now Teleporting");
				playerCT.R4_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R4_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
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
				sphere_R5_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R5_1, 0.1f);
			}
		} else if (!choice_R5_1.platform_R5_1_Chosen && choice_R5_2.platform_R5_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R5_2 Chosen - Now Teleporting");
				playerCT.R5_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R5_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
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
				sphere_R6_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R6_1, 0.1f);
			}
		} else if (!choice_R6_1.platform_R6_1_Chosen && choice_R6_2.platform_R6_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R6_2 Chosen - Now Teleporting");
				playerCT.R6_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R6_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
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
				sphere_R7_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R7_1, 0.1f);
			}
		} else if (!choice_R7_1.platform_R7_1_Chosen && choice_R7_2.platform_R7_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R7_2 Chosen - Now Teleporting");
				playerCT.R7_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R7_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R7_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R7_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room Eight Assets - Collision with Player Hitbox
		if (choice_R8_1.platform_R8_1_Chosen && !choice_R8_2.platform_R8_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R8_1 Chosen - Now Teleporting");
				playerCT.R8_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R8_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R8_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R8_1, 0.1f);
			}
		} else if (!choice_R8_1.platform_R8_1_Chosen && choice_R8_2.platform_R8_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R8_2 Chosen - Now Teleporting");
				playerCT.R8_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R8_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R8_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R8_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room Nine Assets - Collision with Player Hitbox
		if (choice_R9_1.platform_R9_1_Chosen && !choice_R9_2.platform_R9_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R9_1 Chosen - Now Teleporting");
				playerCT.R9_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R9_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R9_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R9_1, 0.1f);
			}
		} else if (!choice_R9_1.platform_R9_1_Chosen && choice_R9_2.platform_R9_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R9_2 Chosen - Now Teleporting");
				playerCT.R9_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R9_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R9_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R9_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room Ten Assets - Collision with Player Hitbox
		if (choice_R10_1.platform_R10_1_Chosen && !choice_R10_2.platform_R10_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R10_1 Chosen - Now Teleporting");
				playerCT.R10_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R10_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R10_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R10_1, 0.1f);
			}
		} else if (!choice_R10_1.platform_R10_1_Chosen && choice_R10_2.platform_R10_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R10_2 Chosen - Now Teleporting");
				playerCT.R10_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R10_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R10_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R10_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

	// ROOMS 11-20 - TOWER OF ROOMS

		// Room ELEVEN Assets - Collision with Player Hitbox
		if (choice_R11_1.platform_R11_1_Chosen && !choice_R11_2.platform_R11_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R11_1 Chosen - Now Teleporting");
				playerCT.R11_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R11_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R11_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R11_1, 0.1f);
			}
		}
		else if (!choice_R11_1.platform_R11_1_Chosen && choice_R11_2.platform_R11_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R11_2 Chosen - Now Teleporting");
				playerCT.R11_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R11_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R11_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R11_1, 0.1f);
			}
		}
		else if(other.name == "Player_Position"){
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}


		// TODO : Room TWELVE Assets - Collision with Player Hitbox
		if (choice_R12_1.platform_R12_1_Chosen && !choice_R12_2.platform_R12_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R12_1 Chosen - Now Teleporting");
				playerCT.R12_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R12_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R12_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R12_1, 0.1f);
			}
		} else if (!choice_R12_1.platform_R12_1_Chosen && choice_R12_2.platform_R12_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R12_2 Chosen - Now Teleporting");
				playerCT.R12_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R12_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R12_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R12_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room THIRTEEN Assets - Collision with Player Hitbox
		if (choice_R13_1.platform_R13_1_Chosen && !choice_R13_2.platform_R13_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R13_1 Chosen - Now Teleporting");
				playerCT.R13_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R13_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R13_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R13_1, 0.1f);
			}
		} else if (!choice_R13_1.platform_R13_1_Chosen && choice_R13_2.platform_R13_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R13_2 Chosen - Now Teleporting");
				playerCT.R13_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R13_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R13_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R13_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room FOURTEEN Assets - Collision with Player Hitbox
		if (choice_R14_1.platform_R14_1_Chosen && !choice_R14_2.platform_R14_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R14_1 Chosen - Now Teleporting");
				playerCT.R14_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R14_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R14_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R14_1, 0.1f);
			}
		} else if (!choice_R14_1.platform_R14_1_Chosen && choice_R14_2.platform_R14_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R14_2 Chosen - Now Teleporting");
				playerCT.R14_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R14_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R14_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R14_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room FIFTHTEEN Assets - Collision with Player Hitbox
		if (choice_R15_1.platform_R15_1_Chosen && !choice_R15_2.platform_R15_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R15_1 Chosen - Now Teleporting");
				playerCT.R15_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R15_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R15_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R15_1, 0.1f);
			}
		} else if (!choice_R15_1.platform_R15_1_Chosen && choice_R15_2.platform_R15_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R15_2 Chosen - Now Teleporting");
				playerCT.R15_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R15_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R15_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R15_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room SIXTEEN Assets - Collision with Player Hitbox
		if (choice_R16_1.platform_R16_1_Chosen && !choice_R16_2.platform_R16_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R16_1 Chosen - Now Teleporting");
				playerCT.R16_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R16_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R16_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R16_1, 0.1f);
			}
		} else if (!choice_R16_1.platform_R16_1_Chosen && choice_R16_2.platform_R16_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R16_2 Chosen - Now Teleporting");
				playerCT.R16_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R16_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R16_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R16_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room SEVENTEEN Assets - Collision with Player Hitbox
		if (choice_R17_1.platform_R17_1_Chosen && !choice_R17_2.platform_R17_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R17_1 Chosen - Now Teleporting");
				playerCT.R17_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R17_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R17_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R17_1, 0.1f);
			}
		} else if (!choice_R17_1.platform_R17_1_Chosen && choice_R17_2.platform_R17_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R17_2 Chosen - Now Teleporting");
				playerCT.R17_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R17_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R17_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R17_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room EIGHTEEN Assets - Collision with Player Hitbox
		if (choice_R18_1.platform_R18_1_Chosen && !choice_R18_2.platform_R18_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R18_1 Chosen - Now Teleporting");
				playerCT.R18_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R18_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R18_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R18_1, 0.1f);
			}
		} else if (!choice_R18_1.platform_R18_1_Chosen && choice_R18_2.platform_R18_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R18_2 Chosen - Now Teleporting");
				playerCT.R18_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R18_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R18_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R18_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room NINETEEN Assets - Collision with Player Hitbox
		if (choice_R19_1.platform_R19_1_Chosen && !choice_R19_2.platform_R19_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R19_1 Chosen - Now Teleporting");
				playerCT.R19_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R19_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R19_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R19_1, 0.1f);
			}
		} else if (!choice_R19_1.platform_R19_1_Chosen && choice_R19_2.platform_R19_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R19_2 Chosen - Now Teleporting");
				playerCT.R19_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R19_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				sphere_R19_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R19_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room TWENTY Assets - Collision with Player Hitbox
		if (choice_R20_1.platform_R20_1_Chosen && !choice_R20_2.platform_R20_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R20_1 Chosen - Now Teleporting");
				playerCT.R20_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R20_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCT.RoomStatsOff ();
				playerCT.StatsOn ();
				playerCT.writeToFile ();
				sphere_R20_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R20_1, 0.1f);
			}
		} else if (!choice_R20_1.platform_R20_1_Chosen && choice_R20_2.platform_R20_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R20_2 Chosen - Now Teleporting");
				playerCT.R20_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R20_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				playerCT.RoomStatsOff ();
				playerCT.StatsOn ();
				playerCT.writeToFile ();
				sphere_R20_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R20_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}
	}
}

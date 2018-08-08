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

	// ROOMS 21-30 - TOWER OF ROOMS
	// Room 21 Assets
	GameObject platform_R21_1, platform_R21_2,teleporterPad_R21_1, sphere_R21_1;
	Collection_Trigger choice_R21_1, choice_R21_2;
	bool tele_R21;

	// Room 22 Assets
	GameObject platform_R22_1, platform_R22_2,teleporterPad_R22_1, sphere_R22_1;
	Collection_Trigger choice_R22_1, choice_R22_2;
	bool tele_R22;

	// Room 23 Assets
	GameObject platform_R23_1, platform_R23_2,teleporterPad_R23_1, sphere_R23_1;
	Collection_Trigger choice_R23_1, choice_R23_2;
	bool tele_R23;

	// Room 24 Assets
	GameObject platform_R24_1, platform_R24_2,teleporterPad_R24_1, sphere_R24_1;
	Collection_Trigger choice_R24_1, choice_R24_2;
	bool tele_R24;

	// Room 25 Assets
	GameObject platform_R25_1, platform_R25_2,teleporterPad_R25_1, sphere_R25_1;
	Collection_Trigger choice_R25_1, choice_R25_2;
	bool tele_R25;

	// Room 26 Assets
	GameObject platform_R26_1, platform_R26_2,teleporterPad_R26_1, sphere_R26_1;
	Collection_Trigger choice_R26_1, choice_R26_2;
	bool tele_R26;

	// Room 27 Assets
	GameObject platform_R27_1, platform_R27_2,teleporterPad_R27_1, sphere_R27_1;
	Collection_Trigger choice_R27_1, choice_R27_2;
	bool tele_R27;

	// Room 28 Assets
	GameObject platform_R28_1, platform_R28_2,teleporterPad_R28_1, sphere_R28_1;
	Collection_Trigger choice_R28_1, choice_R28_2;
	bool tele_R28;

	// Room 29 Assets
	GameObject platform_R29_1, platform_R29_2,teleporterPad_R29_1, sphere_R29_1;
	Collection_Trigger choice_R29_1, choice_R29_2;
	bool tele_R29;

	// Room 30 Assets
	GameObject platform_R30_1, platform_R30_2,teleporterPad_R30_1, sphere_R30_1;
	Collection_Trigger choice_R30_1, choice_R30_2;
	bool tele_R30;

	// ROOMS 31-40 - TOWER OF ROOMS
	// Room 31 Assets
	GameObject platform_R31_1, platform_R31_2,teleporterPad_R31_1, sphere_R31_1;
	Collection_Trigger choice_R31_1, choice_R31_2;
	bool tele_R31;

	// Room 32 Assets
	GameObject platform_R32_1, platform_R32_2,teleporterPad_R32_1, sphere_R32_1;
	Collection_Trigger choice_R32_1, choice_R32_2;
	bool tele_R32;

	// Room 33 Assets
	GameObject platform_R33_1, platform_R33_2,teleporterPad_R33_1, sphere_R33_1;
	Collection_Trigger choice_R33_1, choice_R33_2;
	bool tele_R33;

	// Room 34 Assets
	GameObject platform_R34_1, platform_R34_2,teleporterPad_R34_1, sphere_R34_1;
	Collection_Trigger choice_R34_1, choice_R34_2;
	bool tele_R34;

	// Room 35 Assets
	GameObject platform_R35_1, platform_R35_2,teleporterPad_R35_1, sphere_R35_1;
	Collection_Trigger choice_R35_1, choice_R35_2;
	bool tele_R35;

	// Room 36 Assets
	GameObject platform_R36_1, platform_R36_2,teleporterPad_R36_1, sphere_R36_1;
	Collection_Trigger choice_R36_1, choice_R36_2;
	bool tele_R36;

	// Room 37 Assets
	GameObject platform_R37_1, platform_R37_2,teleporterPad_R37_1, sphere_R37_1;
	Collection_Trigger choice_R37_1, choice_R37_2;
	bool tele_R37;

	// Room 38 Assets
	GameObject platform_R38_1, platform_R38_2,teleporterPad_R38_1, sphere_R38_1;
	Collection_Trigger choice_R38_1, choice_R38_2;
	bool tele_R38;

	// Room 39 Assets
	GameObject platform_R39_1, platform_R39_2,teleporterPad_R39_1, sphere_R39_1;
	Collection_Trigger choice_R39_1, choice_R39_2;
	bool tele_R39;

	// Room 40 Assets
	GameObject platform_R40_1, platform_R40_2,teleporterPad_R40_1, sphere_R40_1;
	Collection_Trigger choice_R40_1, choice_R40_2;
	bool tele_R40;

	// Room 41 Assets
	GameObject platform_R41_1, platform_R41_2,teleporterPad_R41_1, sphere_R41_1;
	Collection_Trigger choice_R41_1, choice_R41_2;
	bool tele_R41;

	// Room 42 Assets
	GameObject platform_R42_1, platform_R42_2,teleporterPad_R42_1, sphere_R42_1;
	Collection_Trigger choice_R42_1, choice_R42_2;
	bool tele_R42;

	// Room 43 Assets
	GameObject platform_R43_1, platform_R43_2,teleporterPad_R43_1, sphere_R43_1;
	Collection_Trigger choice_R43_1, choice_R43_2;
	bool tele_R43;

	// Generic Assets
	GameObject player;
	CanvasScript playerCS;
	Camera_Control playerCC;
	Choice_Tracker playerCT;
	Pickup_Script playerPS;

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

	// ROOMS 21-30 - TOWER OF ROOMS
	Material teleMaterial_R21_1;
	Material teleMaterial_R22_1;
	Material teleMaterial_R23_1;
	Material teleMaterial_R24_1;
	Material teleMaterial_R25_1;
	Material teleMaterial_R26_1;
	Material teleMaterial_R27_1;
	Material teleMaterial_R28_1;
	Material teleMaterial_R29_1;
	Material teleMaterial_R30_1;

	// ROOMS 31-43 - TOWER OF ROOMS
	Material teleMaterial_R31_1;
	Material teleMaterial_R32_1;
	Material teleMaterial_R33_1;
	Material teleMaterial_R34_1;
	Material teleMaterial_R35_1;
	Material teleMaterial_R36_1;
	Material teleMaterial_R37_1;
	Material teleMaterial_R38_1;
	Material teleMaterial_R39_1;
	Material teleMaterial_R40_1;
	Material teleMaterial_R41_1;
	Material teleMaterial_R42_1;
	Material teleMaterial_R43_1;

	// Use this for initialization
	void Start () {
		playerCS = GameObject.Find ("Player").GetComponent<CanvasScript> ();
		playerCT = GameObject.Find ("Player").GetComponent<Choice_Tracker> ();
		playerCC = GameObject.Find ("Player").GetComponent<Camera_Control> ();
		playerPS = GameObject.Find ("Player").GetComponent<Pickup_Script> ();
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

		// ROOMS 21-30 - TOWER OF ROOMS
		// Room 21 Assets
		platform_R21_1 = GameObject.Find ("Platform_R21_1");
		platform_R21_2 = GameObject.Find ("Platform_R21_2");
		teleporterPad_R21_1 = GameObject.Find ("TelePad_R21_1");
		sphere_R21_1 = GameObject.Find ("Sphere_R21_1");
		choice_R21_1 = platform_R21_1.GetComponent<Collection_Trigger> ();
		choice_R21_2 = platform_R21_2.GetComponent<Collection_Trigger> ();

		// Room 21 Teleporter Materia
		teleMaterial_R21_1 = GameObject.Find("Teleporter_R21_1").GetComponent<Renderer> ().material;

		// Room 22 Assets
		platform_R22_1 = GameObject.Find("Platform_R22_1");
		platform_R22_2 = GameObject.Find("Platform_R22_2");
		teleporterPad_R22_1 = GameObject.Find ("TelePad_R22_1");
		sphere_R22_1 = GameObject.Find ("Sphere_R22_1");
		choice_R22_1 = platform_R22_1.GetComponent<Collection_Trigger> ();
		choice_R22_2 = platform_R22_2.GetComponent<Collection_Trigger> ();

		// Room 22 Teleporter Material
		teleMaterial_R22_1 = GameObject.Find("Teleporter_R22_1").GetComponent<Renderer> ().material;

		// Room 23 Assets
		platform_R23_1 = GameObject.Find("Platform_R23_1");
		platform_R23_2 = GameObject.Find("Platform_R23_2");
		teleporterPad_R23_1 = GameObject.Find ("TelePad_R23_1");
		sphere_R23_1 = GameObject.Find ("Sphere_R23_1");
		choice_R23_1 = platform_R23_1.GetComponent<Collection_Trigger> ();
		choice_R23_2 = platform_R23_2.GetComponent<Collection_Trigger> ();

		// Room 23 Teleporter Material
		teleMaterial_R23_1 = GameObject.Find("Teleporter_R23_1").GetComponent<Renderer> ().material;

		// Room 24 Assets
		platform_R24_1 = GameObject.Find("Platform_R24_1");
		platform_R24_2 = GameObject.Find("Platform_R24_2");
		teleporterPad_R24_1 = GameObject.Find ("TelePad_R24_1");
		sphere_R24_1 = GameObject.Find ("Sphere_R24_1");
		choice_R24_1 = platform_R24_1.GetComponent<Collection_Trigger> ();
		choice_R24_2 = platform_R24_2.GetComponent<Collection_Trigger> ();

		// Room 24 Teleporter Material
		teleMaterial_R24_1 = GameObject.Find("Teleporter_R24_1").GetComponent<Renderer> ().material;

		// Room 25 Assets
		platform_R25_1 = GameObject.Find("Platform_R25_1");
		platform_R25_2 = GameObject.Find("Platform_R25_2");
		teleporterPad_R25_1 = GameObject.Find ("TelePad_R25_1");
		sphere_R25_1 = GameObject.Find ("Sphere_R25_1");
		choice_R25_1 = platform_R25_1.GetComponent<Collection_Trigger> ();
		choice_R25_2 = platform_R25_2.GetComponent<Collection_Trigger> ();

		// Room 25 Teleporter Material
		teleMaterial_R25_1 = GameObject.Find("Teleporter_R25_1").GetComponent<Renderer> ().material;

		// Room 26 Assets
		platform_R26_1 = GameObject.Find("Platform_R26_1");
		platform_R26_2 = GameObject.Find("Platform_R26_2");
		teleporterPad_R26_1 = GameObject.Find ("TelePad_R26_1");
		sphere_R26_1 = GameObject.Find ("Sphere_R26_1");
		choice_R26_1 = platform_R26_1.GetComponent<Collection_Trigger> ();
		choice_R26_2 = platform_R26_2.GetComponent<Collection_Trigger> ();

		// Room 26 Teleporter Material
		teleMaterial_R26_1 = GameObject.Find("Teleporter_R26_1").GetComponent<Renderer> ().material;

		// Room 27 Assets
		platform_R27_1 = GameObject.Find("Platform_R27_1");
		platform_R27_2 = GameObject.Find("Platform_R27_2");
		teleporterPad_R27_1 = GameObject.Find ("TelePad_R27_1");
		sphere_R27_1 = GameObject.Find ("Sphere_R27_1");
		choice_R27_1 = platform_R27_1.GetComponent<Collection_Trigger> ();
		choice_R27_2 = platform_R27_2.GetComponent<Collection_Trigger> ();

		// Room 27 Teleporter Materia
		teleMaterial_R27_1 = GameObject.Find("Teleporter_R27_1").GetComponent<Renderer> ().material;

		// Room 28 Assets
		platform_R28_1 = GameObject.Find("Platform_R28_1");
		platform_R28_2 = GameObject.Find("Platform_R28_2");
		teleporterPad_R28_1 = GameObject.Find ("TelePad_R28_1");
		sphere_R28_1 = GameObject.Find ("Sphere_R28_1");
		choice_R28_1 = platform_R28_1.GetComponent<Collection_Trigger> ();
		choice_R28_2 = platform_R28_2.GetComponent<Collection_Trigger> ();

		// Room 28 Teleporter Material
		teleMaterial_R28_1 = GameObject.Find("Teleporter_R28_1").GetComponent<Renderer> ().material;

		// Room 29 Assets
		platform_R29_1 = GameObject.Find("Platform_R29_1");
		platform_R29_2 = GameObject.Find("Platform_R29_2");
		teleporterPad_R29_1 = GameObject.Find ("TelePad_R29_1");
		sphere_R29_1 = GameObject.Find ("Sphere_R29_1");
		choice_R29_1 = platform_R29_1.GetComponent<Collection_Trigger> ();
		choice_R29_2 = platform_R29_2.GetComponent<Collection_Trigger> ();

		// Room 29 Teleporter Material
		teleMaterial_R29_1 = GameObject.Find("Teleporter_R29_1").GetComponent<Renderer> ().material;

		// Room 30 Assets
		platform_R30_1 = GameObject.Find("Platform_R30_1");
		platform_R30_2 = GameObject.Find("Platform_R30_2");
		teleporterPad_R30_1 = GameObject.Find ("TelePad_R30_1");
		sphere_R30_1 = GameObject.Find ("Sphere_R30_1");
		choice_R30_1 = platform_R30_1.GetComponent<Collection_Trigger> ();
		choice_R30_2 = platform_R30_2.GetComponent<Collection_Trigger> ();

		// Room 30 Teleporter Material
		teleMaterial_R30_1 = GameObject.Find("Teleporter_R30_1").GetComponent<Renderer> ().material;

		// ROOMS 31-43 - TOWER OF ROOMS
		// Room 31 Assets
		platform_R31_1 = GameObject.Find ("Platform_R31_1");
		platform_R31_2 = GameObject.Find ("Platform_R31_2");
		teleporterPad_R31_1 = GameObject.Find ("TelePad_R31_1");
		sphere_R31_1 = GameObject.Find ("Sphere_R31_1");
		choice_R31_1 = platform_R31_1.GetComponent<Collection_Trigger> ();
		choice_R31_2 = platform_R31_2.GetComponent<Collection_Trigger> ();

		// Room 31 Teleporter Material
		teleMaterial_R31_1 = GameObject.Find("Teleporter_R31_1").GetComponent<Renderer> ().material;

		// Room 32 Assets
		platform_R32_1 = GameObject.Find("Platform_R32_1");
		platform_R32_2 = GameObject.Find("Platform_R32_2");
		teleporterPad_R32_1 = GameObject.Find ("TelePad_R32_1");
		sphere_R32_1 = GameObject.Find ("Sphere_R32_1");
		choice_R32_1 = platform_R32_1.GetComponent<Collection_Trigger> ();
		choice_R32_2 = platform_R32_2.GetComponent<Collection_Trigger> ();

		// Room 32 Teleporter Material
		teleMaterial_R32_1 = GameObject.Find("Teleporter_R32_1").GetComponent<Renderer> ().material;

		// Room 33 Assets
		platform_R33_1 = GameObject.Find("Platform_R33_1");
		platform_R33_2 = GameObject.Find("Platform_R33_2");
		teleporterPad_R33_1 = GameObject.Find ("TelePad_R33_1");
		sphere_R33_1 = GameObject.Find ("Sphere_R33_1");
		choice_R33_1 = platform_R33_1.GetComponent<Collection_Trigger> ();
		choice_R33_2 = platform_R33_2.GetComponent<Collection_Trigger> ();

		// Room 33 Teleporter Material
		teleMaterial_R33_1 = GameObject.Find("Teleporter_R33_1").GetComponent<Renderer> ().material;

		// Room 34 Assets
		platform_R34_1 = GameObject.Find("Platform_R34_1");
		platform_R34_2 = GameObject.Find("Platform_R34_2");
		teleporterPad_R34_1 = GameObject.Find ("TelePad_R34_1");
		sphere_R34_1 = GameObject.Find ("Sphere_R34_1");
		choice_R34_1 = platform_R34_1.GetComponent<Collection_Trigger> ();
		choice_R34_2 = platform_R34_2.GetComponent<Collection_Trigger> ();

		// Room 34 Teleporter Material
		teleMaterial_R34_1 = GameObject.Find("Teleporter_R34_1").GetComponent<Renderer> ().material;

		// Room 35 Assets
		platform_R35_1 = GameObject.Find("Platform_R35_1");
		platform_R35_2 = GameObject.Find("Platform_R35_2");
		teleporterPad_R35_1 = GameObject.Find ("TelePad_R35_1");
		sphere_R35_1 = GameObject.Find ("Sphere_R35_1");
		choice_R35_1 = platform_R35_1.GetComponent<Collection_Trigger> ();
		choice_R35_2 = platform_R35_2.GetComponent<Collection_Trigger> ();

		// Room 35 Teleporter Material
		teleMaterial_R35_1 = GameObject.Find("Teleporter_R35_1").GetComponent<Renderer> ().material;

		// Room 36 Assets
		platform_R36_1 = GameObject.Find("Platform_R36_1");
		platform_R36_2 = GameObject.Find("Platform_R36_2");
		teleporterPad_R36_1 = GameObject.Find ("TelePad_R36_1");
		sphere_R36_1 = GameObject.Find ("Sphere_R36_1");
		choice_R36_1 = platform_R36_1.GetComponent<Collection_Trigger> ();
		choice_R36_2 = platform_R36_2.GetComponent<Collection_Trigger> ();

		// Room 36 Teleporter Material
		teleMaterial_R36_1 = GameObject.Find("Teleporter_R36_1").GetComponent<Renderer> ().material;

		// Room 37 Assets
		platform_R37_1 = GameObject.Find("Platform_R37_1");
		platform_R37_2 = GameObject.Find("Platform_R37_2");
		teleporterPad_R37_1 = GameObject.Find ("TelePad_R37_1");
		sphere_R37_1 = GameObject.Find ("Sphere_R37_1");
		choice_R37_1 = platform_R37_1.GetComponent<Collection_Trigger> ();
		choice_R37_2 = platform_R37_2.GetComponent<Collection_Trigger> ();

		// Room 37 Teleporter Materia
		teleMaterial_R37_1 = GameObject.Find("Teleporter_R37_1").GetComponent<Renderer> ().material;

		// Room 38 Assets
		platform_R38_1 = GameObject.Find("Platform_R38_1");
		platform_R38_2 = GameObject.Find("Platform_R38_2");
		teleporterPad_R38_1 = GameObject.Find ("TelePad_R38_1");
		sphere_R38_1 = GameObject.Find ("Sphere_R38_1");
		choice_R38_1 = platform_R38_1.GetComponent<Collection_Trigger> ();
		choice_R38_2 = platform_R38_2.GetComponent<Collection_Trigger> ();

		// Room 38 Teleporter Material
		teleMaterial_R38_1 = GameObject.Find("Teleporter_R38_1").GetComponent<Renderer> ().material;

		// Room 39 Assets
		platform_R39_1 = GameObject.Find("Platform_R39_1");
		platform_R39_2 = GameObject.Find("Platform_R39_2");
		teleporterPad_R39_1 = GameObject.Find ("TelePad_R39_1");
		sphere_R39_1 = GameObject.Find ("Sphere_R39_1");
		choice_R39_1 = platform_R39_1.GetComponent<Collection_Trigger> ();
		choice_R39_2 = platform_R39_2.GetComponent<Collection_Trigger> ();

		// Room 39 Teleporter Material
		teleMaterial_R39_1 = GameObject.Find("Teleporter_R39_1").GetComponent<Renderer> ().material;

		// Room 40 Assets
		platform_R40_1 = GameObject.Find("Platform_R40_1");
		platform_R40_2 = GameObject.Find("Platform_R40_2");
		teleporterPad_R40_1 = GameObject.Find ("TelePad_R40_1");
		sphere_R40_1 = GameObject.Find ("Sphere_R40_1");
		choice_R40_1 = platform_R40_1.GetComponent<Collection_Trigger> ();
		choice_R40_2 = platform_R40_2.GetComponent<Collection_Trigger> ();

		// Room 40 Teleporter Material
		teleMaterial_R40_1 = GameObject.Find("Teleporter_R40_1").GetComponent<Renderer> ().material;

		// Room 41 Assets
		platform_R41_1 = GameObject.Find("Platform_R41_1");
		platform_R41_2 = GameObject.Find("Platform_R41_2");
		teleporterPad_R41_1 = GameObject.Find ("TelePad_R41_1");
		sphere_R41_1 = GameObject.Find ("Sphere_R41_1");
		choice_R41_1 = platform_R41_1.GetComponent<Collection_Trigger> ();
		choice_R41_2 = platform_R41_2.GetComponent<Collection_Trigger> ();

		// Room 41 Teleporter Material
		teleMaterial_R41_1 = GameObject.Find("Teleporter_R41_1").GetComponent<Renderer> ().material;

		// Room 42 Assets
		platform_R42_1 = GameObject.Find("Platform_R42_1");
		platform_R42_2 = GameObject.Find("Platform_R42_2");
		teleporterPad_R42_1 = GameObject.Find ("TelePad_R42_1");
		sphere_R42_1 = GameObject.Find ("Sphere_R42_1");
		choice_R42_1 = platform_R42_1.GetComponent<Collection_Trigger> ();
		choice_R42_2 = platform_R42_2.GetComponent<Collection_Trigger> ();

		// Room 42 Teleporter Material
		teleMaterial_R42_1 = GameObject.Find("Teleporter_R42_1").GetComponent<Renderer> ().material;

		// Room 43 Assets
		platform_R43_1 = GameObject.Find("Platform_R43_1");
		platform_R43_2 = GameObject.Find("Platform_R43_2");
		teleporterPad_R43_1 = GameObject.Find ("TelePad_R43_1");
		sphere_R43_1 = GameObject.Find ("Sphere_R43_1");
		choice_R43_1 = platform_R43_1.GetComponent<Collection_Trigger> ();
		choice_R43_2 = platform_R43_2.GetComponent<Collection_Trigger> ();

		// Room 43 Teleporter Material
		teleMaterial_R43_1 = GameObject.Find("Teleporter_R43_1").GetComponent<Renderer> ().material;


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

		// ROOMS 21-30 - TOWER OF ROOMS
		// Room 21 Assets - Material Updates
		if (choice_R21_1.platform_R21_1_Chosen || choice_R21_1.platform_R21_2_Chosen || choice_R21_2.platform_R21_1_Chosen || choice_R21_2.platform_R21_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R21_1.color = Color.green;
		}
		else {teleMaterial_R21_1.color = Color.black;}

		// Room 22 Assets - Material Updates
		if(choice_R22_1.platform_R22_1_Chosen || choice_R22_1.platform_R22_2_Chosen || choice_R22_2.platform_R22_1_Chosen || choice_R22_2.platform_R22_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R22_1.color = Color.green;
		} 
		else {teleMaterial_R22_1.color = Color.black;}

		// Room 23 Assets - Material Updates
		if(choice_R23_1.platform_R23_1_Chosen || choice_R23_1.platform_R23_2_Chosen || choice_R23_2.platform_R23_1_Chosen || choice_R23_2.platform_R23_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R23_1.color = Color.green;
		} 
		else {teleMaterial_R23_1.color = Color.black;}

		// TODO: Room 24 Assets - Material Updates
		if(choice_R24_1.platform_R24_1_Chosen || choice_R24_1.platform_R24_2_Chosen || choice_R24_2.platform_R24_1_Chosen || choice_R24_2.platform_R24_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R24_1.color = Color.green;
		} 
		else {teleMaterial_R24_1.color = Color.black;}

		// TODO: Room 25 Assets - Material Updates
		if(choice_R25_1.platform_R25_1_Chosen || choice_R25_1.platform_R25_2_Chosen || choice_R25_2.platform_R25_1_Chosen || choice_R25_2.platform_R25_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R25_1.color = Color.green;
		} 
		else {teleMaterial_R25_1.color = Color.black;}

		// TODO: Room 26 Assets - Material Updates
		if(choice_R26_1.platform_R26_1_Chosen || choice_R26_1.platform_R26_2_Chosen || choice_R26_2.platform_R26_1_Chosen || choice_R26_2.platform_R26_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R26_1.color = Color.green;
		} 
		else {teleMaterial_R26_1.color = Color.black;}

		// TODO: Room 27 Assets - Material Updates
		if(choice_R27_1.platform_R27_1_Chosen || choice_R27_1.platform_R27_2_Chosen || choice_R27_2.platform_R27_1_Chosen || choice_R27_2.platform_R27_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R27_1.color = Color.green;
		} 
		else {teleMaterial_R27_1.color = Color.black;}

		// TODO: Room 28 Assets - Material Updates
		if(choice_R28_1.platform_R28_1_Chosen || choice_R28_1.platform_R28_2_Chosen || choice_R28_2.platform_R28_1_Chosen || choice_R28_2.platform_R28_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R28_1.color = Color.green;
		} 
		else {teleMaterial_R28_1.color = Color.black;}

		// TODO: Room 29 Assets - Material Updates
		if(choice_R29_1.platform_R29_1_Chosen || choice_R29_1.platform_R29_2_Chosen || choice_R29_2.platform_R29_1_Chosen || choice_R29_2.platform_R29_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R29_1.color = Color.green;
		} 
		else {teleMaterial_R29_1.color = Color.black;}

		// TODO: Room 30 Assets - Material Updates
		if(choice_R30_1.platform_R30_1_Chosen || choice_R30_1.platform_R30_2_Chosen || choice_R30_2.platform_R30_1_Chosen || choice_R30_2.platform_R30_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R30_1.color = Color.green;
		} 
		else {teleMaterial_R30_1.color = Color.black;}

		// ROOMS 31-43 - TOWER OF ROOMS
		// Room 31 Assets - Material Updates
		if (choice_R31_1.platform_R31_1_Chosen || choice_R31_1.platform_R31_2_Chosen || choice_R31_2.platform_R31_1_Chosen || choice_R31_2.platform_R31_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R31_1.color = Color.green;
		}
		else {teleMaterial_R31_1.color = Color.black;}

		// Room 32 Assets - Material Updates
		if(choice_R32_1.platform_R32_1_Chosen || choice_R32_1.platform_R32_2_Chosen || choice_R32_2.platform_R32_1_Chosen || choice_R32_2.platform_R32_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R32_1.color = Color.green;
		} 
		else {teleMaterial_R32_1.color = Color.black;}

		// Room 33 Assets - Material Updates
		if(choice_R33_1.platform_R33_1_Chosen || choice_R33_1.platform_R33_2_Chosen || choice_R33_2.platform_R33_1_Chosen || choice_R33_2.platform_R33_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R33_1.color = Color.green;
		} 
		else {teleMaterial_R33_1.color = Color.black;}

		// TODO: Room 34 Assets - Material Updates
		if(choice_R34_1.platform_R34_1_Chosen || choice_R34_1.platform_R34_2_Chosen || choice_R34_2.platform_R34_1_Chosen || choice_R34_2.platform_R34_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R34_1.color = Color.green;
		} 
		else {teleMaterial_R34_1.color = Color.black;}

		// TODO: Room 35 Assets - Material Updates
		if(choice_R35_1.platform_R35_1_Chosen || choice_R35_1.platform_R35_2_Chosen || choice_R35_2.platform_R35_1_Chosen || choice_R35_2.platform_R35_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R35_1.color = Color.green;
		} 
		else {teleMaterial_R35_1.color = Color.black;}

		// TODO: Room 36 Assets - Material Updates
		if(choice_R36_1.platform_R36_1_Chosen || choice_R36_1.platform_R36_2_Chosen || choice_R36_2.platform_R36_1_Chosen || choice_R36_2.platform_R36_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R36_1.color = Color.green;
		} 
		else {teleMaterial_R36_1.color = Color.black;}

		// TODO: Room 37 Assets - Material Updates
		if(choice_R37_1.platform_R37_1_Chosen || choice_R37_1.platform_R37_2_Chosen || choice_R37_2.platform_R37_1_Chosen || choice_R37_2.platform_R37_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R37_1.color = Color.green;
		} 
		else {teleMaterial_R37_1.color = Color.black;}

		// TODO: Room 38 Assets - Material Updates
		if(choice_R38_1.platform_R38_1_Chosen || choice_R38_1.platform_R38_2_Chosen || choice_R38_2.platform_R38_1_Chosen || choice_R38_2.platform_R38_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R38_1.color = Color.green;
		} 
		else {teleMaterial_R38_1.color = Color.black;}

		// TODO: Room 39 Assets - Material Updates
		if(choice_R39_1.platform_R39_1_Chosen || choice_R39_1.platform_R39_2_Chosen || choice_R39_2.platform_R39_1_Chosen || choice_R39_2.platform_R39_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R39_1.color = Color.green;
		} 
		else {teleMaterial_R39_1.color = Color.black;}

		// TODO: Room 40 Assets - Material Updates
		if(choice_R40_1.platform_R40_1_Chosen || choice_R40_1.platform_R40_2_Chosen || choice_R40_2.platform_R40_1_Chosen || choice_R40_2.platform_R40_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R40_1.color = Color.green;
		} 
		else {teleMaterial_R40_1.color = Color.black;}

		// TODO: Room 41 Assets - Material Updates
		if(choice_R41_1.platform_R41_1_Chosen || choice_R41_1.platform_R41_2_Chosen || choice_R41_2.platform_R41_1_Chosen || choice_R41_2.platform_R41_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R41_1.color = Color.green;
		} 
		else {teleMaterial_R41_1.color = Color.black;}

		// TODO: Room 42 Assets - Material Updates
		if(choice_R42_1.platform_R42_1_Chosen || choice_R42_1.platform_R42_2_Chosen || choice_R42_2.platform_R42_1_Chosen || choice_R42_2.platform_R42_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R42_1.color = Color.green;
		} 
		else {teleMaterial_R42_1.color = Color.black;}

		// TODO: Room 43 Assets - Material Updates
		if(choice_R43_1.platform_R43_1_Chosen || choice_R43_1.platform_R43_2_Chosen || choice_R43_2.platform_R43_1_Chosen || choice_R43_2.platform_R43_2_Chosen) {
			if (!playerCS.teleTextCorrect) {playerCS.DisplayTeleporterCorrect ();}
			teleMaterial_R43_1.color = Color.green;
		} 
		else {teleMaterial_R43_1.color = Color.black;}

	}

	void OnTriggerEnter(Collider other){

		// Room One Assets - Collision with Player Hitbox
		if (choice_R1_1.platform_R1_1_Chosen && !choice_R1_2.platform_R1_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R1_1 Chosen - Now Teleporting");
				playerCT.R1_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R1_1.transform.position;
				stopCarrying();
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
				stopCarrying();
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
				stopCarrying();
				sphere_R2_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R2_1, 0.1f);
			}
		} else if (!choice_R2_1.platform_R2_1_Chosen && choice_R2_2.platform_R2_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R2_2 Chosen - Now Teleporting");
				playerCT.R2_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R2_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R3_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R3_1, 0.1f);
			}
		} else if (!choice_R3_1.platform_R3_1_Chosen && choice_R3_2.platform_R3_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R3_2 Chosen - Now Teleporting");
				playerCT.R3_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R3_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R4_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R4_1, 0.1f);
			}
		} else if (!choice_R4_1.platform_R4_1_Chosen && choice_R4_2.platform_R4_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R4_2 Chosen - Now Teleporting");
				playerCT.R4_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R4_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R5_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R5_1, 0.1f);
			}
		} else if (!choice_R5_1.platform_R5_1_Chosen && choice_R5_2.platform_R5_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R5_2 Chosen - Now Teleporting");
				playerCT.R5_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R5_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R6_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R6_1, 0.1f);
			}
		} else if (!choice_R6_1.platform_R6_1_Chosen && choice_R6_2.platform_R6_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R6_2 Chosen - Now Teleporting");
				playerCT.R6_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R6_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R7_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R7_1, 0.1f);
			}
		} else if (!choice_R7_1.platform_R7_1_Chosen && choice_R7_2.platform_R7_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R7_2 Chosen - Now Teleporting");
				playerCT.R7_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R7_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R8_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R8_1, 0.1f);
			}
		} else if (!choice_R8_1.platform_R8_1_Chosen && choice_R8_2.platform_R8_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R8_2 Chosen - Now Teleporting");
				playerCT.R8_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R8_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R9_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R9_1, 0.1f);
			}
		} else if (!choice_R9_1.platform_R9_1_Chosen && choice_R9_2.platform_R9_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R9_2 Chosen - Now Teleporting");
				playerCT.R9_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R9_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R10_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R10_1, 0.1f);
			}
		} else if (!choice_R10_1.platform_R10_1_Chosen && choice_R10_2.platform_R10_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R10_2 Chosen - Now Teleporting");
				playerCT.R10_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R10_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
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
				stopCarrying();
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
				stopCarrying();
				sphere_R12_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R12_1, 0.1f);
			}
		} else if (!choice_R12_1.platform_R12_1_Chosen && choice_R12_2.platform_R12_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R12_2 Chosen - Now Teleporting");
				playerCT.R12_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R12_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R13_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R13_1, 0.1f);
			}
		} else if (!choice_R13_1.platform_R13_1_Chosen && choice_R13_2.platform_R13_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R13_2 Chosen - Now Teleporting");
				playerCT.R13_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R13_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R14_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R14_1, 0.1f);
			}
		} else if (!choice_R14_1.platform_R14_1_Chosen && choice_R14_2.platform_R14_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R14_2 Chosen - Now Teleporting");
				playerCT.R14_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R14_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R15_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R15_1, 0.1f);
			}
		} else if (!choice_R15_1.platform_R15_1_Chosen && choice_R15_2.platform_R15_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R15_2 Chosen - Now Teleporting");
				playerCT.R15_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R15_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R16_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R16_1, 0.1f);
			}
		} else if (!choice_R16_1.platform_R16_1_Chosen && choice_R16_2.platform_R16_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R16_2 Chosen - Now Teleporting");
				playerCT.R16_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R16_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R17_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R17_1, 0.1f);
			}
		} else if (!choice_R17_1.platform_R17_1_Chosen && choice_R17_2.platform_R17_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R17_2 Chosen - Now Teleporting");
				playerCT.R17_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R17_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R18_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R18_1, 0.1f);
			}
		} else if (!choice_R18_1.platform_R18_1_Chosen && choice_R18_2.platform_R18_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R18_2 Chosen - Now Teleporting");
				playerCT.R18_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R18_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R19_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R19_1, 0.1f);
			}
		} else if (!choice_R19_1.platform_R19_1_Chosen && choice_R19_2.platform_R19_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R19_2 Chosen - Now Teleporting");
				playerCT.R19_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R19_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
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
				stopCarrying();
				sphere_R20_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R20_1, 0.1f);
			}
		} else if (!choice_R20_1.platform_R20_1_Chosen && choice_R20_2.platform_R20_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R20_2 Chosen - Now Teleporting");
				playerCT.R20_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R20_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R20_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R20_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// ROOMS 21-30 - TOWER OF ROOMS

		// Room 21 Assets - Collision with Player Hitbox
		if (choice_R21_1.platform_R21_1_Chosen && !choice_R21_2.platform_R21_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R21_1 Chosen - Now Teleporting");
				playerCT.R21_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R21_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R21_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R21_1, 0.1f);
			}
		}
		else if (!choice_R21_1.platform_R21_1_Chosen && choice_R21_2.platform_R21_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R21_2 Chosen - Now Teleporting");
				playerCT.R21_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R21_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R21_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R21_1, 0.1f);
			}
		}
		else if(other.name == "Player_Position"){
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}


		// TODO : Room 22 Assets - Collision with Player Hitbox
		if (choice_R22_1.platform_R22_1_Chosen && !choice_R22_2.platform_R22_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R22_1 Chosen - Now Teleporting");
				playerCT.R22_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R22_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R22_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R22_1, 0.1f);
			}
		} else if (!choice_R22_1.platform_R22_1_Chosen && choice_R22_2.platform_R22_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R22_2 Chosen - Now Teleporting");
				playerCT.R22_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R22_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R22_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R22_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 23 Assets - Collision with Player Hitbox
		if (choice_R23_1.platform_R23_1_Chosen && !choice_R23_2.platform_R23_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R23_1 Chosen - Now Teleporting");
				playerCT.R23_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R23_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R23_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R23_1, 0.1f);
			}
		} else if (!choice_R23_1.platform_R23_1_Chosen && choice_R23_2.platform_R23_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R23_2 Chosen - Now Teleporting");
				playerCT.R23_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R23_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R23_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R23_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 24 Assets - Collision with Player Hitbox
		if (choice_R24_1.platform_R24_1_Chosen && !choice_R24_2.platform_R24_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R24_1 Chosen - Now Teleporting");
				playerCT.R24_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R24_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R24_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R24_1, 0.1f);
			}
		} else if (!choice_R24_1.platform_R24_1_Chosen && choice_R24_2.platform_R24_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R24_2 Chosen - Now Teleporting");
				playerCT.R24_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R24_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R24_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R24_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 25 Assets - Collision with Player Hitbox
		if (choice_R25_1.platform_R25_1_Chosen && !choice_R25_2.platform_R25_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R25_1 Chosen - Now Teleporting");
				playerCT.R25_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R25_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R25_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R25_1, 0.1f);
			}
		} else if (!choice_R25_1.platform_R25_1_Chosen && choice_R25_2.platform_R25_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R25_2 Chosen - Now Teleporting");
				playerCT.R25_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R25_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R25_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R25_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 26 Assets - Collision with Player Hitbox
		if (choice_R26_1.platform_R26_1_Chosen && !choice_R26_2.platform_R26_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R26_1 Chosen - Now Teleporting");
				playerCT.R26_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R26_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R26_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R26_1, 0.1f);
			}
		} else if (!choice_R26_1.platform_R26_1_Chosen && choice_R26_2.platform_R26_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R26_2 Chosen - Now Teleporting");
				playerCT.R26_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R26_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R26_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R26_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 27 Assets - Collision with Player Hitbox
		if (choice_R27_1.platform_R27_1_Chosen && !choice_R27_2.platform_R27_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R27_1 Chosen - Now Teleporting");
				playerCT.R27_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R27_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R27_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R27_1, 0.1f);
			}
		} else if (!choice_R27_1.platform_R27_1_Chosen && choice_R27_2.platform_R27_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R27_2 Chosen - Now Teleporting");
				playerCT.R27_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R27_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R27_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R27_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 28 Assets - Collision with Player Hitbox
		if (choice_R28_1.platform_R28_1_Chosen && !choice_R28_2.platform_R28_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R28_1 Chosen - Now Teleporting");
				playerCT.R28_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R28_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R28_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R28_1, 0.1f);
			}
		} else if (!choice_R28_1.platform_R28_1_Chosen && choice_R28_2.platform_R28_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R28_2 Chosen - Now Teleporting");
				playerCT.R28_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R28_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R28_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R28_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 29 Assets - Collision with Player Hitbox
		if (choice_R29_1.platform_R29_1_Chosen && !choice_R29_2.platform_R29_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R29_1 Chosen - Now Teleporting");
				playerCT.R29_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R29_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R29_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R29_1, 0.1f);
			}
		} else if (!choice_R29_1.platform_R29_1_Chosen && choice_R29_2.platform_R29_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R29_2 Chosen - Now Teleporting");
				playerCT.R29_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R29_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R29_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R29_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 30 Assets - Collision with Player Hitbox
		if (choice_R30_1.platform_R30_1_Chosen && !choice_R30_2.platform_R30_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R30_1 Chosen - Now Teleporting");
				playerCT.R30_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R30_1.transform.position;
				stopCarrying();
				sphere_R30_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R30_1, 0.1f);
			}
		} else if (!choice_R30_1.platform_R30_1_Chosen && choice_R30_2.platform_R30_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R30_2 Chosen - Now Teleporting");
				playerCT.R30_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R30_1.transform.position;
				stopCarrying();
				sphere_R30_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R30_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// ROOMS 31-43 - TOWER OF ROOMS

		// Room 31 Assets - Collision with Player Hitbox
		if (choice_R31_1.platform_R31_1_Chosen && !choice_R31_2.platform_R31_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R31_1 Chosen - Now Teleporting");
				playerCT.R31_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R31_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R31_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R31_1, 0.1f);
			}
		}
		else if (!choice_R31_1.platform_R31_1_Chosen && choice_R31_2.platform_R31_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R31_2 Chosen - Now Teleporting");
				playerCT.R31_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R31_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R31_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R31_1, 0.1f);
			}
		}
		else if(other.name == "Player_Position"){
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}


		// TODO : Room 32 Assets - Collision with Player Hitbox
		if (choice_R32_1.platform_R32_1_Chosen && !choice_R32_2.platform_R32_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R32_1 Chosen - Now Teleporting");
				playerCT.R32_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R32_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R32_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R32_1, 0.1f);
			}
		} else if (!choice_R32_1.platform_R32_1_Chosen && choice_R32_2.platform_R32_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R32_2 Chosen - Now Teleporting");
				playerCT.R32_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R32_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R32_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R32_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 33 Assets - Collision with Player Hitbox
		if (choice_R33_1.platform_R33_1_Chosen && !choice_R33_2.platform_R33_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R33_1 Chosen - Now Teleporting");
				playerCT.R33_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R33_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R33_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R33_1, 0.1f);
			}
		} else if (!choice_R33_1.platform_R33_1_Chosen && choice_R33_2.platform_R33_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R33_2 Chosen - Now Teleporting");
				playerCT.R33_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R33_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R33_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R33_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 34 Assets - Collision with Player Hitbox
		if (choice_R34_1.platform_R34_1_Chosen && !choice_R34_2.platform_R34_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R34_1 Chosen - Now Teleporting");
				playerCT.R34_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R34_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R34_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R34_1, 0.1f);
			}
		} else if (!choice_R34_1.platform_R34_1_Chosen && choice_R34_2.platform_R34_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R34_2 Chosen - Now Teleporting");
				playerCT.R34_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R34_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R34_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R34_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 35 Assets - Collision with Player Hitbox
		if (choice_R35_1.platform_R35_1_Chosen && !choice_R35_2.platform_R35_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R35_1 Chosen - Now Teleporting");
				playerCT.R35_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R35_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R35_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R35_1, 0.1f);
			}
		} else if (!choice_R35_1.platform_R35_1_Chosen && choice_R35_2.platform_R35_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R35_2 Chosen - Now Teleporting");
				playerCT.R35_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R35_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R35_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R35_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 36 Assets - Collision with Player Hitbox
		if (choice_R36_1.platform_R36_1_Chosen && !choice_R36_2.platform_R36_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R36_1 Chosen - Now Teleporting");
				playerCT.R36_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R36_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R36_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R36_1, 0.1f);
			}
		} else if (!choice_R36_1.platform_R36_1_Chosen && choice_R36_2.platform_R36_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R36_2 Chosen - Now Teleporting");
				playerCT.R36_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R36_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R36_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R36_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 37 Assets - Collision with Player Hitbox
		if (choice_R37_1.platform_R37_1_Chosen && !choice_R37_2.platform_R37_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R37_1 Chosen - Now Teleporting");
				playerCT.R37_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R37_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R37_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R37_1, 0.1f);
			}
		} else if (!choice_R37_1.platform_R37_1_Chosen && choice_R37_2.platform_R37_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R37_2 Chosen - Now Teleporting");
				playerCT.R37_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R37_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R37_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R37_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 38 Assets - Collision with Player Hitbox
		if (choice_R38_1.platform_R38_1_Chosen && !choice_R38_2.platform_R38_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R38_1 Chosen - Now Teleporting");
				playerCT.R38_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R38_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R38_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R38_1, 0.1f);
			}
		} else if (!choice_R38_1.platform_R38_1_Chosen && choice_R38_2.platform_R38_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R38_2 Chosen - Now Teleporting");
				playerCT.R38_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R38_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R38_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R38_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 39 Assets - Collision with Player Hitbox
		if (choice_R39_1.platform_R39_1_Chosen && !choice_R39_2.platform_R39_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R39_1 Chosen - Now Teleporting");
				playerCT.R39_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R39_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R39_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R39_1, 0.1f);
			}
		} else if (!choice_R39_1.platform_R39_1_Chosen && choice_R39_2.platform_R39_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R39_2 Chosen - Now Teleporting");
				playerCT.R39_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R39_1.transform.position;
				playerCS.RemoveTeleporterCanvas ();
				stopCarrying();
				sphere_R39_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R39_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}

		// TODO : Room 40 Assets - Collision with Player Hitbox
		if (choice_R40_1.platform_R40_1_Chosen && !choice_R40_2.platform_R40_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R40_1 Chosen - Now Teleporting");
				playerCT.R40_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R40_1.transform.position;
				stopCarrying();
				sphere_R40_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R40_1, 0.1f);
			}
		} else if (!choice_R40_1.platform_R40_1_Chosen && choice_R40_2.platform_R40_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R40_2 Chosen - Now Teleporting");
				playerCT.R40_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R40_1.transform.position;
				stopCarrying();
				sphere_R40_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R40_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}
		// TODO : Room 41 Assets - Collision with Player Hitbox
		if (choice_R41_1.platform_R41_1_Chosen && !choice_R41_2.platform_R41_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R41_1 Chosen - Now Teleporting");
				playerCT.R41_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R41_1.transform.position;
				stopCarrying();
				sphere_R41_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R41_1, 0.1f);
			}
		} else if (!choice_R41_1.platform_R41_1_Chosen && choice_R41_2.platform_R41_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R41_2 Chosen - Now Teleporting");
				playerCT.R41_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R41_1.transform.position;
				stopCarrying();
				sphere_R41_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R41_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}
		// TODO : Room 42 Assets - Collision with Player Hitbox
		if (choice_R42_1.platform_R42_1_Chosen && !choice_R42_2.platform_R42_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R42_1 Chosen - Now Teleporting");
				playerCT.R42_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R42_1.transform.position;
				stopCarrying();
				sphere_R42_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R42_1, 0.1f);
			}
		} else if (!choice_R42_1.platform_R42_1_Chosen && choice_R42_2.platform_R42_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R42_2 Chosen - Now Teleporting");
				playerCT.R42_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R42_1.transform.position;
				stopCarrying();
				sphere_R42_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R42_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}
		// TODO : Room 43 Assets - Collision with Player Hitbox
		if (choice_R43_1.platform_R43_1_Chosen && !choice_R43_2.platform_R43_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R43_1 Chosen - Now Teleporting");
				playerCT.R43_Choice_1_Taken = true;
				player.transform.position = teleporterPad_R43_1.transform.position;
				stopCarrying();
				Invoke ("onEnd", 5f);
				sphere_R43_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R43_1, 0.1f);
			}
		} else if (!choice_R43_1.platform_R43_1_Chosen && choice_R43_2.platform_R43_2_Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform R43_2 Chosen - Now Teleporting");
				playerCT.R43_Choice_2_Taken = true;
				player.transform.position = teleporterPad_R43_1.transform.position;
				stopCarrying();
				Invoke ("onEnd", 5f);
				sphere_R43_1.transform.position = Vector3.zero;
				Object.Destroy (sphere_R43_1, 0.1f);
			}
		} else if (other.name == "Player_Position") {
			if (!playerCS.teleTextIncorrect) {
				playerCS.DisplayTeleporterIncorrect ();
			}
		}
	}

	private void onEnd(){
		if (choice_R43_1 || choice_R43_2) {
			playerCS.RemoveTeleporterCanvas ();
			playerCT.RoomStatsOff ();
			playerCT.StatsOn ();
			playerCT.writeToFile ();
			playerCC.isPaused = true;
			Cursor.visible = true;
			Invoke ("backToMainMenu", 10f);
		}
	}

	private void stopCarrying(){
		playerPS.carrying = false;
	}

	private void backToMainMenu(){
		SceneManager.LoadSceneAsync ("MainMenu");
	}
}

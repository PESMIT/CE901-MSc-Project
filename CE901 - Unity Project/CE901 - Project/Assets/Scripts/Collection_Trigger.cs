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

	// ROOM EIGHT ASSETS
	GameObject platformBody_R8_1, platformBody_R8_2;
	Light platformLight_R8_1, platformLight_R8_2;
	private bool platform_R8_2_Exists;
	public bool platform_R8_1_Chosen, platform_R8_2_Chosen;

	// ROOM NINE ASSETS
	GameObject platformBody_R9_1, platformBody_R9_2;
	Light platformLight_R9_1, platformLight_R9_2;
	private bool platform_R9_2_Exists;
	public bool platform_R9_1_Chosen, platform_R9_2_Chosen;

	// ROOM TEN ASSETS
	GameObject platformBody_R10_1, platformBody_R10_2;
	Light platformLight_R10_1, platformLight_R10_2;
	private bool platform_R10_2_Exists;
	public bool platform_R10_1_Chosen, platform_R10_2_Chosen;

	// ROOMS 11 - 20

	// ROOM ELEVEN ASSETS
	GameObject platformBody_R11_1, platformBody_R11_2;
	Light platformLight_R11_1, platformLight_R11_2;
	private bool platform_R11_2_Exists;
	public bool platform_R11_1_Chosen, platform_R11_2_Chosen;

	// ROOM TWELVE ASSETS
	GameObject platformBody_R12_1, platformBody_R12_2;
	Light platformLight_R12_1, platformLight_R12_2;
	private bool platform_R12_2_Exists;
	public bool platform_R12_1_Chosen, platform_R12_2_Chosen;

	// ROOM THIRTEEN ASSETS
	GameObject platformBody_R13_1, platformBody_R13_2;
	Light platformLight_R13_1, platformLight_R13_2;
	private bool platform_R13_2_Exists;
	public bool platform_R13_1_Chosen, platform_R13_2_Chosen;

	// ROOM FOURTEEN ASSETS
	GameObject platformBody_R14_1, platformBody_R14_2;
	Light platformLight_R14_1, platformLight_R14_2;
	private bool platform_R14_2_Exists;
	public bool platform_R14_1_Chosen, platform_R14_2_Chosen;

	// ROOM FIFTHTEEN ASSETS
	GameObject platformBody_R15_1, platformBody_R15_2;
	Light platformLight_R15_1, platformLight_R15_2;
	private bool platform_R15_2_Exists;
	public bool platform_R15_1_Chosen, platform_R15_2_Chosen;

	// ROOM SIXTEEN ASSETS
	GameObject platformBody_R16_1, platformBody_R16_2;
	Light platformLight_R16_1, platformLight_R16_2;
	private bool platform_R16_2_Exists;
	public bool platform_R16_1_Chosen, platform_R16_2_Chosen;

	// ROOM SEVENTEEN ASSETS
	GameObject platformBody_R17_1, platformBody_R17_2;
	Light platformLight_R17_1, platformLight_R17_2;
	private bool platform_R17_2_Exists;
	public bool platform_R17_1_Chosen, platform_R17_2_Chosen;

	// ROOM EIGHTEEN ASSETS
	GameObject platformBody_R18_1, platformBody_R18_2;
	Light platformLight_R18_1, platformLight_R18_2;
	private bool platform_R18_2_Exists;
	public bool platform_R18_1_Chosen, platform_R18_2_Chosen;

	// ROOM NINETEEN ASSETS
	GameObject platformBody_R19_1, platformBody_R19_2;
	Light platformLight_R19_1, platformLight_R19_2;
	private bool platform_R19_2_Exists;
	public bool platform_R19_1_Chosen, platform_R19_2_Chosen;

	// ROOM TWENTY ASSETS
	GameObject platformBody_R20_1, platformBody_R20_2;
	Light platformLight_R20_1, platformLight_R20_2;
	private bool platform_R20_2_Exists;
	public bool platform_R20_1_Chosen, platform_R20_2_Chosen;

	// ROOMS 21 - 30

	// ROOM 21 ASSETS
	GameObject platformBody_R21_1, platformBody_R21_2;
	Light platformLight_R21_1, platformLight_R21_2;
	private bool platform_R21_2_Exists;
	public bool platform_R21_1_Chosen, platform_R21_2_Chosen;

	// ROOM 22 ASSETS
	GameObject platformBody_R22_1, platformBody_R22_2;
	Light platformLight_R22_1, platformLight_R22_2;
	private bool platform_R22_2_Exists;
	public bool platform_R22_1_Chosen, platform_R22_2_Chosen;

	// ROOM 23 ASSETS
	GameObject platformBody_R23_1, platformBody_R23_2;
	Light platformLight_R23_1, platformLight_R23_2;
	private bool platform_R23_2_Exists;
	public bool platform_R23_1_Chosen, platform_R23_2_Chosen;

	// ROOM 24 ASSETS
	GameObject platformBody_R24_1, platformBody_R24_2;
	Light platformLight_R24_1, platformLight_R24_2;
	private bool platform_R24_2_Exists;
	public bool platform_R24_1_Chosen, platform_R24_2_Chosen;

	// ROOM 25 ASSETS
	GameObject platformBody_R25_1, platformBody_R25_2;
	Light platformLight_R25_1, platformLight_R25_2;
	private bool platform_R25_2_Exists;
	public bool platform_R25_1_Chosen, platform_R25_2_Chosen;

	// ROOM 26 ASSETS
	GameObject platformBody_R26_1, platformBody_R26_2;
	Light platformLight_R26_1, platformLight_R26_2;
	private bool platform_R26_2_Exists;
	public bool platform_R26_1_Chosen, platform_R26_2_Chosen;

	// ROOM 27 ASSETS
	GameObject platformBody_R27_1, platformBody_R27_2;
	Light platformLight_R27_1, platformLight_R27_2;
	private bool platform_R27_2_Exists;
	public bool platform_R27_1_Chosen, platform_R27_2_Chosen;

	// ROOM 28 ASSETS
	GameObject platformBody_R28_1, platformBody_R28_2;
	Light platformLight_R28_1, platformLight_R28_2;
	private bool platform_R28_2_Exists;
	public bool platform_R28_1_Chosen, platform_R28_2_Chosen;

	// ROOM 29 ASSETS
	GameObject platformBody_R29_1, platformBody_R29_2;
	Light platformLight_R29_1, platformLight_R29_2;
	private bool platform_R29_2_Exists;
	public bool platform_R29_1_Chosen, platform_R29_2_Chosen;

	// ROOM 30 ASSETS
	GameObject platformBody_R30_1, platformBody_R30_2;
	Light platformLight_R30_1, platformLight_R30_2;
	private bool platform_R30_2_Exists;
	public bool platform_R30_1_Chosen, platform_R30_2_Chosen;

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

		// TODO: ROOM EIGHT ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R8_1")!= null){
			platformBody_R8_1 = GameObject.Find ("Platform_R8_1");
			platformLight_R8_1 = platformBody_R8_1.GetComponentInChildren<Light> ();
			platformLight_R8_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R8_2")!= null){
			platformBody_R8_2 = GameObject.Find ("Platform_R8_2");
			platformLight_R8_2 = platformBody_R8_2.GetComponentInChildren<Light> ();
			platformLight_R8_2.color = Color.blue;
			platform_R8_2_Exists = true;
		}

		// TODO: ROOM NINE ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R9_1")!= null){
			platformBody_R9_1 = GameObject.Find ("Platform_R9_1");
			platformLight_R9_1 = platformBody_R9_1.GetComponentInChildren<Light> ();
			platformLight_R9_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R9_2")!= null){
			platformBody_R9_2 = GameObject.Find ("Platform_R9_2");
			platformLight_R9_2 = platformBody_R9_2.GetComponentInChildren<Light> ();
			platformLight_R9_2.color = Color.blue;
			platform_R9_2_Exists = true;
		}

		// TODO: ROOM TEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R10_1")!= null){
			platformBody_R10_1 = GameObject.Find ("Platform_R10_1");
			platformLight_R10_1 = platformBody_R10_1.GetComponentInChildren<Light> ();
			platformLight_R10_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R10_2")!= null){
			platformBody_R10_2 = GameObject.Find ("Platform_R10_2");
			platformLight_R10_2 = platformBody_R10_2.GetComponentInChildren<Light> ();
			platformLight_R10_2.color = Color.blue;
			platform_R10_2_Exists = true;
		}

		// ROOMS 11-20 - TOWER OF ROOMS

		// ROOM ELEVEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if (GameObject.Find ("Platform_R11_1")!= null) {
			platformBody_R11_1 = GameObject.Find ("Platform_R11_1");
			platformLight_R11_1 = platformBody_R11_1.GetComponentInChildren<Light> ();
			platformLight_R11_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if (GameObject.Find ("Platform_R11_2")!= null) {
			platformBody_R11_2 = GameObject.Find ("Platform_R11_2");
			platformLight_R11_2 = platformBody_R11_2.GetComponentInChildren<Light> ();
			platformLight_R11_2.color = Color.blue;
			platform_R11_2_Exists = true;
		}

		// TODO: ROOM TWELVE ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R12_1")!= null){
			platformBody_R12_1 = GameObject.Find ("Platform_R12_1");
			platformLight_R12_1 = platformBody_R12_1.GetComponentInChildren<Light> ();
			platformLight_R12_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R12_2")!= null){
			platformBody_R12_2 = GameObject.Find ("Platform_R12_2");
			platformLight_R12_2 = platformBody_R12_2.GetComponentInChildren<Light> ();
			platformLight_R12_2.color = Color.blue;
			platform_R12_2_Exists = true;
		}

		// TODO: ROOM THIRTEEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R13_1")!= null){
			platformBody_R13_1 = GameObject.Find ("Platform_R13_1");
			platformLight_R13_1 = platformBody_R13_1.GetComponentInChildren<Light> ();
			platformLight_R13_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R13_2")!= null){
			platformBody_R13_2 = GameObject.Find ("Platform_R13_2");
			platformLight_R13_2 = platformBody_R13_2.GetComponentInChildren<Light> ();
			platformLight_R13_2.color = Color.blue;
			platform_R13_2_Exists = true;
		}

		// TODO: ROOM FOURTEEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R14_1")!= null){
			platformBody_R14_1 = GameObject.Find ("Platform_R14_1");
			platformLight_R14_1 = platformBody_R14_1.GetComponentInChildren<Light> ();
			platformLight_R14_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R14_2")!= null){
			platformBody_R14_2 = GameObject.Find ("Platform_R14_2");
			platformLight_R14_2 = platformBody_R14_2.GetComponentInChildren<Light> ();
			platformLight_R14_2.color = Color.blue;
			platform_R14_2_Exists = true;
		}

		// TODO: ROOM FIFTHTEEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R15_1")!= null){
			platformBody_R15_1 = GameObject.Find ("Platform_R15_1");
			platformLight_R15_1 = platformBody_R15_1.GetComponentInChildren<Light> ();
			platformLight_R15_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R15_2")!= null){
			platformBody_R15_2 = GameObject.Find ("Platform_R15_2");
			platformLight_R15_2 = platformBody_R15_2.GetComponentInChildren<Light> ();
			platformLight_R15_2.color = Color.blue;
			platform_R15_2_Exists = true;
		}
		// TODO: ROOM SIXTEEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R16_1")!= null){
			platformBody_R16_1 = GameObject.Find ("Platform_R16_1");
			platformLight_R16_1 = platformBody_R16_1.GetComponentInChildren<Light> ();
			platformLight_R16_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R16_2")!= null){
			platformBody_R16_2 = GameObject.Find ("Platform_R16_2");
			platformLight_R16_2 = platformBody_R16_2.GetComponentInChildren<Light> ();
			platformLight_R16_2.color = Color.blue;
			platform_R16_2_Exists = true;
		}
		// TODO: ROOM SEVENTEEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R17_1")!= null){
			platformBody_R17_1 = GameObject.Find ("Platform_R17_1");
			platformLight_R17_1 = platformBody_R17_1.GetComponentInChildren<Light> ();
			platformLight_R17_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R17_2")!= null){
			platformBody_R17_2 = GameObject.Find ("Platform_R17_2");
			platformLight_R17_2 = platformBody_R17_2.GetComponentInChildren<Light> ();
			platformLight_R17_2.color = Color.blue;
			platform_R17_2_Exists = true;
		}

		// TODO: ROOM EIGHTEEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R18_1")!= null){
			platformBody_R18_1 = GameObject.Find ("Platform_R18_1");
			platformLight_R18_1 = platformBody_R18_1.GetComponentInChildren<Light> ();
			platformLight_R18_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R18_2")!= null){
			platformBody_R18_2 = GameObject.Find ("Platform_R18_2");
			platformLight_R18_2 = platformBody_R18_2.GetComponentInChildren<Light> ();
			platformLight_R18_2.color = Color.blue;
			platform_R18_2_Exists = true;
		}

		// TODO: ROOM NINETEEN ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R19_1")!= null){
			platformBody_R19_1 = GameObject.Find ("Platform_R19_1");
			platformLight_R19_1 = platformBody_R19_1.GetComponentInChildren<Light> ();
			platformLight_R19_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R19_2")!= null){
			platformBody_R19_2 = GameObject.Find ("Platform_R19_2");
			platformLight_R19_2 = platformBody_R19_2.GetComponentInChildren<Light> ();
			platformLight_R19_2.color = Color.blue;
			platform_R19_2_Exists = true;
		}

		// TODO: ROOM TWENTY ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R20_1")!= null){
			platformBody_R20_1 = GameObject.Find ("Platform_R20_1");
			platformLight_R20_1 = platformBody_R20_1.GetComponentInChildren<Light> ();
			platformLight_R20_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R20_2")!= null){
			platformBody_R20_2 = GameObject.Find ("Platform_R20_2");
			platformLight_R20_2 = platformBody_R20_2.GetComponentInChildren<Light> ();
			platformLight_R20_2.color = Color.blue;
			platform_R20_2_Exists = true;
		}

		// ROOMS 21-30 - TOWER OF ROOMS

		// ROOM 21 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if (GameObject.Find ("Platform_R21_1")!= null) {
			platformBody_R21_1 = GameObject.Find ("Platform_R21_1");
			platformLight_R21_1 = platformBody_R21_1.GetComponentInChildren<Light> ();
			platformLight_R21_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if (GameObject.Find ("Platform_R21_2")!= null) {
			platformBody_R21_2 = GameObject.Find ("Platform_R21_2");
			platformLight_R21_2 = platformBody_R21_2.GetComponentInChildren<Light> ();
			platformLight_R21_2.color = Color.blue;
			platform_R21_2_Exists = true;
		}

		// TODO: ROOM 22 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R22_1")!= null){
			platformBody_R22_1 = GameObject.Find ("Platform_R22_1");
			platformLight_R22_1 = platformBody_R22_1.GetComponentInChildren<Light> ();
			platformLight_R22_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R22_2")!= null){
			platformBody_R22_2 = GameObject.Find ("Platform_R22_2");
			platformLight_R22_2 = platformBody_R22_2.GetComponentInChildren<Light> ();
			platformLight_R22_2.color = Color.blue;
			platform_R22_2_Exists = true;
		}

		// TODO: ROOM 23 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R23_1")!= null){
			platformBody_R23_1 = GameObject.Find ("Platform_R23_1");
			platformLight_R23_1 = platformBody_R23_1.GetComponentInChildren<Light> ();
			platformLight_R23_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R23_2")!= null){
			platformBody_R23_2 = GameObject.Find ("Platform_R23_2");
			platformLight_R23_2 = platformBody_R23_2.GetComponentInChildren<Light> ();
			platformLight_R23_2.color = Color.blue;
			platform_R23_2_Exists = true;
		}

		// TODO: ROOM 24 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R24_1")!= null){
			platformBody_R24_1 = GameObject.Find ("Platform_R24_1");
			platformLight_R24_1 = platformBody_R24_1.GetComponentInChildren<Light> ();
			platformLight_R24_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R24_2")!= null){
			platformBody_R24_2 = GameObject.Find ("Platform_R24_2");
			platformLight_R24_2 = platformBody_R24_2.GetComponentInChildren<Light> ();
			platformLight_R24_2.color = Color.blue;
			platform_R24_2_Exists = true;
		}

		// TODO: ROOM 25 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R25_1")!= null){
			platformBody_R25_1 = GameObject.Find ("Platform_R25_1");
			platformLight_R25_1 = platformBody_R25_1.GetComponentInChildren<Light> ();
			platformLight_R25_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R25_2")!= null){
			platformBody_R25_2 = GameObject.Find ("Platform_R25_2");
			platformLight_R25_2 = platformBody_R25_2.GetComponentInChildren<Light> ();
			platformLight_R25_2.color = Color.blue;
			platform_R25_2_Exists = true;
		}
		// TODO: ROOM 26 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R26_1")!= null){
			platformBody_R26_1 = GameObject.Find ("Platform_R26_1");
			platformLight_R26_1 = platformBody_R26_1.GetComponentInChildren<Light> ();
			platformLight_R26_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R26_2")!= null){
			platformBody_R26_2 = GameObject.Find ("Platform_R26_2");
			platformLight_R26_2 = platformBody_R26_2.GetComponentInChildren<Light> ();
			platformLight_R26_2.color = Color.blue;
			platform_R26_2_Exists = true;
		}
		// TODO: ROOM 27 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R27_1")!= null){
			platformBody_R27_1 = GameObject.Find ("Platform_R27_1");
			platformLight_R27_1 = platformBody_R27_1.GetComponentInChildren<Light> ();
			platformLight_R27_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R27_2")!= null){
			platformBody_R27_2 = GameObject.Find ("Platform_R27_2");
			platformLight_R27_2 = platformBody_R27_2.GetComponentInChildren<Light> ();
			platformLight_R27_2.color = Color.blue;
			platform_R27_2_Exists = true;
		}

		// TODO: ROOM 28 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R28_1")!= null){
			platformBody_R28_1 = GameObject.Find ("Platform_R28_1");
			platformLight_R28_1 = platformBody_R28_1.GetComponentInChildren<Light> ();
			platformLight_R28_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R28_2")!= null){
			platformBody_R28_2 = GameObject.Find ("Platform_R28_2");
			platformLight_R28_2 = platformBody_R28_2.GetComponentInChildren<Light> ();
			platformLight_R28_2.color = Color.blue;
			platform_R28_2_Exists = true;
		}

		// TODO: ROOM 29 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R29_1")!= null){
			platformBody_R29_1 = GameObject.Find ("Platform_R29_1");
			platformLight_R29_1 = platformBody_R29_1.GetComponentInChildren<Light> ();
			platformLight_R29_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R29_2")!= null){
			platformBody_R29_2 = GameObject.Find ("Platform_R29_2");
			platformLight_R29_2 = platformBody_R29_2.GetComponentInChildren<Light> ();
			platformLight_R29_2.color = Color.blue;
			platform_R29_2_Exists = true;
		}

		// TODO: ROOM 30 ASSET REFERENCE
		// Platform 1 - RIGHT SIDE
		if(GameObject.Find("Platform_R30_1")!= null){
			platformBody_R30_1 = GameObject.Find ("Platform_R30_1");
			platformLight_R30_1 = platformBody_R30_1.GetComponentInChildren<Light> ();
			platformLight_R30_1.color = Color.blue;
		}
		// Platform 2 - LEFT SIDE
		if(GameObject.Find("Platform_R30_2")!= null){
			platformBody_R30_2 = GameObject.Find ("Platform_R30_2");
			platformLight_R30_2 = platformBody_R30_2.GetComponentInChildren<Light> ();
			platformLight_R30_2.color = Color.blue;
			platform_R30_2_Exists = true;
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

		// TODO: ROOM EIGHT - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R8_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R8_1.color = Color.green;
				platform_R8_1_Chosen = true;
				if (platform_R8_2_Exists) {
					platformLight_R8_2.color = Color.red;
					platform_R8_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R8_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R8_1.color = Color.red;
				platform_R8_1_Chosen = false;
				if (platform_R8_2_Exists) {
					platformLight_R8_2.color = Color.green;
					platform_R8_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM NINE - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R9_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R9_1.color = Color.green;
				platform_R9_1_Chosen = true;
				if (platform_R9_2_Exists) {
					platformLight_R9_2.color = Color.red;
					platform_R9_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R9_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R9_1.color = Color.red;
				platform_R9_1_Chosen = false;
				if (platform_R9_2_Exists) {
					platformLight_R9_2.color = Color.green;
					platform_R9_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM TEN - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R10_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R10_1.color = Color.green;
				platform_R10_1_Chosen = true;
				if (platform_R10_2_Exists) {
					platformLight_R10_2.color = Color.red;
					platform_R10_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R10_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R10_1.color = Color.red;
				platform_R10_1_Chosen = false;
				if (platform_R10_2_Exists) {
					platformLight_R10_2.color = Color.green;
					platform_R10_2_Chosen = true;
				}
			}
		}

		// ROOMS 11-20 - TOWER OF ROOMS

		// ROOM ELEVEN - TRIGGER COLLISIONS
		if (other.tag == "Objects") {
			if (this.gameObject.name == "Platform_R11_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R11_1.color = Color.green;
				platform_R11_1_Chosen = true;
				if (platform_R11_2_Exists) {
					platformLight_R11_2.color = Color.red;
					platform_R11_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R11_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R11_1.color = Color.red;
				platform_R11_1_Chosen = false;
				if (platform_R11_2_Exists) {
					platformLight_R11_2.color = Color.green;
					platform_R11_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM TWELVE - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R12_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R12_1.color = Color.green;
				platform_R12_1_Chosen = true;
				if (platform_R12_2_Exists) {
					platformLight_R12_2.color = Color.red;
					platform_R12_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R12_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R12_1.color = Color.red;
				platform_R12_1_Chosen = false;
				if (platform_R12_2_Exists) {
					platformLight_R12_2.color = Color.green;
					platform_R12_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM THIRTEEN - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R13_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R13_1.color = Color.green;
				platform_R13_1_Chosen = true;
				if (platform_R13_2_Exists) {
					platformLight_R13_2.color = Color.red;
					platform_R13_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R13_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R13_1.color = Color.red;
				platform_R13_1_Chosen = false;
				if (platform_R13_2_Exists) {
					platformLight_R13_2.color = Color.green;
					platform_R13_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM FOURTEEN - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R14_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R14_1.color = Color.green;
				platform_R14_1_Chosen = true;
				if (platform_R14_2_Exists) {
					platformLight_R14_2.color = Color.red;
					platform_R14_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R14_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R14_1.color = Color.red;
				platform_R14_1_Chosen = false;
				if (platform_R14_2_Exists) {
					platformLight_R14_2.color = Color.green;
					platform_R14_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM FIFTHTEEN - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R15_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R15_1.color = Color.green;
				platform_R15_1_Chosen = true;
				if (platform_R15_2_Exists) {
					platformLight_R15_2.color = Color.red;
					platform_R15_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R15_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R15_1.color = Color.red;
				platform_R15_1_Chosen = false;
				if (platform_R15_2_Exists) {
					platformLight_R15_2.color = Color.green;
					platform_R15_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM SIXTEEN - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R16_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R16_1.color = Color.green;
				platform_R16_1_Chosen = true;
				if (platform_R16_2_Exists) {
					platformLight_R16_2.color = Color.red;
					platform_R16_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R16_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R16_1.color = Color.red;
				platform_R16_1_Chosen = false;
				if (platform_R16_2_Exists) {
					platformLight_R16_2.color = Color.green;
					platform_R16_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM SEVENTEEN - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R17_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R17_1.color = Color.green;
				platform_R17_1_Chosen = true;
				if (platform_R17_2_Exists) {
					platformLight_R17_2.color = Color.red;
					platform_R17_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R17_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R17_1.color = Color.red;
				platform_R17_1_Chosen = false;
				if (platform_R17_2_Exists) {
					platformLight_R17_2.color = Color.green;
					platform_R17_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM EIGHTEEN - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R18_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R18_1.color = Color.green;
				platform_R18_1_Chosen = true;
				if (platform_R18_2_Exists) {
					platformLight_R18_2.color = Color.red;
					platform_R18_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R18_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R18_1.color = Color.red;
				platform_R18_1_Chosen = false;
				if (platform_R18_2_Exists) {
					platformLight_R18_2.color = Color.green;
					platform_R18_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM NINETEEN - TRIGGER COLLISIONS
		if(other.tag == "Objects"){
			if (this.gameObject.name == "Platform_R19_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R19_1.color = Color.green;
				platform_R19_1_Chosen = true;
				if (platform_R19_2_Exists) {
					platformLight_R19_2.color = Color.red;
					platform_R19_2_Chosen = false;
				}
			} else if(this.gameObject.name == "Platform_R19_2"){
				csScript.RemoveTutorialOne ();
				platformLight_R19_1.color = Color.red;
				platform_R19_1_Chosen = false;
				if (platform_R19_2_Exists) {
					platformLight_R19_2.color = Color.green;
					platform_R19_2_Chosen = true;
				}
			}
		}

		// TODO: ROOM TWENTY - TRIGGER COLLISIONS
		if (other.tag == "Objects") {
			if (this.gameObject.name == "Platform_R20_1") {
				csScript.RemoveTutorialOne ();
				platformLight_R20_1.color = Color.green;
				platform_R20_1_Chosen = true;
				if (platform_R20_2_Exists) {
					platformLight_R20_2.color = Color.red;
					platform_R20_2_Chosen = false;
				}
			} else if (this.gameObject.name == "Platform_R20_2") {
				csScript.RemoveTutorialOne ();
				platformLight_R20_1.color = Color.red;
				platform_R20_1_Chosen = false;
				if (platform_R20_2_Exists) {
					platformLight_R20_2.color = Color.green;
					platform_R20_2_Chosen = true;
				}
			}

			// ROOMS 21-30 - TOWER OF ROOMS

			// ROOM 21 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R21_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R21_1.color = Color.green;
					platform_R21_1_Chosen = true;
					if (platform_R21_2_Exists) {
						platformLight_R21_2.color = Color.red;
						platform_R21_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R21_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R21_1.color = Color.red;
					platform_R21_1_Chosen = false;
					if (platform_R21_2_Exists) {
						platformLight_R21_2.color = Color.green;
						platform_R21_2_Chosen = true;
					}
				}
			}

			// TODO: ROOM 22 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R22_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R22_1.color = Color.green;
					platform_R22_1_Chosen = true;
					if (platform_R22_2_Exists) {
						platformLight_R22_2.color = Color.red;
						platform_R22_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R22_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R22_1.color = Color.red;
					platform_R22_1_Chosen = false;
					if (platform_R22_2_Exists) {
						platformLight_R22_2.color = Color.green;
						platform_R22_2_Chosen = true;
					}
				}
			}

			// TODO: ROOM 23 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R23_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R23_1.color = Color.green;
					platform_R23_1_Chosen = true;
					if (platform_R23_2_Exists) {
						platformLight_R23_2.color = Color.red;
						platform_R23_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R23_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R23_1.color = Color.red;
					platform_R23_1_Chosen = false;
					if (platform_R23_2_Exists) {
						platformLight_R23_2.color = Color.green;
						platform_R23_2_Chosen = true;
					}
				}
			}

			// TODO: ROOM 24 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R24_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R24_1.color = Color.green;
					platform_R24_1_Chosen = true;
					if (platform_R24_2_Exists) {
						platformLight_R24_2.color = Color.red;
						platform_R24_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R24_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R24_1.color = Color.red;
					platform_R24_1_Chosen = false;
					if (platform_R24_2_Exists) {
						platformLight_R24_2.color = Color.green;
						platform_R24_2_Chosen = true;
					}
				}
			}

			// TODO: ROOM 25 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R25_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R25_1.color = Color.green;
					platform_R25_1_Chosen = true;
					if (platform_R25_2_Exists) {
						platformLight_R25_2.color = Color.red;
						platform_R25_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R25_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R25_1.color = Color.red;
					platform_R25_1_Chosen = false;
					if (platform_R25_2_Exists) {
						platformLight_R25_2.color = Color.green;
						platform_R25_2_Chosen = true;
					}
				}
			}

			// TODO: ROOM 26 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R26_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R26_1.color = Color.green;
					platform_R26_1_Chosen = true;
					if (platform_R26_2_Exists) {
						platformLight_R26_2.color = Color.red;
						platform_R26_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R26_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R26_1.color = Color.red;
					platform_R26_1_Chosen = false;
					if (platform_R26_2_Exists) {
						platformLight_R26_2.color = Color.green;
						platform_R26_2_Chosen = true;
					}
				}
			}

			// TODO: ROOM 27 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R27_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R27_1.color = Color.green;
					platform_R27_1_Chosen = true;
					if (platform_R27_2_Exists) {
						platformLight_R27_2.color = Color.red;
						platform_R27_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R27_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R27_1.color = Color.red;
					platform_R27_1_Chosen = false;
					if (platform_R27_2_Exists) {
						platformLight_R27_2.color = Color.green;
						platform_R27_2_Chosen = true;
					}
				}
			}

			// TODO: ROOM 28 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R28_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R28_1.color = Color.green;
					platform_R28_1_Chosen = true;
					if (platform_R28_2_Exists) {
						platformLight_R28_2.color = Color.red;
						platform_R28_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R28_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R28_1.color = Color.red;
					platform_R28_1_Chosen = false;
					if (platform_R28_2_Exists) {
						platformLight_R28_2.color = Color.green;
						platform_R28_2_Chosen = true;
					}
				}
			}

			// TODO: ROOM 29 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R29_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R29_1.color = Color.green;
					platform_R29_1_Chosen = true;
					if (platform_R29_2_Exists) {
						platformLight_R29_2.color = Color.red;
						platform_R29_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R29_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R29_1.color = Color.red;
					platform_R29_1_Chosen = false;
					if (platform_R29_2_Exists) {
						platformLight_R29_2.color = Color.green;
						platform_R29_2_Chosen = true;
					}
				}
			}

			// TODO: ROOM 30 - TRIGGER COLLISIONS
			if (other.tag == "Objects") {
				if (this.gameObject.name == "Platform_R30_1") {
					csScript.RemoveTutorialOne ();
					platformLight_R30_1.color = Color.green;
					platform_R30_1_Chosen = true;
					if (platform_R30_2_Exists) {
						platformLight_R30_2.color = Color.red;
						platform_R30_2_Chosen = false;
					}
				} else if (this.gameObject.name == "Platform_R30_2") {
					csScript.RemoveTutorialOne ();
					platformLight_R30_1.color = Color.red;
					platform_R30_1_Chosen = false;
					if (platform_R30_2_Exists) {
						platformLight_R30_2.color = Color.green;
						platform_R30_2_Chosen = true;
					}
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

		// TODO: ROOM EIGHT - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R8_1" || this.gameObject.name == "Platform_R8_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R8_1.color = Color.white;
			platform_R8_1_Chosen = false;
			if (platform_R8_2_Exists) {
				platformLight_R8_2.color = Color.white;
				platform_R8_2_Chosen = false;
			}
		}

		// TODO: ROOM NINE - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R9_1" || this.gameObject.name == "Platform_R9_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R9_1.color = Color.white;
			platform_R9_1_Chosen = false;
			if (platform_R9_2_Exists) {
				platformLight_R9_2.color = Color.white;
				platform_R9_2_Chosen = false;
			}
		}

		// TODO: ROOM TEN - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R10_1" || this.gameObject.name == "Platform_R10_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R10_1.color = Color.white;
			platform_R10_1_Chosen = false;
			if (platform_R10_2_Exists) {
				platformLight_R10_2.color = Color.white;
				platform_R10_2_Chosen = false;
			}
		}

		// ROOMS 11-20 - TOWER OF ROOMS

		// ROOM ELEVEN - TRIGGER EXITS
		if (other.tag == "Objects" && this.gameObject.name == "Platform_R11_1" || this.gameObject.name == "Platform_R11_2") {
			csScript.RemoveTeleporterCanvas ();
			platformLight_R11_1.color = Color.white;
			platform_R11_1_Chosen = false;
			if (platform_R11_2_Exists) {
				platformLight_R11_2.color = Color.white;
				platform_R11_2_Chosen = false;
			}
		}

		// TODO: ROOM TWELVE - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R12_1" || this.gameObject.name == "Platform_R12_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R12_1.color = Color.white;
			platform_R12_1_Chosen = false;
			if (platform_R12_2_Exists) {
				platformLight_R12_2.color = Color.white;
				platform_R12_2_Chosen = false;
			}
		}

		// TODO: ROOM THIRTEEN - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R13_1" || this.gameObject.name == "Platform_R13_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R13_1.color = Color.white;
			platform_R13_1_Chosen = false;
			if (platform_R13_2_Exists) {
				platformLight_R13_2.color = Color.white;
				platform_R13_2_Chosen = false;
			}
		}

		// TODO: ROOM FOURTEEN - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R14_1" || this.gameObject.name == "Platform_R14_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R14_1.color = Color.white;
			platform_R14_1_Chosen = false;
			if (platform_R14_2_Exists) {
				platformLight_R14_2.color = Color.white;
				platform_R14_2_Chosen = false;
			}
		}

		// TODO: ROOM FIFTHTEEN - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R15_1" || this.gameObject.name == "Platform_R15_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R15_1.color = Color.white;
			platform_R15_1_Chosen = false;
			if (platform_R15_2_Exists) {
				platformLight_R15_2.color = Color.white;
				platform_R15_2_Chosen = false;
			}
		}

		// TODO: ROOM SIXTEEN - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R16_1" || this.gameObject.name == "Platform_R16_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R16_1.color = Color.white;
			platform_R16_1_Chosen = false;
			if (platform_R16_2_Exists) {
				platformLight_R16_2.color = Color.white;
				platform_R16_2_Chosen = false;
			}
		}

		// TODO: ROOM SEVENTEEN - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R17_1" || this.gameObject.name == "Platform_R17_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R17_1.color = Color.white;
			platform_R17_1_Chosen = false;
			if (platform_R17_2_Exists) {
				platformLight_R17_2.color = Color.white;
				platform_R17_2_Chosen = false;
			}
		}

		// TODO: ROOM EIGHTEEN - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R18_1" || this.gameObject.name == "Platform_R18_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R18_1.color = Color.white;
			platform_R18_1_Chosen = false;
			if (platform_R18_2_Exists) {
				platformLight_R18_2.color = Color.white;
				platform_R18_2_Chosen = false;
			}
		}

		// TODO: ROOM NINETEEN - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R19_1" || this.gameObject.name == "Platform_R19_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R19_1.color = Color.white;
			platform_R19_1_Chosen = false;
			if (platform_R19_2_Exists) {
				platformLight_R19_2.color = Color.white;
				platform_R19_2_Chosen = false;
			}
		}

		// TODO: ROOM TWENTY - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R20_1" || this.gameObject.name == "Platform_R20_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R20_1.color = Color.white;
			platform_R20_1_Chosen = false;
			if (platform_R20_2_Exists) {
				platformLight_R20_2.color = Color.white;
				platform_R20_2_Chosen = false;
			}
		}

		// ROOMS 21-30 - TOWER OF ROOMS

		// ROOM 21 - TRIGGER EXITS
		if (other.tag == "Objects" && this.gameObject.name == "Platform_R21_1" || this.gameObject.name == "Platform_R21_2") {
			csScript.RemoveTeleporterCanvas ();
			platformLight_R21_1.color = Color.white;
			platform_R21_1_Chosen = false;
			if (platform_R21_2_Exists) {
				platformLight_R21_2.color = Color.white;
				platform_R21_2_Chosen = false;
			}
		}

		// TODO: ROOM 22 - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R22_1" || this.gameObject.name == "Platform_R22_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R22_1.color = Color.white;
			platform_R22_1_Chosen = false;
			if (platform_R22_2_Exists) {
				platformLight_R22_2.color = Color.white;
				platform_R22_2_Chosen = false;
			}
		}

		// TODO: ROOM 23 - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R23_1" || this.gameObject.name == "Platform_R23_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R23_1.color = Color.white;
			platform_R23_1_Chosen = false;
			if (platform_R23_2_Exists) {
				platformLight_R23_2.color = Color.white;
				platform_R23_2_Chosen = false;
			}
		}

		// TODO: ROOM 24 - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R24_1" || this.gameObject.name == "Platform_R24_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R24_1.color = Color.white;
			platform_R24_1_Chosen = false;
			if (platform_R24_2_Exists) {
				platformLight_R24_2.color = Color.white;
				platform_R24_2_Chosen = false;
			}
		}

		// TODO: ROOM 25 - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R25_1" || this.gameObject.name == "Platform_R25_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R25_1.color = Color.white;
			platform_R25_1_Chosen = false;
			if (platform_R25_2_Exists) {
				platformLight_R25_2.color = Color.white;
				platform_R25_2_Chosen = false;
			}
		}

		// TODO: ROOM 26 - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R26_1" || this.gameObject.name == "Platform_R26_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R26_1.color = Color.white;
			platform_R26_1_Chosen = false;
			if (platform_R26_2_Exists) {
				platformLight_R26_2.color = Color.white;
				platform_R26_2_Chosen = false;
			}
		}

		// TODO: ROOM 27 - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R27_1" || this.gameObject.name == "Platform_R27_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R27_1.color = Color.white;
			platform_R27_1_Chosen = false;
			if (platform_R27_2_Exists) {
				platformLight_R27_2.color = Color.white;
				platform_R27_2_Chosen = false;
			}
		}

		// TODO: ROOM 28 - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R28_1" || this.gameObject.name == "Platform_R28_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R28_1.color = Color.white;
			platform_R28_1_Chosen = false;
			if (platform_R28_2_Exists) {
				platformLight_R28_2.color = Color.white;
				platform_R28_2_Chosen = false;
			}
		}

		// TODO: ROOM 29 - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R29_1" || this.gameObject.name == "Platform_R29_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R29_1.color = Color.white;
			platform_R29_1_Chosen = false;
			if (platform_R29_2_Exists) {
				platformLight_R29_2.color = Color.white;
				platform_R29_2_Chosen = false;
			}
		}

		// TODO: ROOM 30 - TRIGGER EXITS
		if(other.tag == "Objects" && this.gameObject.name == "Platform_R30_1" || this.gameObject.name == "Platform_R30_2"){
			csScript.RemoveTeleporterCanvas ();
			platformLight_R30_1.color = Color.white;
			platform_R30_1_Chosen = false;
			if (platform_R30_2_Exists) {
				platformLight_R30_2.color = Color.white;
				platform_R30_2_Chosen = false;
			}
		}
	}
}

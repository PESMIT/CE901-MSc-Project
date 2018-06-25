using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice_Tracker : MonoBehaviour {

	// Room 1 Choices
	public bool R1_Choice_1_Taken, R1_Choice_2_Taken;
	// Room 2 Choices
	public bool R2_Choice_1_Taken, R2_Choice_2_Taken;
	// Room 3 Choices
	public bool R3_Choice_1_Taken, R3_Choice_2_Taken;
	// Room 4 Choices
	public bool R4_Choice_1_Taken, R4_Choice_2_Taken;
	// Room 5 Choices
	public bool R5_Choice_1_Taken, R5_Choice_2_Taken;
	// Room 6 Choices
	public bool R6_Choice_1_Taken, R6_Choice_2_Taken;
	// Room 7 Choices
	public bool R7_Choice_1_Taken, R7_Choice_2_Taken;
	// Room 8 Choices
	public bool R8_Choice_1_Taken, R8_Choice_2_Taken;
	// Room 9 Choices
	public bool R9_Choice_1_Taken, R9_Choice_2_Taken;
	// Room 10 Choices
	public bool R10_Choice_1_Taken, R10_Choice_2_Taken;

	private Text choiceText, room1ChoiceText, room2ChoiceText, room3ChoiceText, room4ChoiceText, room5ChoiceText, room6ChoiceText, room7ChoiceText, room8ChoiceText, room9ChoiceText, room10ChoiceText;

	// Use this for initialization
	void Start () {
		// Room 1
		R1_Choice_1_Taken = false;
		R1_Choice_2_Taken = false;
		// Room 2
		R2_Choice_1_Taken = false;
		R2_Choice_2_Taken = false;
		// Room 3
		R3_Choice_1_Taken = false;
		R3_Choice_2_Taken = false;
		// Room 4
		R4_Choice_1_Taken = false;
		R4_Choice_2_Taken = false;
		// Room 5
		R5_Choice_1_Taken = false;
		R5_Choice_2_Taken = false;
		// Room 6
		R6_Choice_1_Taken = false;
		R6_Choice_2_Taken = false;
		// Room 7
		R7_Choice_1_Taken = false;
		R7_Choice_2_Taken = false;
		// Room 8
		R8_Choice_1_Taken = false;
		R8_Choice_2_Taken = false;
		// Room 9
		R9_Choice_1_Taken = false;
		R9_Choice_2_Taken = false;
		// Room 10
		R10_Choice_1_Taken = false;
		R10_Choice_2_Taken = false;

		// Text Update
		room1ChoiceText = GameObject.Find("Room 1 Choice Text").GetComponent<Text>();
		room2ChoiceText = GameObject.Find("Room 2 Choice Text").GetComponent<Text>();
		room3ChoiceText = GameObject.Find("Room 3 Choice Text").GetComponent<Text>();
		room4ChoiceText = GameObject.Find("Room 4 Choice Text").GetComponent<Text>();
		room5ChoiceText = GameObject.Find("Room 5 Choice Text").GetComponent<Text>();
		room6ChoiceText = GameObject.Find("Room 6 Choice Text").GetComponent<Text>();
		room7ChoiceText = GameObject.Find("Room 7 Choice Text").GetComponent<Text>();
		room8ChoiceText = GameObject.Find("Room 8 Choice Text").GetComponent<Text>();
		room9ChoiceText = GameObject.Find("Room 9 Choice Text").GetComponent<Text>();
		room10ChoiceText = GameObject.Find("Room 10 Choice Text").GetComponent<Text>();
		//choiceText = GameObject.Find("Choice Text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		// ROOM 1 (Tutorial)
		if (R1_Choice_1_Taken && !R1_Choice_2_Taken) {
			room1ChoiceText.text = "ROOM 1 - CHOSE RIGHT";
		} else if (!R1_Choice_1_Taken && R1_Choice_2_Taken) {
			room1ChoiceText.text = "ROOM 1 - CHOSE LEFT";
		}
		// ROOM 2 (Blue and Red)
		if (R2_Choice_1_Taken && !R2_Choice_2_Taken) {
			room2ChoiceText.text = "ROOM 2 - CHOSE BLUE";
		} else if (!R2_Choice_1_Taken && R2_Choice_2_Taken) {
			room2ChoiceText.text = "ROOM 2 - CHOSE RED";
		}
		// ROOM 3 (Blue and Red 2)
		if (R3_Choice_1_Taken && !R3_Choice_2_Taken) {
			room3ChoiceText.text = "ROOM 3 - CHOSE BLUE";
		} else if (!R3_Choice_1_Taken && R3_Choice_2_Taken) {
			room3ChoiceText.text = "ROOM 3 - CHOSE RED";
		}
		// ROOM 4 (Blue and Red Final)
		if (R4_Choice_1_Taken && !R4_Choice_2_Taken) {
			room4ChoiceText.text = "ROOM 4 - CHOSE BLUE";
		} else if (!R4_Choice_1_Taken && R4_Choice_2_Taken) {
			room4ChoiceText.text = "ROOM 4 - CHOSE RED";
		}
		// ROOM 5 (Green and Blue)
		if (R5_Choice_1_Taken && !R5_Choice_2_Taken) {
			room5ChoiceText.text = "ROOM 5 - CHOSE GREEN";
		} else if (!R5_Choice_1_Taken && R5_Choice_2_Taken) {
			room5ChoiceText.text = "ROOM 5 - CHOSE BLUE";
		}
		// ROOM 6 (Green and Blue 2)
		if (R6_Choice_1_Taken && !R6_Choice_2_Taken) {
			room6ChoiceText.text = "ROOM 6 - CHOSE GREEN";
		} else if (!R6_Choice_1_Taken && R6_Choice_2_Taken) {
			room6ChoiceText.text = "ROOM 6 - CHOSE BLUE";
		}
		// ROOM 7 (Green and Blue Final)
		if (R7_Choice_1_Taken && !R7_Choice_2_Taken) {
			room7ChoiceText.text = "ROOM 7 - CHOSE GREEN";
		} else if (!R7_Choice_1_Taken && R7_Choice_2_Taken) {
			room7ChoiceText.text = "ROOM 7 - CHOSE BLUE";
		}
		// ROOM 8 (Green and Red)
		if (R8_Choice_1_Taken && !R8_Choice_2_Taken) {
			room8ChoiceText.text = "ROOM 8 - CHOSE GREEN";
		} else if (!R8_Choice_1_Taken && R8_Choice_2_Taken) {
			room8ChoiceText.text = "ROOM 8 - CHOSE BLUE";
		}
		// ROOM 9 (Green and Red)
		if (R9_Choice_1_Taken && !R9_Choice_2_Taken) {
			room9ChoiceText.text = "ROOM 9 - CHOSE GREEN";
		} else if (!R9_Choice_1_Taken && R9_Choice_2_Taken) {
			room9ChoiceText.text = "ROOM 9 - CHOSE BLUE";
		}
		// ROOM 10 (Green and Red)
		if (R10_Choice_1_Taken && !R10_Choice_2_Taken) {
			room10ChoiceText.text = "ROOM 10 - CHOSE GREEN";
		} else if (!R10_Choice_1_Taken && R10_Choice_2_Taken) {
			room10ChoiceText.text = "ROOM 10 - CHOSE BLUE";
		}

	}
}

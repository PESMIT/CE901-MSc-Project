using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Choice_Tracker : MonoBehaviour {

	// Rooms 1-10
	public bool R1_Choice_1_Taken, R1_Choice_2_Taken;
	public bool R2_Choice_1_Taken, R2_Choice_2_Taken;
	public bool R3_Choice_1_Taken, R3_Choice_2_Taken;
	public bool R4_Choice_1_Taken, R4_Choice_2_Taken;
	public bool R5_Choice_1_Taken, R5_Choice_2_Taken;
	public bool R6_Choice_1_Taken, R6_Choice_2_Taken;
	public bool R7_Choice_1_Taken, R7_Choice_2_Taken;
	public bool R8_Choice_1_Taken, R8_Choice_2_Taken;
	public bool R9_Choice_1_Taken, R9_Choice_2_Taken;
	public bool R10_Choice_1_Taken, R10_Choice_2_Taken;

	// ROOMS 11-20
	public bool R11_Choice_1_Taken, R11_Choice_2_Taken;
	public bool R12_Choice_1_Taken, R12_Choice_2_Taken;
	public bool R13_Choice_1_Taken, R13_Choice_2_Taken;
	public bool R14_Choice_1_Taken, R14_Choice_2_Taken;
	public bool R15_Choice_1_Taken, R15_Choice_2_Taken;
	public bool R16_Choice_1_Taken, R16_Choice_2_Taken;
	public bool R17_Choice_1_Taken, R17_Choice_2_Taken;
	public bool R18_Choice_1_Taken, R18_Choice_2_Taken;
	public bool R19_Choice_1_Taken, R19_Choice_2_Taken;
	public bool R20_Choice_1_Taken, R20_Choice_2_Taken;

	// ROOMS 21-30
	public bool R21_Choice_1_Taken, R21_Choice_2_Taken;
	public bool R22_Choice_1_Taken, R22_Choice_2_Taken;
	public bool R23_Choice_1_Taken, R23_Choice_2_Taken;
	public bool R24_Choice_1_Taken, R24_Choice_2_Taken;
	public bool R25_Choice_1_Taken, R25_Choice_2_Taken;
	public bool R26_Choice_1_Taken, R26_Choice_2_Taken;
	public bool R27_Choice_1_Taken, R27_Choice_2_Taken;
	public bool R28_Choice_1_Taken, R28_Choice_2_Taken;
	public bool R29_Choice_1_Taken, R29_Choice_2_Taken;
	public bool R30_Choice_1_Taken, R30_Choice_2_Taken;

	// ROOMS 31-42
	public bool R31_Choice_1_Taken, R31_Choice_2_Taken;
	public bool R32_Choice_1_Taken, R32_Choice_2_Taken;
	public bool R33_Choice_1_Taken, R33_Choice_2_Taken;
	public bool R34_Choice_1_Taken, R34_Choice_2_Taken;
	public bool R35_Choice_1_Taken, R35_Choice_2_Taken;
	public bool R36_Choice_1_Taken, R36_Choice_2_Taken;
	public bool R37_Choice_1_Taken, R37_Choice_2_Taken;
	public bool R38_Choice_1_Taken, R38_Choice_2_Taken;
	public bool R39_Choice_1_Taken, R39_Choice_2_Taken;
	public bool R40_Choice_1_Taken, R40_Choice_2_Taken;
	public bool R41_Choice_1_Taken, R41_Choice_2_Taken;
	public bool R42_Choice_1_Taken, R42_Choice_2_Taken;
	public bool R43_Choice_1_Taken, R43_Choice_2_Taken;

	// Increment Booleans
	private bool R1_Choice_Made;
	private bool R2_Choice_Made;
	private bool R3_Choice_Made;
	private bool R4_Choice_Made;
	private bool R5_Choice_Made;
	private bool R6_Choice_Made;
	private bool R7_Choice_Made;
	private bool R8_Choice_Made;
	private bool R9_Choice_Made;
	private bool R10_Choice_Made;

	private bool R11_Choice_Made;
	private bool R12_Choice_Made;
	private bool R13_Choice_Made;
	private bool R14_Choice_Made;
	private bool R15_Choice_Made;
	private bool R16_Choice_Made;
	private bool R17_Choice_Made;
	private bool R18_Choice_Made;
	private bool R19_Choice_Made;
	private bool R20_Choice_Made;

	private bool R21_Choice_Made;
	private bool R22_Choice_Made;
	private bool R23_Choice_Made;
	private bool R24_Choice_Made;
	private bool R25_Choice_Made;
	private bool R26_Choice_Made;
	private bool R27_Choice_Made;
	private bool R28_Choice_Made;
	private bool R29_Choice_Made;
	private bool R30_Choice_Made;

	private bool R31_Choice_Made;
	private bool R32_Choice_Made;
	private bool R33_Choice_Made;
	private bool R34_Choice_Made;
	private bool R35_Choice_Made;
	private bool R36_Choice_Made;
	private bool R37_Choice_Made;
	private bool R38_Choice_Made;
	private bool R39_Choice_Made;
	private bool R40_Choice_Made;
	private bool R41_Choice_Made;
	private bool R42_Choice_Made;
	private bool R43_Choice_Made;

	private Text choiceText, room1ChoiceText, room2ChoiceText, room3ChoiceText, room4ChoiceText, room5ChoiceText, room6ChoiceText, room7ChoiceText, room8ChoiceText, room9ChoiceText, room10ChoiceText;
	private Text room11ChoiceText, room12ChoiceText, room13ChoiceText, room14ChoiceText, room15ChoiceText, room16ChoiceText, room17ChoiceText, room18ChoiceText, room19ChoiceText, room20ChoiceText;
	private Text room21ChoiceText, room22ChoiceText, room23ChoiceText, room24ChoiceText, room25ChoiceText, room26ChoiceText, room27ChoiceText, room28ChoiceText, room29ChoiceText, room30ChoiceText;
	private Text room31ChoiceText, room32ChoiceText, room33ChoiceText, room34ChoiceText, room35ChoiceText, room36ChoiceText, room37ChoiceText, room38ChoiceText, room39ChoiceText, room40ChoiceText;
	private Text room41ChoiceText, room42ChoiceText, room43ChoiceText;

	private Text redChosenText, blueChosenText, greenChosenText, yellowChosenText, orangeChosenText, magentaChosenText, cyanChosenText;

	private Text yourStatsTitle,coloursChosenTitle,mostChosenTitle, mostChosenText, routeChosenTitle, routeChosenText, colourPathChosenTitle, colourPathChosenText;
	private int redChosen, blueChosen, greenChosen, yellowChosen,orangeChosen, magentaChosen, cyanChosen;

	private int leftChosen, rightChosen;
	private int redLeftChosen, redRightChosen;
	private int blueLeftChosen, blueRightChosen;
	private int greenLeftChosen, greenRightChosen;
	private int yellowLeftChosen, yellowRightChosen;
	private int orangeLeftChosen, orangeRightChosen;
	private int magentaLeftChosen, magentaRightChosen;
	private int cyanLeftChosen, cyanRightChosen;

	public GameObject statsGroup;
	private Color color_orange = new Color(255f,155f,0f);
	private Color color_magenta = new Color (255f, 0f, 255f);
	private Color color_cyan = new Color(0f, 255f,255f);

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

		// Room 11
		R11_Choice_1_Taken = false;
		R11_Choice_2_Taken = false;
		// Room 12
		R12_Choice_1_Taken = false;
		R12_Choice_2_Taken = false;
		// Room 13
		R13_Choice_1_Taken = false;
		R13_Choice_2_Taken = false;
		// Room 14
		R14_Choice_1_Taken = false;
		R14_Choice_2_Taken = false;
		// Room 15
		R15_Choice_1_Taken = false;
		R15_Choice_2_Taken = false;
		// Room 16
		R16_Choice_1_Taken = false;
		R16_Choice_2_Taken = false;
		// Room 17
		R17_Choice_1_Taken = false;
		R17_Choice_2_Taken = false;
		// Room 18
		R18_Choice_1_Taken = false;
		R18_Choice_2_Taken = false;
		// Room 19
		R19_Choice_1_Taken = false;
		R19_Choice_2_Taken = false;
		// Room 20
		R20_Choice_1_Taken = false;
		R20_Choice_2_Taken = false;

		// Room 21
		R21_Choice_1_Taken = false;
		R21_Choice_2_Taken = false;
		// Room 22
		R22_Choice_1_Taken = false;
		R22_Choice_2_Taken = false;
		// Room 23
		R23_Choice_1_Taken = false;
		R23_Choice_2_Taken = false;
		// Room 24
		R24_Choice_1_Taken = false;
		R24_Choice_2_Taken = false;
		// Room 25
		R25_Choice_1_Taken = false;
		R25_Choice_2_Taken = false;
		// Room 26
		R26_Choice_1_Taken = false;
		R26_Choice_2_Taken = false;
		// Room 27
		R27_Choice_1_Taken = false;
		R27_Choice_2_Taken = false;
		// Room 28
		R28_Choice_1_Taken = false;
		R28_Choice_2_Taken = false;
		// Room 29
		R29_Choice_1_Taken = false;
		R29_Choice_2_Taken = false;
		// Room 30
		R30_Choice_1_Taken = false;
		R30_Choice_2_Taken = false;

		// Room 31
		R31_Choice_1_Taken = false;
		R31_Choice_2_Taken = false;
		// Room 32
		R32_Choice_1_Taken = false;
		R32_Choice_2_Taken = false;
		// Room 33
		R33_Choice_1_Taken = false;
		R33_Choice_2_Taken = false;
		// Room 34
		R34_Choice_1_Taken = false;
		R34_Choice_2_Taken = false;
		// Room 35
		R35_Choice_1_Taken = false;
		R35_Choice_2_Taken = false;
		// Room 36
		R36_Choice_1_Taken = false;
		R36_Choice_2_Taken = false;
		// Room 37
		R37_Choice_1_Taken = false;
		R37_Choice_2_Taken = false;
		// Room 38
		R38_Choice_1_Taken = false;
		R38_Choice_2_Taken = false;
		// Room 39
		R39_Choice_1_Taken = false;
		R39_Choice_2_Taken = false;
		// Room 40
		R40_Choice_1_Taken = false;
		R40_Choice_2_Taken = false;
		// Room 41
		R41_Choice_1_Taken = false;
		R41_Choice_2_Taken = false;
		// Room 42
		R42_Choice_1_Taken = false;
		R42_Choice_2_Taken = false;
		// Room 43
		R43_Choice_1_Taken = false;
		R43_Choice_2_Taken = false;

		R1_Choice_Made = false;
		R2_Choice_Made = false;
		R3_Choice_Made = false;
		R4_Choice_Made = false;
		R5_Choice_Made = false;
		R6_Choice_Made = false;
		R7_Choice_Made = false;
		R8_Choice_Made = false;
		R9_Choice_Made = false;
		R10_Choice_Made = false;

		R11_Choice_Made = false;
		R12_Choice_Made = false;
		R13_Choice_Made = false;
		R14_Choice_Made = false;
		R15_Choice_Made = false;
		R16_Choice_Made = false;
		R17_Choice_Made = false;
		R18_Choice_Made = false;
		R19_Choice_Made = false;
		R20_Choice_Made = false;

		R21_Choice_Made = false;
		R22_Choice_Made = false;
		R23_Choice_Made = false;
		R24_Choice_Made = false;
		R25_Choice_Made = false;
		R26_Choice_Made = false;
		R27_Choice_Made = false;
		R28_Choice_Made = false;
		R29_Choice_Made = false;
		R30_Choice_Made = false;

		R31_Choice_Made = false;
		R32_Choice_Made = false;
		R33_Choice_Made = false;
		R34_Choice_Made = false;
		R35_Choice_Made = false;
		R36_Choice_Made = false;
		R37_Choice_Made = false;
		R38_Choice_Made = false;
		R39_Choice_Made = false;
		R40_Choice_Made = false;
		R41_Choice_Made = false;
		R42_Choice_Made = false;
		R43_Choice_Made = false;

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

		// Text Update - Rooms 11 - 20
		room11ChoiceText = GameObject.Find("Room 11 Choice Text").GetComponent<Text>();
		room12ChoiceText = GameObject.Find("Room 12 Choice Text").GetComponent<Text>();
		room13ChoiceText = GameObject.Find("Room 13 Choice Text").GetComponent<Text>();
		room14ChoiceText = GameObject.Find("Room 14 Choice Text").GetComponent<Text>();
		room15ChoiceText = GameObject.Find("Room 15 Choice Text").GetComponent<Text>();
		room16ChoiceText = GameObject.Find("Room 16 Choice Text").GetComponent<Text>();
		room17ChoiceText = GameObject.Find("Room 17 Choice Text").GetComponent<Text>();
		room18ChoiceText = GameObject.Find("Room 18 Choice Text").GetComponent<Text>();
		room19ChoiceText = GameObject.Find("Room 19 Choice Text").GetComponent<Text>();
		room20ChoiceText = GameObject.Find("Room 20 Choice Text").GetComponent<Text>();

		// Text Update - Rooms 21 - 30
		room21ChoiceText = GameObject.Find("Room 21 Choice Text").GetComponent<Text>();
		room22ChoiceText = GameObject.Find("Room 22 Choice Text").GetComponent<Text>();
		room23ChoiceText = GameObject.Find("Room 23 Choice Text").GetComponent<Text>();
		room24ChoiceText = GameObject.Find("Room 24 Choice Text").GetComponent<Text>();
		room25ChoiceText = GameObject.Find("Room 25 Choice Text").GetComponent<Text>();
		room26ChoiceText = GameObject.Find("Room 26 Choice Text").GetComponent<Text>();
		room27ChoiceText = GameObject.Find("Room 27 Choice Text").GetComponent<Text>();
		room28ChoiceText = GameObject.Find("Room 28 Choice Text").GetComponent<Text>();
		room29ChoiceText = GameObject.Find("Room 29 Choice Text").GetComponent<Text>();
		room30ChoiceText = GameObject.Find("Room 30 Choice Text").GetComponent<Text>();

		// Text Update - Rooms 31 - 43
		room31ChoiceText = GameObject.Find("Room 31 Choice Text").GetComponent<Text>();
		room32ChoiceText = GameObject.Find("Room 32 Choice Text").GetComponent<Text>();
		room33ChoiceText = GameObject.Find("Room 33 Choice Text").GetComponent<Text>();
		room34ChoiceText = GameObject.Find("Room 34 Choice Text").GetComponent<Text>();
		room35ChoiceText = GameObject.Find("Room 35 Choice Text").GetComponent<Text>();
		room36ChoiceText = GameObject.Find("Room 36 Choice Text").GetComponent<Text>();
		room37ChoiceText = GameObject.Find("Room 37 Choice Text").GetComponent<Text>();
		room38ChoiceText = GameObject.Find("Room 38 Choice Text").GetComponent<Text>();
		room39ChoiceText = GameObject.Find("Room 39 Choice Text").GetComponent<Text>();
		room40ChoiceText = GameObject.Find("Room 40 Choice Text").GetComponent<Text>();
		room41ChoiceText = GameObject.Find("Room 41 Choice Text").GetComponent<Text>();
		room42ChoiceText = GameObject.Find("Room 42 Choice Text").GetComponent<Text>();
		room43ChoiceText = GameObject.Find("Room 43 Choice Text").GetComponent<Text>();

		// Stats Main Group
		statsGroup = GameObject.Find("StatsGroup");

		// Stats Titles
		yourStatsTitle = GameObject.Find("Your_Stats_Title").GetComponent<Text>();
		coloursChosenTitle = GameObject.Find("Colours_Chosen_Title").GetComponent<Text>();
		mostChosenTitle = GameObject.Find ("Most_Chosen_Title").GetComponent<Text>();
		routeChosenTitle = GameObject.Find ("Most_Chosen_Route_Title").GetComponent<Text> ();
		colourPathChosenTitle = GameObject.Find ("Colour_Path_Chosen_Title").GetComponent<Text> ();

		// Stats Text Update
		redChosenText = GameObject.Find("Red_Chosen_Text").GetComponent<Text>();
		blueChosenText = GameObject.Find("Blue_Chosen_Text").GetComponent<Text>();
		greenChosenText = GameObject.Find("Green_Chosen_Text").GetComponent<Text>();
		yellowChosenText = GameObject.Find("Yellow_Chosen_Text").GetComponent<Text>();
		orangeChosenText = GameObject.Find("Orange_Chosen_Text").GetComponent<Text>();
		magentaChosenText = GameObject.Find ("Magenta_Chosen_Text").GetComponent<Text> ();
		cyanChosenText = GameObject.Find ("Cyan_Chosen_Text").GetComponent<Text> ();

		mostChosenText = GameObject.Find("Most_Chosen_Text").GetComponent<Text>();
		routeChosenText = GameObject.Find ("Most_Chosen_Route_Text").GetComponent<Text> ();
		colourPathChosenText = GameObject.Find ("Colour_Path_Chosen_Text").GetComponent<Text> ();

		redChosen = 0;
		blueChosen = 0;
		greenChosen = 0;
		yellowChosen = 0;
		orangeChosen = 0;
		magentaChosen = 0;
		cyanChosen = 0;

		leftChosen = 0;
		rightChosen = 0;

		// Route/Colours Chosen
		redLeftChosen = 0;
		redRightChosen = 0;
		blueLeftChosen = 0;
		blueRightChosen = 0;
		greenLeftChosen = 0;
		greenRightChosen = 0;
		yellowLeftChosen = 0;
		yellowRightChosen = 0;
		orangeLeftChosen = 0;
		orangeRightChosen = 0;
		magentaLeftChosen = 0;
		magentaRightChosen = 0;
		cyanLeftChosen = 0;
		cyanRightChosen = 0;

		StatsOff ();
		Debug.Log ("Path :" + Application.dataPath);

	}

	private void OnGUI(){
		GUI.Box (new Rect (Screen.width / 2, Screen.height / 2, 20, 20), "");
	}


	public void StatsOn(){
		// Titles
		yourStatsTitle.text = "YOUR STATISTICS";
		coloursChosenTitle.text = "COLOURS CHOSEN";
		mostChosenTitle.text = "MOST CHOSEN COLOUR";
		routeChosenTitle.text = "MOST CHOSEN ROUTE";
		colourPathChosenTitle.text = "COLOUR PATH ROUTE";

		// Colours
		redChosenText.text = "RED COLOURS CHOSEN - " + redChosen + " / 14";
		blueChosenText.text = "BLUE COLOURS CHOSEN - " + blueChosen + " / 14";
		greenChosenText.text = "GREEN COLOURS CHOSEN - " + greenChosen + " / 14";
		yellowChosenText.text = "YELLOW COLOURS CHOSEN - " + yellowChosen + " / 14";
		orangeChosenText.text = "ORANGE COLOURS CHOSEN - " + orangeChosen + " / 14";
		magentaChosenText.text = "MAGENTA COLOURS CHOSEN - " + magentaChosen + " / 14";
		cyanChosenText.text = "CYAN COLOURS CHOSEN - " + cyanChosen + " / 14";

		// Most Chosen Route
		routeChosenText.text = "LEFT ROUTE CHOSEN: " + leftChosen + " TIMES\n" + "RIGHT ROUTE CHOSEN: " + rightChosen + " TIMES";

		// Colour Path Chosen
		colourPathChosenText.text = "RED ON LEFT CHOSEN: " + redLeftChosen +"\n" + "RED ON RIGHT CHOSEN: " + redRightChosen + "\n" +
			"BLUE ON LEFT CHOSEN: " + blueLeftChosen + "\n" + "BLUE ON RIGHT CHOSEN: " + blueRightChosen + "\n" +
			"GREEN ON LEFT CHOSEN: " + greenLeftChosen + "\n" + "GREEN ON RIGHT CHOSEN: " + greenRightChosen + "\n" +
			"YELLOW ON LEFT CHOSEN: " + yellowLeftChosen + "\n" + "YELLOW ON RIGHT CHOSEN: " + yellowRightChosen + "\n" +
			"ORANGE ON LEFT CHOSEN: " + orangeLeftChosen + "\n" + "ORANGE ON RIGHT CHOSEN: " + orangeRightChosen + "\n" +
			"MAGENTA ON LEFT CHOSEN: " + magentaLeftChosen + "\n" + "MAGENTA ON RIGHT CHOSEN: " + magentaRightChosen + "\n" +
			"CYAN ON LEFT CHOSEN: " + cyanLeftChosen + "\n" + "CYAN ON RIGHT CHOSEN: " + cyanRightChosen + "\n";


		// Most Chosen Colour Text
		int[] foo = {redChosen,blueChosen,greenChosen,yellowChosen,orangeChosen, magentaChosen, cyanChosen};
		int most = (Mathf.Max (foo));

		if (redChosen == most && blueChosen == most || greenChosen == most || yellowChosen == most || orangeChosen == most || magentaChosen == most || cyanChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}
		if (redChosen == most || blueChosen == most && greenChosen == most || yellowChosen == most || orangeChosen == most || magentaChosen == most || cyanChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}
		if (redChosen == most || blueChosen == most || greenChosen == most && yellowChosen == most || orangeChosen == most || magentaChosen == most || cyanChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}
		if (redChosen == most || blueChosen == most || greenChosen == most || yellowChosen == most && orangeChosen == most || magentaChosen == most || cyanChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}
		if (redChosen == most || blueChosen == most || greenChosen == most || yellowChosen == most || orangeChosen == most && magentaChosen == most || cyanChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}
		if (redChosen == most || blueChosen == most || greenChosen == most || yellowChosen == most && orangeChosen == most || magentaChosen == most && cyanChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}

		if (redChosen == most && !(blueChosen == most) && !(greenChosen == most) && !(yellowChosen == most) && !(orangeChosen == most) && !(magentaChosen == most) && !(cyanChosen == most)) {
			mostChosenText.text = "RED COLOUR CHOSEN MOST - " + redChosen;
			mostChosenText.color = Color.red;
		} 
		if (!(redChosen == most) && blueChosen == most && !(greenChosen == most) && !(yellowChosen == most) && !(orangeChosen == most) && !(magentaChosen == most) && !(cyanChosen == most)) {
			mostChosenText.text = "BLUE COLOUR CHOSEN MOST - " + blueChosen;
			mostChosenText.color = Color.blue;
		} 
		if (!(redChosen == most) && !(blueChosen == most) && greenChosen == most && !(yellowChosen == most) && !(orangeChosen == most) && !(magentaChosen == most) && !(cyanChosen == most)) {
			mostChosenText.text = "GREEN COLOUR CHOSEN MOST - " + greenChosen;
			mostChosenText.color = Color.green;
		} 
		if (!(redChosen == most) && !(blueChosen == most) && !(greenChosen == most) && yellowChosen == most && !(orangeChosen == most) && !(magentaChosen == most) && !(cyanChosen == most)) {
			mostChosenText.text = "YELLOW COLOUR CHOSEN MOST - " + yellowChosen;
			mostChosenText.color = Color.yellow;
		} 
		if (!(redChosen == most) && !(blueChosen == most) && !(greenChosen == most) && !(yellowChosen == most) && (orangeChosen == most) && !(magentaChosen == most) && !(cyanChosen == most)) {
			mostChosenText.text = "ORANGE COLOUR CHOSEN MOST - " + orangeChosen;
			mostChosenText.color = color_orange;
		} 
		if (!(redChosen == most) && !(blueChosen == most) && !(greenChosen == most) && !(yellowChosen == most) && !(orangeChosen == most) && (magentaChosen == most) && !(cyanChosen == most)) {
			mostChosenText.text = "MAGENTA COLOUR CHOSEN MOST - " + magentaChosen;
			mostChosenText.color = color_magenta;
		} 
		if (!(redChosen == most) && !(blueChosen == most) && !(greenChosen == most) && !(yellowChosen == most) && !(orangeChosen == most) && !(magentaChosen == most) && (cyanChosen == most)) {
			mostChosenText.text = "CYAN COLOUR CHOSEN MOST - " + cyanChosen;
			mostChosenText.color = color_cyan;
		} 
	}



	public void StatsOff(){
		// Titles
		yourStatsTitle.text = "";
		coloursChosenTitle.text = "";
		mostChosenTitle.text = "";
		routeChosenTitle.text = "";
		colourPathChosenTitle.text = "";

		// Colours
		redChosenText.text = "";
		blueChosenText.text = "";
		greenChosenText.text = "";
		yellowChosenText.text = "";
		orangeChosenText.text = "";
		magentaChosenText.text = "";
		cyanChosenText.text = "";

		// Most Chosen Colour Text
		mostChosenText.text = "";

		// Route Chosen Text
		routeChosenText.text = "";

		// Colour Path Chosen
		colourPathChosenText.text = "";
	}

	public void writeToFile(){
		string path = Application.dataPath.ToString() + @"\Colour Survey Results.txt";
		// This text is added only once to the file.
		if(!File.Exists(path)){
			// Create a file you want to write to.
			// COLOUR RESULTS
			string mainTitleText = "YOUR RESULTS" + Environment.NewLine;
			string titleText = Environment.NewLine + "COLOURS CHOSEN: " + Environment.NewLine;
			string redColourText = "RED COLOURS CHOSEN " + redChosen + " / 14" + Environment.NewLine;
			string blueColourText = "BLUE COLOURS CHOSEN " + blueChosen + " / 14" + Environment.NewLine;
			string greenColourText = "GREEN COLOURS CHOSEN " + greenChosen + " / 14" + Environment.NewLine;
			string yellowColourText = "YELLOW COLOURS CHOSEN " + yellowChosen + " / 14" + Environment.NewLine;
			string orangeColourText = "ORANGE COLOURS CHOSEN " + orangeChosen + " / 14" + Environment.NewLine;
			string magentaColourText = "MAGENTA COLOURS CHOSEN " + magentaChosen + " / 14" + Environment.NewLine;
			string cyanColourText = "CYAN COLOURS CHOSEN " + cyanChosen + " / 14" + Environment.NewLine;

			// MOST CHOSEN COLOUR
			string secondTitleText = Environment.NewLine + "MOST CHOSEN COLOUR" + Environment.NewLine;
			string mostChosenColour = mostChosenText.text.ToString() + Environment.NewLine;

			// MOST CHOSEN ROUTE
			string routeChosenMost = Environment.NewLine + "ROUTE CHOSEN MOST" + Environment.NewLine;
			string mostChosenStringText = "LEFT ROUTE CHOSEN: " + leftChosen + " TIMES" + Environment.NewLine + "RIGHT ROUTE CHOSEN: " + rightChosen + " TIMES" + Environment.NewLine;

			// COLOUR PATH CHOSEN
			string colourPathChosenStringTitle = Environment.NewLine + "COLOUR PATH CHOICES: " + Environment.NewLine;
			string colourPathChosenStringText = "RED ON LEFT CHOSEN: " + redLeftChosen + Environment.NewLine + "RED ON RIGHT CHOSEN: " + redRightChosen + Environment.NewLine +
			                                    "BLUE ON LEFT CHOSEN: " + blueLeftChosen + Environment.NewLine + "BLUE ON RIGHT CHOSEN: " + blueRightChosen + Environment.NewLine +
			                                    "GREEN ON LEFT CHOSEN: " + greenLeftChosen + Environment.NewLine + "GREEN ON RIGHT CHOSEN: " + greenRightChosen + Environment.NewLine +
			                                    "YELLOW ON LEFT CHOSEN: " + yellowLeftChosen + Environment.NewLine + "YELLOW ON RIGHT CHOSEN: " + yellowRightChosen + Environment.NewLine +
			                                    "ORANGE ON LEFT CHOSEN: " + orangeLeftChosen + Environment.NewLine + "ORANGE ON RIGHT CHOSEN: " + orangeRightChosen + Environment.NewLine +
			                                    "MAGENTA ON LEFT CHOSEN: " + magentaLeftChosen + Environment.NewLine + "MAGENTA ON RIGHT CHOSEN: " + magentaRightChosen + Environment.NewLine +
			                                    "CYAN ON LEFT CHOSEN: " + cyanLeftChosen + Environment.NewLine + "CYAN ON RIGHT CHOSEN: " + cyanRightChosen + Environment.NewLine;

			string roomPath = Environment.NewLine + "ROOM PATH" + Environment.NewLine + room1ChoiceText.text + Environment.NewLine + room2ChoiceText.text + Environment.NewLine + room3ChoiceText.text +
			                  Environment.NewLine + room4ChoiceText.text + Environment.NewLine + room5ChoiceText.text + Environment.NewLine + room6ChoiceText.text + Environment.NewLine + room7ChoiceText.text +
			                  Environment.NewLine + room8ChoiceText.text + Environment.NewLine + room9ChoiceText.text + Environment.NewLine + room10ChoiceText.text + Environment.NewLine + room11ChoiceText.text +
			                  Environment.NewLine + room12ChoiceText.text + Environment.NewLine + room13ChoiceText.text + Environment.NewLine + room14ChoiceText.text + Environment.NewLine + room15ChoiceText.text +
			                  Environment.NewLine + room16ChoiceText.text + Environment.NewLine + room17ChoiceText.text + Environment.NewLine + room18ChoiceText.text + Environment.NewLine + room19ChoiceText.text +
			                  Environment.NewLine + room20ChoiceText.text + Environment.NewLine + room21ChoiceText.text + Environment.NewLine + room22ChoiceText.text + Environment.NewLine + room23ChoiceText.text +
			                  Environment.NewLine + room24ChoiceText.text + Environment.NewLine + room25ChoiceText.text + Environment.NewLine + room26ChoiceText.text + Environment.NewLine + room27ChoiceText.text +
			                  Environment.NewLine + room28ChoiceText.text + Environment.NewLine + room29ChoiceText.text + Environment.NewLine + room30ChoiceText.text + Environment.NewLine + room30ChoiceText.text +
			                  Environment.NewLine + room31ChoiceText.text + Environment.NewLine + room32ChoiceText.text + Environment.NewLine + room33ChoiceText.text + Environment.NewLine + room34ChoiceText.text +
			                  Environment.NewLine + room35ChoiceText.text + Environment.NewLine + room36ChoiceText.text + Environment.NewLine + room37ChoiceText.text + Environment.NewLine + room38ChoiceText.text +
			                  Environment.NewLine + room39ChoiceText.text + Environment.NewLine + room40ChoiceText.text + Environment.NewLine + room41ChoiceText.text + Environment.NewLine + room42ChoiceText.text +
			                  Environment.NewLine + room43ChoiceText.text + Environment.NewLine;

			string wholeText = mainTitleText + titleText + redColourText + blueColourText + greenColourText +
			                   yellowColourText + orangeColourText + magentaColourText + cyanColourText + secondTitleText + mostChosenColour + routeChosenMost +
			                   mostChosenStringText + colourPathChosenStringTitle + colourPathChosenStringText + roomPath;
			
			File.WriteAllText (path, wholeText);
		}
	}


	public void RoomStatsOn(){
		room1ChoiceText.gameObject.SetActive (true);
		room2ChoiceText.gameObject.SetActive (true);
		room3ChoiceText.gameObject.SetActive (true);
		room4ChoiceText.gameObject.SetActive (true);
		room5ChoiceText.gameObject.SetActive (true);
		room6ChoiceText.gameObject.SetActive (true);
		room7ChoiceText.gameObject.SetActive (true);
		room8ChoiceText.gameObject.SetActive (true);
		room9ChoiceText.gameObject.SetActive (true);
		room10ChoiceText.gameObject.SetActive (true);
		//
		room11ChoiceText.gameObject.SetActive (true);
		room12ChoiceText.gameObject.SetActive (true);
		room13ChoiceText.gameObject.SetActive (true);
		room14ChoiceText.gameObject.SetActive (true);
		room15ChoiceText.gameObject.SetActive (true);
		room16ChoiceText.gameObject.SetActive (true);
		room17ChoiceText.gameObject.SetActive (true);
		room18ChoiceText.gameObject.SetActive (true);
		room19ChoiceText.gameObject.SetActive (true);
		room20ChoiceText.gameObject.SetActive (true);
		//
		room21ChoiceText.gameObject.SetActive (true);
		room22ChoiceText.gameObject.SetActive (true);
		room23ChoiceText.gameObject.SetActive (true);
		room24ChoiceText.gameObject.SetActive (true);
		room25ChoiceText.gameObject.SetActive (true);
		room26ChoiceText.gameObject.SetActive (true);
		room27ChoiceText.gameObject.SetActive (true);
		room28ChoiceText.gameObject.SetActive (true);
		room29ChoiceText.gameObject.SetActive (true);
		room30ChoiceText.gameObject.SetActive (true);
		//
		room31ChoiceText.gameObject.SetActive (true);
		room32ChoiceText.gameObject.SetActive (true);
		room33ChoiceText.gameObject.SetActive (true);
		room34ChoiceText.gameObject.SetActive (true);
		room35ChoiceText.gameObject.SetActive (true);
		room36ChoiceText.gameObject.SetActive (true);
		room37ChoiceText.gameObject.SetActive (true);
		room38ChoiceText.gameObject.SetActive (true);
		room39ChoiceText.gameObject.SetActive (true);
		room40ChoiceText.gameObject.SetActive (true);
		room41ChoiceText.gameObject.SetActive (true);
		room42ChoiceText.gameObject.SetActive (true);
		room43ChoiceText.gameObject.SetActive (true);

	}

	public void RoomStatsOff(){
		room1ChoiceText.gameObject.SetActive (false);
		room2ChoiceText.gameObject.SetActive (false);
		room3ChoiceText.gameObject.SetActive (false);
		room4ChoiceText.gameObject.SetActive (false);
		room5ChoiceText.gameObject.SetActive (false);
		room6ChoiceText.gameObject.SetActive (false);
		room7ChoiceText.gameObject.SetActive (false);
		room8ChoiceText.gameObject.SetActive (false);
		room9ChoiceText.gameObject.SetActive (false);
		room10ChoiceText.gameObject.SetActive (false);
		//
		room11ChoiceText.gameObject.SetActive (false);
		room12ChoiceText.gameObject.SetActive (false);
		room13ChoiceText.gameObject.SetActive (false);
		room14ChoiceText.gameObject.SetActive (false);
		room15ChoiceText.gameObject.SetActive (false);
		room16ChoiceText.gameObject.SetActive (false);
		room17ChoiceText.gameObject.SetActive (false);
		room18ChoiceText.gameObject.SetActive (false);
		room19ChoiceText.gameObject.SetActive (false);
		room20ChoiceText.gameObject.SetActive (false);
		//
		room21ChoiceText.gameObject.SetActive (false);
		room22ChoiceText.gameObject.SetActive (false);
		room23ChoiceText.gameObject.SetActive (false);
		room24ChoiceText.gameObject.SetActive (false);
		room25ChoiceText.gameObject.SetActive (false);
		room26ChoiceText.gameObject.SetActive (false);
		room27ChoiceText.gameObject.SetActive (false);
		room28ChoiceText.gameObject.SetActive (false);
		room29ChoiceText.gameObject.SetActive (false);
		room30ChoiceText.gameObject.SetActive (false);
		//
		room31ChoiceText.gameObject.SetActive (false);
		room32ChoiceText.gameObject.SetActive (false);
		room33ChoiceText.gameObject.SetActive (false);
		room34ChoiceText.gameObject.SetActive (false);
		room35ChoiceText.gameObject.SetActive (false);
		room36ChoiceText.gameObject.SetActive (false);
		room37ChoiceText.gameObject.SetActive (false);
		room38ChoiceText.gameObject.SetActive (false);
		room39ChoiceText.gameObject.SetActive (false);
		room40ChoiceText.gameObject.SetActive (false);
		room41ChoiceText.gameObject.SetActive (false);
		room42ChoiceText.gameObject.SetActive (false);
		room43ChoiceText.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		// ROOM 1 (Tutorial)
		if (R1_Choice_1_Taken && !R1_Choice_2_Taken && !R1_Choice_Made) {
			room1ChoiceText.text = "ROOM 1 - CHOSE RIGHT";
			rightChosen += 1;
			R1_Choice_Made = true;
		} else if (!R1_Choice_1_Taken && R1_Choice_2_Taken && !R1_Choice_Made) {
			room1ChoiceText.text = "ROOM 1 - CHOSE LEFT";
			leftChosen += 1;
			R1_Choice_Made = true;
		}
		// ROOM 2 (Blue and Red)
		if (R2_Choice_1_Taken && !R2_Choice_2_Taken && !R2_Choice_Made) {
			room2ChoiceText.text = "ROOM 2 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
			R2_Choice_Made = true;
		} else if (!R2_Choice_1_Taken && R2_Choice_2_Taken && !R2_Choice_Made) {
			room2ChoiceText.text = "ROOM 2 - CHOSE RED";
			redChosen += 1;
			redLeftChosen += 1;
			R2_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 3 (Blue and Red 2)
		if (R3_Choice_1_Taken && !R3_Choice_2_Taken && !R3_Choice_Made) {
			room3ChoiceText.text = "ROOM 3 - CHOSE GREEN";
			greenChosen += 1;
			greenRightChosen += 1;
			R3_Choice_Made = true;
			rightChosen += 1;
		} else if (!R3_Choice_1_Taken && R3_Choice_2_Taken && !R3_Choice_Made) {
			room3ChoiceText.text = "ROOM 3 - CHOSE RED";
			redChosen += 1;
			redLeftChosen += 1;
			R3_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 4 (Blue and Red Final)
		if (R4_Choice_1_Taken && !R4_Choice_2_Taken && !R4_Choice_Made) {
			room4ChoiceText.text = "ROOM 4 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowRightChosen += 1;
			R4_Choice_Made = true;
			rightChosen += 1;
		} else if (!R4_Choice_1_Taken && R4_Choice_2_Taken && !R4_Choice_Made) {
			room4ChoiceText.text = "ROOM 4 - CHOSE RED";
			redChosen += 1;
			redLeftChosen += 1;
			R4_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 5 (Green and Blue)
		if (R5_Choice_1_Taken && !R5_Choice_2_Taken && !R5_Choice_Made) {
			room5ChoiceText.text = "ROOM 5 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeRightChosen += 1;
			R5_Choice_Made = true;
			rightChosen += 1;
		} else if (!R5_Choice_1_Taken && R5_Choice_2_Taken && !R5_Choice_Made) {
			room5ChoiceText.text = "ROOM 5 - CHOSE RED";
			redChosen += 1;
			redLeftChosen += 1;
			R5_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 6 (Green and Blue 2)
		if (R6_Choice_1_Taken && !R6_Choice_2_Taken && !R6_Choice_Made) {
			room6ChoiceText.text = "ROOM 6 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaRightChosen += 1;
			R6_Choice_Made = true;
			rightChosen += 1;
		} else if (!R6_Choice_1_Taken && R6_Choice_2_Taken && !R6_Choice_Made) {
			room6ChoiceText.text = "ROOM 6 - CHOSE RED";
			redChosen += 1;
			redLeftChosen += 1;
			R6_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 7 (Green and Blue Final)
		if (R7_Choice_1_Taken && !R7_Choice_2_Taken && !R7_Choice_Made) {
			room7ChoiceText.text = "ROOM 7 - CHOSE CYAN";
			cyanChosen += 1;
			cyanRightChosen += 1;
			R7_Choice_Made = true;
			rightChosen += 1;
		} else if (!R7_Choice_1_Taken && R7_Choice_2_Taken && !R7_Choice_Made) {
			room7ChoiceText.text = "ROOM 7 - CHOSE RED";
			redChosen += 1;
			redLeftChosen += 1;
			R7_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 8 (Yellow and Green)
		if (R8_Choice_1_Taken && !R8_Choice_2_Taken && !R8_Choice_Made) {
			room8ChoiceText.text = "ROOM 8 - CHOSE RED";
			redChosen += 1;
			redRightChosen += 1;
			R8_Choice_Made = true;
			rightChosen += 1;
		} else if (!R8_Choice_1_Taken && R8_Choice_2_Taken && !R8_Choice_Made) {
			room8ChoiceText.text = "ROOM 8 - CHOSE BLUE";
			blueChosen += 1;
			blueLeftChosen += 1;
			R8_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 9 (Yellow and Green 2)
		if (R9_Choice_1_Taken && !R9_Choice_2_Taken && !R9_Choice_Made) {
			room9ChoiceText.text = "ROOM 9 - CHOSE GREEN";
			greenChosen += 1;
			greenRightChosen += 1;
			R9_Choice_Made = true;
			rightChosen += 1;
		} else if (!R9_Choice_1_Taken && R9_Choice_2_Taken && !R9_Choice_Made) {
			room9ChoiceText.text = "ROOM 9 - CHOSE BLUE";
			blueChosen += 1;
			blueLeftChosen += 1;
			R9_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 10 (Yellow and Green Final)
		if (R10_Choice_1_Taken && !R10_Choice_2_Taken && !R10_Choice_Made) {
			room10ChoiceText.text = "ROOM 10 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowRightChosen += 1;
			R10_Choice_Made = true;
			rightChosen += 1;
		} else if (!R10_Choice_1_Taken && R10_Choice_2_Taken && !R10_Choice_Made) {
			room10ChoiceText.text = "ROOM 10 - CHOSE BLUE";
			blueChosen += 1;
			blueLeftChosen += 1;
			R10_Choice_Made = true;
			leftChosen += 1;
		}

		// ROOM 11 (RED AND YELLOW)
		if (R11_Choice_1_Taken && !R11_Choice_2_Taken && !R11_Choice_Made) {
			room11ChoiceText.text = "ROOM 11 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeRightChosen += 1;
			R11_Choice_Made = true;
			rightChosen += 1;
		} else if (!R11_Choice_1_Taken && R11_Choice_2_Taken && !R11_Choice_Made) {
			room11ChoiceText.text = "ROOM 11 - CHOSE BLUE";
			blueChosen += 1;
			blueLeftChosen += 1;
			R11_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 12 (RED AND YELLOW 2)
		if (R12_Choice_1_Taken && !R12_Choice_2_Taken && !R12_Choice_Made) {
			room12ChoiceText.text = "ROOM 12 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaRightChosen += 1;
			R12_Choice_Made = true;
			rightChosen += 1;
		} else if (!R12_Choice_1_Taken && R12_Choice_2_Taken && !R12_Choice_Made) {
			room12ChoiceText.text = "ROOM 12 - CHOSE BLUE";
			blueChosen += 1;
			blueLeftChosen += 1;
			R12_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 13 (RED AND YELLOW FINAL)
		if (R13_Choice_1_Taken && !R13_Choice_2_Taken && !R13_Choice_Made) {
			room13ChoiceText.text = "ROOM 13 - CHOSE CYAN";
			cyanChosen += 1;
			cyanRightChosen += 1;
			R13_Choice_Made = true;
			rightChosen += 1;
		} else if (!R13_Choice_1_Taken && R13_Choice_2_Taken && !R13_Choice_Made) {
			room13ChoiceText.text = "ROOM 13 - CHOSE BLUE";
			blueChosen += 1;
			blueLeftChosen += 1;
			R13_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 14 (BLUE AND ORANGE)
		if (R14_Choice_1_Taken && !R14_Choice_2_Taken && !R14_Choice_Made) {
			room14ChoiceText.text = "ROOM 14 - CHOSE RED";
			redChosen += 1;
			redRightChosen += 1;
			R14_Choice_Made = true;
			rightChosen += 1;
		} else if (!R14_Choice_1_Taken && R14_Choice_2_Taken && !R14_Choice_Made) {
			room14ChoiceText.text = "ROOM 14 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
			R14_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 15 (BLUE AND ORANGE 2)
		if (R15_Choice_1_Taken && !R15_Choice_2_Taken && !R15_Choice_Made) {
			room15ChoiceText.text = "ROOM 15 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
			R15_Choice_Made = true;
			rightChosen += 1;
		} else if (!R15_Choice_1_Taken && R15_Choice_2_Taken && !R15_Choice_Made) {
			room15ChoiceText.text = "ROOM 15 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
			R15_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 16 (BLUE AND ORANGE FINAL)
		if (R16_Choice_1_Taken && !R16_Choice_2_Taken && !R16_Choice_Made) {
			room16ChoiceText.text = "ROOM 16 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowRightChosen += 1;
			R16_Choice_Made = true;
			rightChosen += 1;
		} else if (!R16_Choice_1_Taken && R16_Choice_2_Taken && !R16_Choice_Made) {
			room16ChoiceText.text = "ROOM 16 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
			R16_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 17 (ORANGE AND GREEN)
		if (R17_Choice_1_Taken && !R17_Choice_2_Taken && !R17_Choice_Made) {
			room17ChoiceText.text = "ROOM 17 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeRightChosen += 1;
			R17_Choice_Made = true;
			rightChosen += 1;
		} else if (!R17_Choice_1_Taken && R17_Choice_2_Taken && !R17_Choice_Made) {
			room17ChoiceText.text = "ROOM 17 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
			R17_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 18 (ORANGE AND GREEN 2)
		if (R18_Choice_1_Taken && !R18_Choice_2_Taken && !R18_Choice_Made) {
			room18ChoiceText.text = "ROOM 18 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaRightChosen += 1;
			R18_Choice_Made = true;
			rightChosen += 1;
		} else if (!R18_Choice_1_Taken && R18_Choice_2_Taken && !R18_Choice_Made) {
			room18ChoiceText.text = "ROOM 18 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
			R18_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 19 (ORANGE AND GREEN FINAL)
		if (R19_Choice_1_Taken && !R19_Choice_2_Taken && !R19_Choice_Made) {
			room19ChoiceText.text = "ROOM 19 - CHOSE CYAN";
			cyanChosen += 1;
			cyanRightChosen += 1;
			R19_Choice_Made = true;
			rightChosen += 1;
		} else if (!R19_Choice_1_Taken && R19_Choice_2_Taken && !R19_Choice_Made) {
			room19ChoiceText.text = "ROOM 19 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
			R19_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 20 (RED or GREEN)
		if (R20_Choice_1_Taken && !R20_Choice_2_Taken && !R20_Choice_Made) {
			room20ChoiceText.text = "ROOM 20 - CHOSE RED";
			redChosen += 1;
			redRightChosen += 1;
			R20_Choice_Made = true;
			rightChosen += 1;
		} else if (!R20_Choice_1_Taken && R20_Choice_2_Taken && !R20_Choice_Made) {
			room20ChoiceText.text = "ROOM 20 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowLeftChosen += 1;
			R20_Choice_Made = true;
			leftChosen += 1;
		}

		// ROOM 21 (RED AND YELLOW)
		if (R21_Choice_1_Taken && !R21_Choice_2_Taken && !R21_Choice_Made) {
			room21ChoiceText.text = "ROOM 21 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
			R21_Choice_Made = true;
			rightChosen += 1;
		} else if (!R21_Choice_1_Taken && R21_Choice_2_Taken && !R21_Choice_Made) {
			room21ChoiceText.text = "ROOM 21 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowLeftChosen += 1;
			R21_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 22 (RED AND YELLOW 2)
		if (R22_Choice_1_Taken && !R22_Choice_2_Taken && !R22_Choice_Made) {
			room22ChoiceText.text = "ROOM 22 - CHOSE GREEN";
			greenChosen += 1;
			greenRightChosen += 1;
			R22_Choice_Made = true;
			rightChosen += 1;
		} else if (!R22_Choice_1_Taken && R22_Choice_2_Taken && !R22_Choice_Made) {
			room22ChoiceText.text = "ROOM 22 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowLeftChosen += 1;
			R22_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 23 (RED AND YELLOW FINAL)
		if (R23_Choice_1_Taken && !R23_Choice_2_Taken && !R23_Choice_Made) {
			room23ChoiceText.text = "ROOM 23 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeRightChosen += 1;
			R23_Choice_Made = true;
			rightChosen += 1;
		} else if (!R23_Choice_1_Taken && R23_Choice_2_Taken && !R23_Choice_Made) {
			room23ChoiceText.text = "ROOM 23 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowLeftChosen += 1;
			R23_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 24 (BLUE AND ORANGE)
		if (R24_Choice_1_Taken && !R24_Choice_2_Taken && !R24_Choice_Made) {
			room24ChoiceText.text = "ROOM 24 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaRightChosen += 1;
			R24_Choice_Made = true;
			rightChosen += 1;
		} else if (!R24_Choice_1_Taken && R24_Choice_2_Taken && !R24_Choice_Made) {
			room24ChoiceText.text = "ROOM 24 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowLeftChosen += 1;
			R24_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 25 (BLUE AND ORANGE 2)
		if (R25_Choice_1_Taken && !R25_Choice_2_Taken && !R25_Choice_Made) {
			room25ChoiceText.text = "ROOM 25 - CHOSE CYAN";
			cyanChosen += 1;
			cyanRightChosen += 1;
			R25_Choice_Made = true;
			rightChosen += 1;
		} else if (!R25_Choice_1_Taken && R25_Choice_2_Taken && !R25_Choice_Made) {
			room25ChoiceText.text = "ROOM 25 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowLeftChosen += 1;
			R25_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 26 (BLUE AND ORANGE FINAL)
		if (R26_Choice_1_Taken && !R26_Choice_2_Taken && !R26_Choice_Made) {
			room26ChoiceText.text = "ROOM 26 - CHOSE RED";
			redChosen += 1;
			redRightChosen += 1;
			R26_Choice_Made = true;
			rightChosen += 1;
		} else if (!R26_Choice_1_Taken && R26_Choice_2_Taken && !R26_Choice_Made) {
			room26ChoiceText.text = "ROOM 26 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeLeftChosen += 1;
			R26_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 27 (ORANGE AND GREEN)
		if (R27_Choice_1_Taken && !R27_Choice_2_Taken && !R27_Choice_Made) {
			room27ChoiceText.text = "ROOM 27 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
			R27_Choice_Made = true;
			rightChosen += 1;
		} else if (!R27_Choice_1_Taken && R27_Choice_2_Taken && !R27_Choice_Made) {
			room27ChoiceText.text = "ROOM 27 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeLeftChosen += 1;
			R27_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 28 (ORANGE AND GREEN 2)
		if (R28_Choice_1_Taken && !R28_Choice_2_Taken && !R28_Choice_Made) {
			room28ChoiceText.text = "ROOM 28 - CHOSE GREEN";
			greenChosen += 1;
			greenRightChosen += 1;
			R28_Choice_Made = true;
			rightChosen += 1;
		} else if (!R28_Choice_1_Taken && R28_Choice_2_Taken && !R28_Choice_Made) {
			room28ChoiceText.text = "ROOM 28 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeLeftChosen += 1;
			R28_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 29 (ORANGE AND GREEN FINAL)
		if (R29_Choice_1_Taken && !R29_Choice_2_Taken && !R29_Choice_Made) {
			room29ChoiceText.text = "ROOM 29 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowRightChosen += 1;
			R29_Choice_Made = true;
			rightChosen += 1;
		} else if (!R29_Choice_1_Taken && R29_Choice_2_Taken && !R29_Choice_Made) {
			room29ChoiceText.text = "ROOM 29 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeLeftChosen += 1;
			R29_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 30 (RED or GREEN)
		if (R30_Choice_1_Taken && !R30_Choice_2_Taken && !R30_Choice_Made) {
			room30ChoiceText.text = "ROOM 30 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaRightChosen += 1;
			R30_Choice_Made = true;
			rightChosen += 1;
		} else if (!R30_Choice_1_Taken && R30_Choice_2_Taken && !R30_Choice_Made) {
			room30ChoiceText.text = "ROOM 30 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeLeftChosen += 1;
			R30_Choice_Made = true;
			leftChosen += 1;
		}


		// ROOM 31 (ORANGE OR CYAN)
		if (R31_Choice_1_Taken && !R31_Choice_2_Taken && !R31_Choice_Made) {
			room31ChoiceText.text = "ROOM 31 - CHOSE CYAN";
			cyanChosen += 1;
			cyanRightChosen += 1;
			R31_Choice_Made = true;
			rightChosen += 1;
		} else if (!R31_Choice_1_Taken && R31_Choice_2_Taken && !R31_Choice_Made) {
			room31ChoiceText.text = "ROOM 31 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeLeftChosen += 1;
			R31_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 32 (MAGENTA or RED)
		if (R32_Choice_1_Taken && !R32_Choice_2_Taken && !R32_Choice_Made) {
			room32ChoiceText.text = "ROOM 32 - CHOSE RED";
			redChosen += 1;
			redRightChosen += 1;
			R32_Choice_Made = true;
			rightChosen += 1;
		} else if (!R32_Choice_1_Taken && R32_Choice_2_Taken && !R32_Choice_Made) {
			room32ChoiceText.text = "ROOM 32 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaLeftChosen += 1;
			R32_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 33 (MAGENTA OR BLUE)
		if (R33_Choice_1_Taken && !R33_Choice_2_Taken && !R33_Choice_Made) {
			room33ChoiceText.text = "ROOM 23 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
			R33_Choice_Made = true;
			rightChosen += 1;
		} else if (!R33_Choice_1_Taken && R33_Choice_2_Taken && !R33_Choice_Made) {
			room33ChoiceText.text = "ROOM 33 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaLeftChosen += 1;
			R33_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 34 (MAGENTA OR GREEN)
		if (R34_Choice_1_Taken && !R34_Choice_2_Taken && !R34_Choice_Made) {
			room34ChoiceText.text = "ROOM 34 - CHOSE GREEN";
			greenChosen += 1;
			greenRightChosen += 1;
			R34_Choice_Made = true;
			rightChosen += 1;
		} else if (!R34_Choice_1_Taken && R34_Choice_2_Taken && !R34_Choice_Made) {
			room34ChoiceText.text = "ROOM 34 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaLeftChosen += 1;
			R34_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 35 (MAGENTA OR YELLOW)
		if (R35_Choice_1_Taken && !R35_Choice_2_Taken && !R35_Choice_Made) {
			room35ChoiceText.text = "ROOM 35 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowRightChosen += 1;
			R35_Choice_Made = true;
			rightChosen += 1;
		} else if (!R35_Choice_1_Taken && R35_Choice_2_Taken && !R35_Choice_Made) {
			room35ChoiceText.text = "ROOM 35 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaLeftChosen += 1;
			R35_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 36 (MAGENTA OR ORANGE)
		if (R36_Choice_1_Taken && !R36_Choice_2_Taken && !R36_Choice_Made) {
			room36ChoiceText.text = "ROOM 36 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeRightChosen += 1;
			R36_Choice_Made = true;
			rightChosen += 1;
		} else if (!R36_Choice_1_Taken && R36_Choice_2_Taken && !R36_Choice_Made) {
			room36ChoiceText.text = "ROOM 36 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaLeftChosen += 1;
			R36_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 37 (MAGENTA OR CYAN)
		if (R37_Choice_1_Taken && !R37_Choice_2_Taken && !R37_Choice_Made) {
			room37ChoiceText.text = "ROOM 37 - CHOSE CYAN";
			cyanChosen += 1;
			cyanRightChosen += 1;
			R37_Choice_Made = true;
			rightChosen += 1;
		} else if (!R37_Choice_1_Taken && R37_Choice_2_Taken && !R37_Choice_Made) {
			room37ChoiceText.text = "ROOM 37 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaLeftChosen += 1;
			R37_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 38 (CYAN OR RED)
		if (R38_Choice_1_Taken && !R38_Choice_2_Taken && !R38_Choice_Made) {
			room38ChoiceText.text = "ROOM 38 - CHOSE RED";
			redChosen += 1;
			redRightChosen += 1;
			R38_Choice_Made = true;
			rightChosen += 1;
		} else if (!R38_Choice_1_Taken && R38_Choice_2_Taken && !R38_Choice_Made) {
			room38ChoiceText.text = "ROOM 38 - CHOSE CYAN";
			cyanChosen += 1;
			cyanLeftChosen += 1;
			R38_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 39 (CYAN OR BLUE)
		if (R39_Choice_1_Taken && !R39_Choice_2_Taken && !R39_Choice_Made) {
			room39ChoiceText.text = "ROOM 39 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
			R39_Choice_Made = true;
			rightChosen += 1;
		} else if (!R39_Choice_1_Taken && R39_Choice_2_Taken && !R39_Choice_Made) {
			room39ChoiceText.text = "ROOM 39 - CHOSE CYAN";
			cyanChosen += 1;
			cyanLeftChosen += 1;
			R39_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 40 (CYAN OR GREEN)
		if (R40_Choice_1_Taken && !R40_Choice_2_Taken && !R40_Choice_Made) {
			room40ChoiceText.text = "ROOM 40 - CHOSE GREEN";
			greenChosen += 1;
			greenRightChosen += 1;
			R40_Choice_Made = true;
			rightChosen += 1;
		} else if (!R40_Choice_1_Taken && R40_Choice_2_Taken && !R40_Choice_Made) {
			room40ChoiceText.text = "ROOM 40 - CHOSE CYAN";
			cyanChosen += 1;
			cyanLeftChosen += 1;
			R40_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 41 (CYAN OR YELLOW)
		if (R41_Choice_1_Taken && !R41_Choice_2_Taken && !R41_Choice_Made) {
			room41ChoiceText.text = "ROOM 41 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowRightChosen += 1;
			R41_Choice_Made = true;
			rightChosen += 1;
		} else if (!R41_Choice_1_Taken && R41_Choice_2_Taken && !R41_Choice_Made) {
			room41ChoiceText.text = "ROOM 41 - CHOSE CYAN";
			cyanChosen += 1;
			cyanLeftChosen += 1;
			R41_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 42 (CYAN OR ORANGE)
		if (R42_Choice_1_Taken && !R42_Choice_2_Taken && !R42_Choice_Made) {
			room42ChoiceText.text = "ROOM 42 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeRightChosen += 1;
			R42_Choice_Made = true;
			rightChosen += 1;
		} else if (!R42_Choice_1_Taken && R42_Choice_2_Taken && !R42_Choice_Made) {
			room42ChoiceText.text = "ROOM 42 - CHOSE CYAN";
			cyanChosen += 1;
			cyanLeftChosen += 1;
			R42_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 43 (CYAN OR MAGENTA)
		if (R43_Choice_1_Taken && !R43_Choice_2_Taken && !R43_Choice_Made) {
			room43ChoiceText.text = "ROOM 43 - CHOSE MAGENTA";
			magentaChosen += 1;
			magentaRightChosen += 1;
			R43_Choice_Made = true;
			rightChosen += 1;
		} else if (!R43_Choice_1_Taken && R43_Choice_2_Taken && !R43_Choice_Made) {
			room43ChoiceText.text = "ROOM 43 - CHOSE CYAN";
			cyanChosen += 1;
			cyanLeftChosen += 1;
			R43_Choice_Made = true;
			leftChosen += 1;
		}

	}
}

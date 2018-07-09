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

	private Text choiceText, room1ChoiceText, room2ChoiceText, room3ChoiceText, room4ChoiceText, room5ChoiceText, room6ChoiceText, room7ChoiceText, room8ChoiceText, room9ChoiceText, room10ChoiceText;
	private Text room11ChoiceText, room12ChoiceText, room13ChoiceText, room14ChoiceText, room15ChoiceText, room16ChoiceText, room17ChoiceText, room18ChoiceText, room19ChoiceText, room20ChoiceText;
	private Text redChosenText, blueChosenText, greenChosenText, yellowChosenText, orangeChosenText;

	private Text yourStatsTitle,coloursChosenTitle,mostChosenTitle, mostChosenText, routeChosenTitle, routeChosenText, colourPathChosenTitle, colourPathChosenText;
	private int redChosen, blueChosen, greenChosen, yellowChosen,orangeChosen;
	private int leftChosen, rightChosen;
	private int redLeftChosen, redRightChosen;
	private int blueLeftChosen, blueRightChosen;
	private int greenLeftChosen, greenRightChosen;
	private int yellowLeftChosen, yellowRightChosen;
	private int orangeLeftChosen, orangeRightChosen;
	public GameObject statsGroup;
	private Color color_orange = new Color(265f,155f,0f);

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
		mostChosenText = GameObject.Find("Most_Chosen_Text").GetComponent<Text>();
		routeChosenText = GameObject.Find ("Most_Chosen_Route_Text").GetComponent<Text> ();
		colourPathChosenText = GameObject.Find ("Colour_Path_Chosen_Text").GetComponent<Text> ();

		redChosen = 0;
		blueChosen = 0;
		greenChosen = 0;
		yellowChosen = 0;
		orangeChosen = 0;
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
		redChosenText.text = "RED COLOURS CHOSEN - " + redChosen + " / 6";
		blueChosenText.text = "BLUE COLOURS CHOSEN - " + blueChosen + " / 9";
		greenChosenText.text = "GREEN COLOURS CHOSEN - " + greenChosen + " / 9";
		yellowChosenText.text = "YELLOW COLOURS CHOSEN - " + yellowChosen + " / 6";
		orangeChosenText.text = "ORANGE COLOURS CHOSEN - " + orangeChosen + " / 6";

		// Most Chosen Route
		routeChosenText.text = "LEFT ROUTE CHOSEN: " + leftChosen + " TIMES\n" + "RIGHT ROUTE CHOSEN: " + rightChosen + " TIMES";

		// Colour Path Chosen
		colourPathChosenText.text = "RED ON LEFT CHOSEN: " + redLeftChosen +"\n" + "RED ON RIGHT CHOSEN: " + redRightChosen + "\n" +
			"BLUE ON LEFT CHOSEN: " + blueLeftChosen + "\n" + "BLUE ON RIGHT CHOSEN: " + blueRightChosen + "\n" +
			"GREEN ON LEFT CHOSEN: " + greenLeftChosen + "\n" + "GREEN ON RIGHT CHOSEN: " + greenRightChosen + "\n" +
			"YELLOW ON LEFT CHOSEN: " + yellowLeftChosen + "\n" + "YELLOW ON RIGHT CHOSEN: " + yellowRightChosen + "\n" +
			"ORANGE ON LEFT CHOSEN: " + orangeLeftChosen + "\n" + "ORANGE ON RIGHT CHOSEN: " + orangeRightChosen + "\n";


		// Most Chosen Colour Text
		int[] foo = {redChosen,blueChosen,greenChosen,yellowChosen,orangeChosen};
		int most = (Mathf.Max (foo));

		if (redChosen == most && blueChosen == most || greenChosen == most || yellowChosen == most || orangeChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}
		if (redChosen == most || blueChosen == most && greenChosen == most || yellowChosen == most || orangeChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}
		if (redChosen == most || blueChosen == most || greenChosen == most && yellowChosen == most || orangeChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}
		if (redChosen == most || blueChosen == most || greenChosen == most || yellowChosen == most && orangeChosen == most) {
			mostChosenText.text = "NO SINGLE COLOUR CHOSEN MOST";
			mostChosenText.color = Color.white;
		}
		if (redChosen == most && !(blueChosen == most) && !(greenChosen == most) && !(yellowChosen == most) && !(orangeChosen == most)) {
			mostChosenText.text = "RED COLOUR CHOSEN MOST - " + redChosen;
			mostChosenText.color = Color.red;
		} 
		if (!(redChosen == most) && blueChosen == most && !(greenChosen == most) && !(yellowChosen == most) && !(orangeChosen == most)) {
			mostChosenText.text = "BLUE COLOUR CHOSEN MOST - " + blueChosen;
			mostChosenText.color = Color.blue;
		} 
		if (!(redChosen == most) && !(blueChosen == most) && greenChosen == most && !(yellowChosen == most) && !(orangeChosen == most)) {
			mostChosenText.text = "GREEN COLOUR CHOSEN MOST - " + greenChosen;
			mostChosenText.color = Color.green;
		} 
		if (!(redChosen == most) && !(blueChosen == most) && !(greenChosen == most) && yellowChosen == most && !(orangeChosen == most)) {
			mostChosenText.text = "YELLOW COLOUR CHOSEN MOST - " + yellowChosen;
			mostChosenText.color = Color.yellow;
		} 
		if (!(redChosen == most) && !(blueChosen == most) && !(greenChosen == most) && !(yellowChosen == most) && orangeChosen == most) {
			mostChosenText.text = "ORANGE COLOUR CHOSEN MOST - " + orangeChosen;
			mostChosenText.color = color_orange;
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

		// Most Chosen Colour Text
		mostChosenText.text = "";

		// Route Chosen Text
		routeChosenText.text = "";

		// Colour Path Chosen
		colourPathChosenText.text = "";
	}

	public void writeToFile(){
		//string path = @"C:\Users\Patrick\Desktop\MyTest.txt";
		//string path = @"C:\Desktop\MyTest2.txt";
		string path = Application.dataPath.ToString() + @"\Colour Survey Results.txt";
		// This text is added only once to the file.
		if(!File.Exists(path)){
			// Create a file you want to write to.
			// COLOUR RESULTS
			string mainTitleText = "YOUR RESULTS" + Environment.NewLine;
			string titleText = Environment.NewLine + "COLOURS CHOSEN: " + Environment.NewLine;
			string redColourText = "RED COLOURS CHOSEN " + redChosen + " / 6" + Environment.NewLine;
			string blueColourText = "BLUE COLOURS CHOSEN " + blueChosen + " / 9" + Environment.NewLine;
			string greenColourText = "GREEN COLOURS CHOSEN " + greenChosen + " / 9" + Environment.NewLine;
			string yellowColourText = "YELLOW COLOURS CHOSEN " + yellowChosen + " / 6" + Environment.NewLine;
			string orangeColourText = "ORANGE COLOURS CHOSEN " + orangeChosen + " / 6" + Environment.NewLine;

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
			                              "ORANGE ON LEFT CHOSEN: " + orangeLeftChosen + Environment.NewLine + "ORANGE ON RIGHT CHOSEN: " + orangeRightChosen + Environment.NewLine;

			string wholeText = mainTitleText + titleText + redColourText + blueColourText + greenColourText +
			                   yellowColourText + orangeColourText + secondTitleText + mostChosenColour + routeChosenMost +
			                   mostChosenStringText + colourPathChosenStringTitle + colourPathChosenStringText;
			
			File.WriteAllText (path, wholeText);
		}
		// This text is always added, making the file longer over time.
		// If it is not deleted.
		//string appendText = "EXTRA RESULTS: " + Environment.NewLine;
		//File.AppendAllText (path, appendText);

		// Open the file to read from.
		//string readText = File.ReadAllText(path);
		//Console.WriteLine(readText);
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
			room3ChoiceText.text = "ROOM 3 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
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
			room4ChoiceText.text = "ROOM 4 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
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
			room5ChoiceText.text = "ROOM 5 - CHOSE GREEN";
			greenChosen += 1;
			greenRightChosen += 1;
			R5_Choice_Made = true;
			rightChosen += 1;
		} else if (!R5_Choice_1_Taken && R5_Choice_2_Taken && !R5_Choice_Made) {
			room5ChoiceText.text = "ROOM 5 - CHOSE BLUE";
			blueChosen += 1;
			blueLeftChosen += 1;
			R5_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 6 (Green and Blue 2)
		if (R6_Choice_1_Taken && !R6_Choice_2_Taken && !R6_Choice_Made) {
			room6ChoiceText.text = "ROOM 6 - CHOSE GREEN";
			greenChosen += 1;
			greenRightChosen += 1;
			R6_Choice_Made = true;
			rightChosen += 1;
		} else if (!R6_Choice_1_Taken && R6_Choice_2_Taken && !R6_Choice_Made) {
			room6ChoiceText.text = "ROOM 6 - CHOSE BLUE";
			blueChosen += 1;
			blueLeftChosen += 1;
			R6_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 7 (Green and Blue Final)
		if (R7_Choice_1_Taken && !R7_Choice_2_Taken && !R7_Choice_Made) {
			room7ChoiceText.text = "ROOM 7 - CHOSE GREEN";
			greenChosen += 1;
			greenRightChosen += 1;
			R7_Choice_Made = true;
			rightChosen += 1;
		} else if (!R7_Choice_1_Taken && R7_Choice_2_Taken && !R7_Choice_Made) {
			room7ChoiceText.text = "ROOM 7 - CHOSE BLUE";
			blueChosen += 1;
			blueLeftChosen += 1;
			R7_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 8 (Yellow and Green)
		if (R8_Choice_1_Taken && !R8_Choice_2_Taken && !R8_Choice_Made) {
			room8ChoiceText.text = "ROOM 8 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowRightChosen += 1;
			R8_Choice_Made = true;
			rightChosen += 1;
		} else if (!R8_Choice_1_Taken && R8_Choice_2_Taken && !R8_Choice_Made) {
			room8ChoiceText.text = "ROOM 8 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
			R8_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 9 (Yellow and Green 2)
		if (R9_Choice_1_Taken && !R9_Choice_2_Taken && !R9_Choice_Made) {
			room9ChoiceText.text = "ROOM 9 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowRightChosen += 1;
			R9_Choice_Made = true;
			rightChosen += 1;
		} else if (!R9_Choice_1_Taken && R9_Choice_2_Taken && !R9_Choice_Made) {
			room9ChoiceText.text = "ROOM 9 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
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
			room10ChoiceText.text = "ROOM 10 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
			R10_Choice_Made = true;
			leftChosen += 1;
		}

		// ROOM 11 (RED AND YELLOW)
		if (R11_Choice_1_Taken && !R11_Choice_2_Taken && !R11_Choice_Made) {
			room11ChoiceText.text = "ROOM 11 - CHOSE RED";
			redChosen += 1;
			redRightChosen += 1;
			R11_Choice_Made = true;
			rightChosen += 1;
		} else if (!R11_Choice_1_Taken && R11_Choice_2_Taken && !R11_Choice_Made) {
			room11ChoiceText.text = "ROOM 11 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowLeftChosen += 1;
			R11_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 12 (RED AND YELLOW 2)
		if (R12_Choice_1_Taken && !R12_Choice_2_Taken && !R12_Choice_Made) {
			room12ChoiceText.text = "ROOM 12 - CHOSE RED";
			redChosen += 1;
			redRightChosen += 1;
			R12_Choice_Made = true;
			rightChosen += 1;
		} else if (!R12_Choice_1_Taken && R12_Choice_2_Taken && !R12_Choice_Made) {
			room12ChoiceText.text = "ROOM 12 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowLeftChosen += 1;
			R12_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 13 (RED AND YELLOW FINAL)
		if (R13_Choice_1_Taken && !R13_Choice_2_Taken && !R13_Choice_Made) {
			room13ChoiceText.text = "ROOM 13 - CHOSE RED";
			redChosen += 1;
			redRightChosen += 1;
			R13_Choice_Made = true;
			rightChosen += 1;
		} else if (!R13_Choice_1_Taken && R13_Choice_2_Taken && !R13_Choice_Made) {
			room13ChoiceText.text = "ROOM 13 - CHOSE YELLOW";
			yellowChosen += 1;
			yellowLeftChosen += 1;
			R13_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 14 (BLUE AND ORANGE)
		if (R14_Choice_1_Taken && !R14_Choice_2_Taken && !R14_Choice_Made) {
			room14ChoiceText.text = "ROOM 14 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
			R14_Choice_Made = true;
			rightChosen += 1;
		} else if (!R14_Choice_1_Taken && R14_Choice_2_Taken && !R14_Choice_Made) {
			room14ChoiceText.text = "ROOM 14 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeLeftChosen += 1;
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
			room15ChoiceText.text = "ROOM 15 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeLeftChosen += 1;
			R15_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 16 (BLUE AND ORANGE FINAL)
		if (R16_Choice_1_Taken && !R16_Choice_2_Taken && !R16_Choice_Made) {
			room16ChoiceText.text = "ROOM 16 - CHOSE BLUE";
			blueChosen += 1;
			blueRightChosen += 1;
			R16_Choice_Made = true;
			rightChosen += 1;
		} else if (!R16_Choice_1_Taken && R16_Choice_2_Taken && !R16_Choice_Made) {
			room16ChoiceText.text = "ROOM 16 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeLeftChosen += 1;
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
			room18ChoiceText.text = "ROOM 18 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeRightChosen += 1;
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
			room19ChoiceText.text = "ROOM 19 - CHOSE ORANGE";
			orangeChosen += 1;
			orangeRightChosen += 1;
			R19_Choice_Made = true;
			rightChosen += 1;
		} else if (!R19_Choice_1_Taken && R19_Choice_2_Taken && !R19_Choice_Made) {
			room19ChoiceText.text = "ROOM 19 - CHOSE GREEN";
			greenChosen += 1;
			greenLeftChosen += 1;
			R19_Choice_Made = true;
			leftChosen += 1;
		}
		// ROOM 20 (BLANK)
		if (R20_Choice_1_Taken && !R20_Choice_2_Taken && !R20_Choice_Made) {
			room20ChoiceText.text = "ROOM 20 - CHOSE RIGHT";
			R20_Choice_Made = true;
			rightChosen += 1;
		} else if (!R20_Choice_1_Taken && R20_Choice_2_Taken && !R20_Choice_Made) {
			room20ChoiceText.text = "ROOM 20 - CHOSE LEFT";
			R20_Choice_Made = true;
			leftChosen += 1;
		}

	}
}

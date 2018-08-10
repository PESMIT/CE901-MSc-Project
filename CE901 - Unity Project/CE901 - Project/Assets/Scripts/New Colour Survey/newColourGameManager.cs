using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class newColourGameManager : MonoBehaviour {

	// Main Room Game Objects
	Renderer portraitA, portraitB;
	Renderer portraitAPlacard, portraitBPlacard;
	Renderer mainAChoice, mainBChoice;
	GameObject player;

	// Noise References
	public AudioClip positiveNoise, negativeNoise;

	// Reference to Collection Scripts
	newColourCollectionScript NCCS_1, NCCS_2;

	// Record Keeping
	[HideInInspector]
	public int R1OptionChosen, R2OptionChosen, R3OptionChosen, R4OptionChosen, R5OptionChosen, R6OptionChosen, R7OptionChosen, R8OptionChosen, R9OptionChosen, R10OptionChosen;
	[HideInInspector]
	public int R11OptionChosen, R12OptionChosen, R13OptionChosen, R14OptionChosen, R15OptionChosen, R16OptionChosen, R17OptionChosen, R18OptionChosen, R19OptionChosen, R20OptionChosen;
	[HideInInspector]
	public int R21OptionChosen, R22OptionChosen, R23OptionChosen, R24OptionChosen, R25OptionChosen, R26OptionChosen, R27OptionChosen, R28OptionChosen, R29OptionChosen, R30OptionChosen;
	[HideInInspector]
	public int R31OptionChosen, R32OptionChosen, R33OptionChosen, R34OptionChosen, R35OptionChosen, R36OptionChosen, R37OptionChosen, R38OptionChosen, R39OptionChosen, R40OptionChosen;
	[HideInInspector]
	public int R41OptionChosen, R42OptionChosen, R43OptionChosen;

	private int RonLeft, RonRight, BonLeft, BonRight, GonLeft, GonRight, YonLeft, YonRight, OonLeft, OonRight, MonLeft, MonRight, ConLeft, ConRight;
	private int leftChosen, rightchosen;
	private int redChosen, blueChosen, greenChosen, yellowChosen, orangeChosen, magentaChosen, cyanChosen;

	private string R1TimeTaken, R2TimeTaken, R3TimeTaken, R4TimeTaken, R5TimeTaken, R6TimeTaken, R7TimeTaken, R8TimeTaken, R9TimeTaken, R10TimeTaken;
	private string R11TimeTaken, R12TimeTaken, R13TimeTaken, R14TimeTaken, R15TimeTaken, R16TimeTaken, R17TimeTaken, R18TimeTaken, R19TimeTaken, R20TimeTaken;
	private string R21TimeTaken, R22TimeTaken, R23TimeTaken, R24TimeTaken, R25TimeTaken, R26TimeTaken, R27TimeTaken, R28TimeTaken, R29TimeTaken, R30TimeTaken;
	private string R31TimeTaken, R32TimeTaken, R33TimeTaken, R34TimeTaken, R35TimeTaken, R36TimeTaken, R37TimeTaken, R38TimeTaken, R39TimeTaken, R40TimeTaken, R41TimeTaken, R42TimeTaken;


	// Game Loop
	[HideInInspector]
	public int gamePhase;

	// Placard Headers
	public Texture[] NCPlacardHeaders;
	// New Colour Images
	public Material[] NCQuestionArray;
	// New Colour Answers
	public Texture[] NCAnswerArray;
	// Tutorial Text
	private GameObject TutorialText;

	// Timer
	private float NCTimer;
	private string minutes;
	private string seconds;
	private Text NCTimerCanvas;

	private bool R1TimeTakenCheck, R2TimeTakenCheck, R3TimeTakenCheck, R4TimeTakenCheck, R5TimeTakenCheck, R6TimeTakenCheck, R7TimeTakenCheck, R8TimeTakenCheck, R9TimeTakenCheck, R10TimeTakenCheck;
	private bool R11TimeTakenCheck, R12TimeTakenCheck, R13TimeTakenCheck, R14TimeTakenCheck, R15TimeTakenCheck, R16TimeTakenCheck, R17TimeTakenCheck, R18TimeTakenCheck, R19TimeTakenCheck, R20TimeTakenCheck;
	private bool R21TimeTakenCheck, R22TimeTakenCheck, R23TimeTakenCheck, R24TimeTakenCheck, R25TimeTakenCheck, R26TimeTakenCheck, R27TimeTakenCheck, R28TimeTakenCheck, R29TimeTakenCheck, R30TimeTakenCheck;
	private bool R31TimeTakenCheck, R32TimeTakenCheck, R33TimeTakenCheck, R34TimeTakenCheck, R35TimeTakenCheck, R36TimeTakenCheck, R37TimeTakenCheck, R38TimeTakenCheck, R39TimeTakenCheck, R40TimeTakenCheck, R41TimeTakenCheck, R42TimeTakenCheck;


	// Use this for initialization
	void Start () {
		// Portraits
		portraitA = GameObject.Find ("portraitA").GetComponent<Renderer>();
		portraitB = GameObject.Find ("portraitB").GetComponent<Renderer>();
		// Portrait Placards
		portraitAPlacard = GameObject.Find("portraitAPlacard").GetComponent<Renderer>();
		portraitBPlacard = GameObject.Find ("portraitBPlacard").GetComponent<Renderer>();
		// Choices
		mainAChoice = GameObject.Find("Option Choice A Stand Text").GetComponent<Renderer>();
		mainBChoice = GameObject.Find ("Option Choice B Stand Text").GetComponent<Renderer> ();
		// Game Loop Start
		gamePhase = 1;
		// Player Ref
		player = GameObject.Find("Player");
		// Collection Script Reference
		NCCS_1 = GameObject.Find("Option Pad 1").GetComponent<newColourCollectionScript>();
		NCCS_2 = GameObject.Find ("Option Pad 2").GetComponent<newColourCollectionScript>();

		// Tutorial Text
		TutorialText = GameObject.Find("TutorialText");
		NCTimerCanvas = GameObject.Find ("TimerText").GetComponent<Text> ();

		// Timer
		NCTimer = 0.0f;
		R1TimeTaken = "";
		R2TimeTaken = "";
		R3TimeTaken = "";
		R4TimeTaken = "";
		R5TimeTaken = "";
		R6TimeTaken = "";
		R7TimeTaken = "";
		R8TimeTaken = "";
		R9TimeTaken = "";
		R10TimeTaken = "";

		R11TimeTaken = "";
		R12TimeTaken = "";
		R13TimeTaken = "";
		R14TimeTaken = "";
		R15TimeTaken = "";
		R16TimeTaken = "";
		R17TimeTaken = "";
		R18TimeTaken = "";
		R19TimeTaken = "";
		R20TimeTaken = "";

		R21TimeTaken = "";
		R22TimeTaken = "";
		R23TimeTaken = "";
		R24TimeTaken = "";
		R25TimeTaken = "";
		R26TimeTaken = "";
		R27TimeTaken = "";
		R28TimeTaken = "";
		R29TimeTaken = "";
		R30TimeTaken = "";

		R31TimeTaken = "";
		R32TimeTaken = "";
		R33TimeTaken = "";
		R34TimeTaken = "";
		R35TimeTaken = "";
		R36TimeTaken = "";
		R37TimeTaken = "";
		R38TimeTaken = "";
		R39TimeTaken = "";
		R40TimeTaken = "";
		R41TimeTaken = "";
		R42TimeTaken = "";

		// Timer Stats
		R1TimeTakenCheck = false;
		R2TimeTakenCheck = false;
		R3TimeTakenCheck = false;
		R4TimeTakenCheck = false;
		R5TimeTakenCheck = false;
		R6TimeTakenCheck = false;
		R7TimeTakenCheck = false;
		R8TimeTakenCheck = false;
		R9TimeTakenCheck = false;
		R10TimeTakenCheck = false;

		R11TimeTakenCheck = false;
		R12TimeTakenCheck = false;
		R13TimeTakenCheck = false;
		R14TimeTakenCheck = false;
		R15TimeTakenCheck = false;
		R16TimeTakenCheck = false;
		R17TimeTakenCheck = false;
		R18TimeTakenCheck = false;
		R19TimeTakenCheck = false;
		R20TimeTakenCheck = false;

		R21TimeTakenCheck = false;
		R22TimeTakenCheck = false;
		R23TimeTakenCheck = false;
		R24TimeTakenCheck = false;
		R25TimeTakenCheck = false;
		R26TimeTakenCheck = false;
		R27TimeTakenCheck = false;
		R28TimeTakenCheck = false;
		R29TimeTakenCheck = false;
		R30TimeTakenCheck = false;

		R31TimeTakenCheck = false;
		R32TimeTakenCheck = false;
		R33TimeTakenCheck = false;
		R34TimeTakenCheck = false;
		R35TimeTakenCheck = false;
		R36TimeTakenCheck = false;
		R37TimeTakenCheck = false;
		R38TimeTakenCheck = false;
		R39TimeTakenCheck = false;
		R40TimeTakenCheck = false;
		R41TimeTakenCheck = false;
		R42TimeTakenCheck = false;
	}

	void TutorialTextOn(){
		TutorialText.SetActive (true);
	}
	void TutorialTextOff(){
		TutorialText.SetActive (false);
	}
	void EndOfGame(){
		TutorialText.SetActive (true);
		TutorialText.GetComponent<Text> ().text = "Thank you for playing the Colour Survey Scenario \n You are now being moved back to the Main Menu";
	}
	void resetTimer(){
		NCTimer = 0f;
		minutes = "";
		seconds = "";
	}
	void startTimer(){
		NCTimer += Time.deltaTime;
	}
	void displayTimer(){
		minutes = Mathf.Floor (NCTimer / 60).ToString ("00");
		seconds = Mathf.RoundToInt (NCTimer % 60).ToString ("00");
		NCTimerCanvas.text = minutes + ":" + seconds;
	}
	void blankTimer(){
		NCTimerCanvas.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		startTimer ();
		displayTimer ();
		blankTimer ();

		gameLoop ();
		if (gamePhase > 42) {
			player.transform.position = new Vector3 (0, 21, 0);
			writeToFile ();
			EndOfGame ();
			Invoke ("backToMainMenu", 2.5f);
			Cursor.visible = true;
		}
		if (Input.GetKeyDown (KeyCode.T)) {
			TutorialTextOn ();
			Invoke ("TutorialTextOff", 10);
		}
	}

	void gameLoop(){
		
		portraitAPlacard.material.mainTexture = NCPlacardHeaders [0];
		portraitBPlacard.material.mainTexture = NCPlacardHeaders [1];

		switch (gamePhase) {
		case 1:
			// Question 1 (Red vs Blue)
			portraitA.material = NCQuestionArray [0];
			portraitB.material = NCQuestionArray [1];
			mainAChoice.material.mainTexture = NCAnswerArray [0];
			mainBChoice.material.mainTexture = NCAnswerArray [1];
			break;
		case 2:
			// Question 2 (Red vs Green)
			portraitA.material = NCQuestionArray [0];
			portraitB.material = NCQuestionArray [2];
			mainAChoice.material.mainTexture = NCAnswerArray [0];
			mainBChoice.material.mainTexture = NCAnswerArray [2];

			// Timer
			if (!R1TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R1TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R1TimeTakenCheck = true;
			}
			break;
		case 3:
			// Question 3 (Red vs Yellow)
			portraitA.material = NCQuestionArray [0];
			portraitB.material = NCQuestionArray [3];
			mainAChoice.material.mainTexture = NCAnswerArray [0];
			mainBChoice.material.mainTexture = NCAnswerArray [3];

			// Timer
			if (!R2TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R2TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R2TimeTakenCheck = true;
			}
			break;
		case 4:
			// Question 4 (Red vs Orange)
			portraitA.material = NCQuestionArray [0];
			portraitB.material = NCQuestionArray [4];
			mainAChoice.material.mainTexture = NCAnswerArray [0];
			mainBChoice.material.mainTexture = NCAnswerArray [4];

			// Timer
			if (!R3TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R3TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R3TimeTakenCheck = true;
			}
			break;
		case 5:
			// Question 5 (Red vs Magenta)
			portraitA.material = NCQuestionArray [0];
			portraitB.material = NCQuestionArray [5];
			mainAChoice.material.mainTexture = NCAnswerArray [0];
			mainBChoice.material.mainTexture = NCAnswerArray [5];

			// Timer
			if (!R4TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R4TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R4TimeTakenCheck = true;
			}
			break;
		case 6:
			// Question 6 (Red vs Cyan)
			portraitA.material = NCQuestionArray [0];
			portraitB.material = NCQuestionArray [6];
			mainAChoice.material.mainTexture = NCAnswerArray [0];
			mainBChoice.material.mainTexture = NCAnswerArray [6];

			// Timer
			if (!R5TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R5TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R5TimeTakenCheck = true;
			}
			break;
		case 7:
			// Question 7 (Blue vs Red)
			portraitA.material = NCQuestionArray [1];
			portraitB.material = NCQuestionArray [0];
			mainAChoice.material.mainTexture = NCAnswerArray [1];
			mainBChoice.material.mainTexture = NCAnswerArray [0];

			// Timer
			if (!R6TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R6TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R6TimeTakenCheck = true;
			}
			break;
		case 8:
			// Question 8 (Blue vs Green)
			portraitA.material = NCQuestionArray [1];
			portraitB.material = NCQuestionArray [2];
			mainAChoice.material.mainTexture = NCAnswerArray [1];
			mainBChoice.material.mainTexture = NCAnswerArray [2];

			// Timer
			if (!R7TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R7TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R7TimeTakenCheck = true;
			}
			break;
		case 9:
			// Question 9 (Blue vs Yellow)
			portraitA.material = NCQuestionArray [1];
			portraitB.material = NCQuestionArray [3];
			mainAChoice.material.mainTexture = NCAnswerArray [1];
			mainBChoice.material.mainTexture = NCAnswerArray [3];

			// Timer
			if (!R8TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R8TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R8TimeTakenCheck = true;
			}
			break;
		case 10:
			// Question 10 (Blue vs Orange)
			portraitA.material = NCQuestionArray [1];
			portraitB.material = NCQuestionArray [4];
			mainAChoice.material.mainTexture = NCAnswerArray [1];
			mainBChoice.material.mainTexture = NCAnswerArray [4];

			// Timer
			if (!R9TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R9TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R9TimeTakenCheck = true;
			}
			break;
		case 11:
			// Question 11 (Blue vs Magenta)
			portraitA.material = NCQuestionArray [1];
			portraitB.material = NCQuestionArray [5];
			mainAChoice.material.mainTexture = NCAnswerArray [1];
			mainBChoice.material.mainTexture = NCAnswerArray [5];

			// Timer
			if (!R10TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R10TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R10TimeTakenCheck = true;
			}
			break;
		case 12:
			// Question 12 (Blue and Cyan)
			portraitA.material = NCQuestionArray [1];
			portraitB.material = NCQuestionArray [6];
			mainAChoice.material.mainTexture = NCAnswerArray [1];
			mainBChoice.material.mainTexture = NCAnswerArray [6];

			// Timer
			if (!R11TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R11TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R11TimeTakenCheck = true;
			}
			break;
		case 13:
			// Question 13 (Green and Red)
			portraitA.material = NCQuestionArray [2];
			portraitB.material = NCQuestionArray [0];
			mainAChoice.material.mainTexture = NCAnswerArray [2];
			mainBChoice.material.mainTexture = NCAnswerArray [0];

			// Timer
			if (!R12TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R12TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R12TimeTakenCheck = true;
			}
			break;
		case 14:
			// Question 14 (Green and Blue)
			portraitA.material = NCQuestionArray [2];
			portraitB.material = NCQuestionArray [1];
			mainAChoice.material.mainTexture = NCAnswerArray [2];
			mainBChoice.material.mainTexture = NCAnswerArray [1];

			// Timer
			if (!R13TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R13TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R13TimeTakenCheck = true;
			}
			break;
		case 15:
			// Question 15 (Green and Yellow)
			portraitA.material = NCQuestionArray [2];
			portraitB.material = NCQuestionArray [3];
			mainAChoice.material.mainTexture = NCAnswerArray [2];
			mainBChoice.material.mainTexture = NCAnswerArray [3];

			// Timer
			if (!R14TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R14TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R14TimeTakenCheck = true;
			}
			break;
		case 16:
			// Question 16 (Green and Orange)
			portraitA.material = NCQuestionArray [2];
			portraitB.material = NCQuestionArray [4];
			mainAChoice.material.mainTexture = NCAnswerArray [2];
			mainBChoice.material.mainTexture = NCAnswerArray [4];

			// Timer
			if (!R15TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R15TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R15TimeTakenCheck = true;
			}
			break;
		case 17:
			// Question 17 (Green and Magenta)
			portraitA.material = NCQuestionArray [2];
			portraitB.material = NCQuestionArray [5];
			mainAChoice.material.mainTexture = NCAnswerArray [2];
			mainBChoice.material.mainTexture = NCAnswerArray [5];

			// Timer
			if (!R16TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R16TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R16TimeTakenCheck = true;
			}
			break;
		case 18:
			// Question 18 (Green and Cyan)
			portraitA.material = NCQuestionArray [2];
			portraitB.material = NCQuestionArray [6];
			mainAChoice.material.mainTexture = NCAnswerArray [2];
			mainBChoice.material.mainTexture = NCAnswerArray [6];

			// Timer
			if (!R17TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R17TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R17TimeTakenCheck = true;
			}
			break;
		case 19:
			// Question 19 (Yellow and Red)
			portraitA.material = NCQuestionArray [3];
			portraitB.material = NCQuestionArray [0];
			mainAChoice.material.mainTexture = NCAnswerArray [3];
			mainBChoice.material.mainTexture = NCAnswerArray [0];

			// Timer
			if (!R18TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R18TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R18TimeTakenCheck = true;
			}
			break;
		case 20:
			// Question 20 (Yellow and Blue)
			portraitA.material = NCQuestionArray [3];
			portraitB.material = NCQuestionArray [1];
			mainAChoice.material.mainTexture = NCAnswerArray [3];
			mainBChoice.material.mainTexture = NCAnswerArray [1];

			// Timer
			if (!R19TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R19TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R19TimeTakenCheck = true;
			}
			break;
		case 21:
			// Question 21 (Yellow and Green)
			portraitA.material = NCQuestionArray [3];
			portraitB.material = NCQuestionArray [2];
			mainAChoice.material.mainTexture = NCAnswerArray [3];
			mainBChoice.material.mainTexture = NCAnswerArray [2];

			// Timer
			if (!R20TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R20TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R20TimeTakenCheck = true;
			}
			break;
		case 22:
			// Question 22 (Yellow and Orange)
			portraitA.material = NCQuestionArray [3];
			portraitB.material = NCQuestionArray [4];
			mainAChoice.material.mainTexture = NCAnswerArray [3];
			mainBChoice.material.mainTexture = NCAnswerArray [4];

			// Timer
			if (!R21TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R21TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R21TimeTakenCheck = true;
			}
			break;
		case 23:
			// Question 23 (Yellow and Magenta)
			portraitA.material = NCQuestionArray [3];
			portraitB.material = NCQuestionArray [5];
			mainAChoice.material.mainTexture = NCAnswerArray [3];
			mainBChoice.material.mainTexture = NCAnswerArray [5];

			// Timer
			if (!R22TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R22TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R22TimeTakenCheck = true;
			}
			break;
		case 24:
			// Question 24 (Yellow and Cyan)
			portraitA.material = NCQuestionArray [3];
			portraitB.material = NCQuestionArray [6];
			mainAChoice.material.mainTexture = NCAnswerArray [3];
			mainBChoice.material.mainTexture = NCAnswerArray [6];

			// Timer
			if (!R23TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R23TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R23TimeTakenCheck = true;
			}
			break;
		case 25:
			// Question 25 (Orange and Red)
			portraitA.material = NCQuestionArray [4];
			portraitB.material = NCQuestionArray [0];
			mainAChoice.material.mainTexture = NCAnswerArray [4];
			mainBChoice.material.mainTexture = NCAnswerArray [0];

			// Timer
			if (!R24TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R24TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R24TimeTakenCheck = true;
			}
			break;
		case 26:
			// Question 27 (Orange and Blue)
			portraitA.material = NCQuestionArray [4];
			portraitB.material = NCQuestionArray [1];
			mainAChoice.material.mainTexture = NCAnswerArray [4];
			mainBChoice.material.mainTexture = NCAnswerArray [1];

			// Timer
			if (!R25TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R25TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R25TimeTakenCheck = true;
			}
			break;
		case 27:
			// Question 27 (Orange and Green)
			portraitA.material = NCQuestionArray [4];
			portraitB.material = NCQuestionArray [2];
			mainAChoice.material.mainTexture = NCAnswerArray [4];
			mainBChoice.material.mainTexture = NCAnswerArray [2];

			// Timer
			if (!R26TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R26TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R26TimeTakenCheck = true;
			}
			break;
		case 28:
			// Question 28 (Orange and Yellow)
			portraitA.material = NCQuestionArray [4];
			portraitB.material = NCQuestionArray [3];
			mainAChoice.material.mainTexture = NCAnswerArray [4];
			mainBChoice.material.mainTexture = NCAnswerArray [3];

			// Timer
			if (!R27TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R27TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R27TimeTakenCheck = true;
			}
			break;
		case 29:
			// Question 29 (Orange and Magenta)
			portraitA.material = NCQuestionArray [4];
			portraitB.material = NCQuestionArray [5];
			mainAChoice.material.mainTexture = NCAnswerArray [4];
			mainBChoice.material.mainTexture = NCAnswerArray [5];

			// Timer
			if (!R28TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R28TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R28TimeTakenCheck = true;
			}
			break;
		case 30:
			// Question 30 (Orange and Cyan)
			portraitA.material = NCQuestionArray [4];
			portraitB.material = NCQuestionArray [6];
			mainAChoice.material.mainTexture = NCAnswerArray [4];
			mainBChoice.material.mainTexture = NCAnswerArray [6];

			// Timer
			if (!R29TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R29TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R29TimeTakenCheck = true;
			}
			break;
		case 31:
			// Question 31 (MAGENTA and RED)
			portraitA.material = NCQuestionArray [5];
			portraitB.material = NCQuestionArray [0];
			mainAChoice.material.mainTexture = NCAnswerArray [5];
			mainBChoice.material.mainTexture = NCAnswerArray [0];

			// Timer
			if (!R30TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R30TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R30TimeTakenCheck = true;
			}
			break;
		case 32:
			// Question 32 (MAGENTA and BLUE)
			portraitA.material = NCQuestionArray [5];
			portraitB.material = NCQuestionArray [1];
			mainAChoice.material.mainTexture = NCAnswerArray [5];
			mainBChoice.material.mainTexture = NCAnswerArray [1];

			// Timer
			if (!R31TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R31TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R31TimeTakenCheck = true;
			}
			break;
		case 33:
			// Question 33 (MAGENTA and GREEN)
			portraitA.material = NCQuestionArray [5];
			portraitB.material = NCQuestionArray [2];
			mainAChoice.material.mainTexture = NCAnswerArray [5];
			mainBChoice.material.mainTexture = NCAnswerArray [2];

			// Timer
			if (!R32TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R32TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R32TimeTakenCheck = true;
			}
			break;
		case 34:
			// Question 34 (MAGENTA and YELLOW)
			portraitA.material = NCQuestionArray [5];
			portraitB.material = NCQuestionArray [3];
			mainAChoice.material.mainTexture = NCAnswerArray [5];
			mainBChoice.material.mainTexture = NCAnswerArray [3];

			// Timer
			if (!R33TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R33TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R33TimeTakenCheck = true;
			}
			break;
		case 35:
			// Question 35 (MAGENTA and ORANGE)
			portraitA.material = NCQuestionArray [5];
			portraitB.material = NCQuestionArray [4];
			mainAChoice.material.mainTexture = NCAnswerArray [5];
			mainBChoice.material.mainTexture = NCAnswerArray [4];

			// Timer
			if (!R34TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R34TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R34TimeTakenCheck = true;
			}
			break;
		case 36:
			// Question 36 (MAGENTA and CYAN)
			portraitA.material = NCQuestionArray [5];
			portraitB.material = NCQuestionArray [6];
			mainAChoice.material.mainTexture = NCAnswerArray [5];
			mainBChoice.material.mainTexture = NCAnswerArray [6];

			// Timer
			if (!R35TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R35TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R35TimeTakenCheck = true;
			}
			break;
		case 37:
			// Question 37 (CYAN and RED)
			portraitA.material = NCQuestionArray [6];
			portraitB.material = NCQuestionArray [0];
			mainAChoice.material.mainTexture = NCAnswerArray [6];
			mainBChoice.material.mainTexture = NCAnswerArray [0];

			// Timer
			if (!R36TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R36TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R36TimeTakenCheck = true;
			}
			break;
		case 38:
			// Question 38 (CYAN and BLUE)
			portraitA.material = NCQuestionArray [6];
			portraitB.material = NCQuestionArray [1];
			mainAChoice.material.mainTexture = NCAnswerArray [6];
			mainBChoice.material.mainTexture = NCAnswerArray [1];

			// Timer
			if (!R37TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R37TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R37TimeTakenCheck = true;
			}
			break;
		case 39:
			// Question 39 (CYAN AND GREEN)
			portraitA.material = NCQuestionArray [6];
			portraitB.material = NCQuestionArray [2];
			mainAChoice.material.mainTexture = NCAnswerArray [6];
			mainBChoice.material.mainTexture = NCAnswerArray [2];

			// Timer
			if (!R38TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R38TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R38TimeTakenCheck = true;
			}
			break;
		case 40:
			// Question 40 (CYAN AND YELLOW)
			portraitA.material = NCQuestionArray [6];
			portraitB.material = NCQuestionArray [3];
			mainAChoice.material.mainTexture = NCAnswerArray [6];
			mainBChoice.material.mainTexture = NCAnswerArray [3];

			// Timer
			if (!R39TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R39TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R39TimeTakenCheck = true;
			}
			break;
		case 41:
			// Question 41 (CYAN AND ORANGE)
			portraitA.material = NCQuestionArray [6];
			portraitB.material = NCQuestionArray [4];
			mainAChoice.material.mainTexture = NCAnswerArray [6];
			mainBChoice.material.mainTexture = NCAnswerArray [4];

			// Timer
			if (!R40TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R40TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R40TimeTakenCheck = true;
			}
			break;
		case 42:
			// Question 42 (CYAN AND MAGENTA)
			portraitA.material = NCQuestionArray [6];
			portraitB.material = NCQuestionArray [5];
			mainAChoice.material.mainTexture = NCAnswerArray [6];
			mainBChoice.material.mainTexture = NCAnswerArray [5];

			// Timer
			if (!R41TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R41TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R41TimeTakenCheck = true;
			}
			break;
		case 43:
			// Question 43 (END)
			portraitA.material = NCQuestionArray [6];
			portraitB.material = NCQuestionArray [5];
			mainAChoice.material.mainTexture = NCAnswerArray [6];
			mainBChoice.material.mainTexture = NCAnswerArray [5];

			// Timer
			if (!R42TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R42TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R42TimeTakenCheck = true;
			}
			break;
		}
	}

	void OnTriggerStay(Collider other){
		if (other.name == "Player") {
			if (Input.GetKeyDown (KeyCode.E)) {
				if (gamePhase <= 43 && (NCCS_1.optionPad1_Chosen || NCCS_2.optionPad2_Chosen)) {
					checkCollection ();
					this.GetComponent<AudioSource> ().PlayOneShot (positiveNoise);
					NCCS_1.resetPads ();
					NCCS_2.resetPads ();
				} else {
					this.GetComponent<AudioSource> ().PlayOneShot (negativeNoise);
					NCCS_1.resetPads ();
					NCCS_2.resetPads ();
				}
			}
		}
	}

	private void backToMainMenu(){
		SceneManager.LoadSceneAsync ("MainMenu");
	}

	private void incrementRed(string direction){
		if (direction == "left") {
			RonLeft += 1;
			redChosen += 1;
		} else if (direction == "right") {
			RonRight += 1;
			redChosen += 1;
		}
	}

	private void incrementBlue(string direction){
		if (direction == "left") {
			BonLeft += 1;
			blueChosen += 1;
		} else if (direction == "right") {
			BonRight += 1;
			blueChosen += 1;
		}
	}

	private void incrementGreen(string direction){
		if (direction == "left") {
			GonLeft += 1;
			greenChosen += 1;
		} else if (direction == "right") {
			GonRight += 1;
			greenChosen += 1;
		}
	}

	private void incrementYellow(string direction){
		if (direction == "left") {
			YonLeft += 1;
			yellowChosen += 1;
		} else if (direction == "right") {
			YonRight += 1;
			yellowChosen += 1;
		}
	}

	private void incrementOrange(string direction){
		if (direction == "left") {
			OonLeft += 1;
			orangeChosen += 1;
		} else if (direction == "right") {
			OonRight += 1;
			orangeChosen += 1;
		}
	}

	private void incrementMagenta(string direction){
		if (direction == "left") {
			MonLeft += 1;
			magentaChosen += 1;
		} else if (direction == "right") {
			MonRight += 1;
			magentaChosen += 1;
		}
	}

	private void incrementCyan(string direction){
		if (direction == "left") {
			ConLeft += 1;
			cyanChosen += 1;
		} else if (direction == "right") {
			ConRight += 1;
			cyanChosen += 1;
		}
	}

	void checkCollection(){
		// RED or BLUE
		if (gamePhase == 1) {
			if (NCCS_1.optionPad1_Chosen) {
				R1OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 2;
			} else if (NCCS_2.optionPad2_Chosen) {
				R1OptionChosen = 2;
				incrementBlue ("right");
				gamePhase = 2;
			}
		} else if (gamePhase == 2) { // RED OR GREEN
			if (NCCS_1.optionPad1_Chosen) {
				R2OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 3;
			} else if (NCCS_2.optionPad2_Chosen) {
				R2OptionChosen = 2;
				incrementGreen ("right");
				gamePhase = 3;
			}
		} else if (gamePhase == 3) { // RED OR YELLOW
			if (NCCS_1.optionPad1_Chosen) {
				R3OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 4;
			} else if (NCCS_2.optionPad2_Chosen) {
				R3OptionChosen = 2;
				incrementYellow ("right");
				gamePhase = 4;
			}
		} else if (gamePhase == 4) { // RED OR ORANGE
			if (NCCS_1.optionPad1_Chosen) {
				R4OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 5;
			} else if (NCCS_2.optionPad2_Chosen) {
				R4OptionChosen = 2;
				incrementOrange ("right");
				gamePhase = 5;
			}
		} else if (gamePhase == 5) { // RED OR MAGENTA
			if (NCCS_1.optionPad1_Chosen) {
				R5OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 6;
			} else if (NCCS_2.optionPad2_Chosen) {
				R5OptionChosen = 2;
				incrementMagenta ("right");
				gamePhase = 6;
			}
		} else if (gamePhase == 6) { // RED OR CYAN
			if (NCCS_1.optionPad1_Chosen) {
				R6OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 7;
			} else if (NCCS_2.optionPad2_Chosen) {
				R6OptionChosen = 2;
				incrementCyan ("right");
				gamePhase = 7;
			}
		} else if (gamePhase == 7) { // BLUE OR RED
			if (NCCS_1.optionPad1_Chosen) {
				R7OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 8;
			} else if (NCCS_2.optionPad2_Chosen) {
				R7OptionChosen = 2;
				incrementRed ("right");
				gamePhase = 8;
			}
		} else if (gamePhase == 8) { // BLUE OR GREEN
			if (NCCS_1.optionPad1_Chosen) {
				R8OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 9;
			} else if (NCCS_2.optionPad2_Chosen) {
				R8OptionChosen = 2;
				incrementGreen ("right");
				gamePhase = 9;
			}
		} else if (gamePhase == 9) { // BLUE OR YELLOW
			if (NCCS_1.optionPad1_Chosen) {
				R9OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 10;
			} else if (NCCS_2.optionPad2_Chosen) {
				R9OptionChosen = 2;
				incrementYellow ("right");
				gamePhase = 10;
			}
		} else if (gamePhase == 10) { // BLUE OR ORANGE
			if (NCCS_1.optionPad1_Chosen) {
				R10OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 11;
			} else if (NCCS_2.optionPad2_Chosen) {
				R10OptionChosen = 2;
				incrementOrange ("right");
				gamePhase = 11;
			}
		} else if (gamePhase == 11) { // BLUE OR MAGENTA
			if (NCCS_1.optionPad1_Chosen) {
				R11OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 12;
			} else if (NCCS_2.optionPad2_Chosen) {
				R11OptionChosen = 2;
				incrementMagenta ("right");
				gamePhase = 12;
			}
		} else if (gamePhase == 12) { // BLUE OR CYAN
			if (NCCS_1.optionPad1_Chosen) {
				R12OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 13;
			} else if (NCCS_2.optionPad2_Chosen) {
				R2OptionChosen = 2;
				incrementCyan ("right");
				gamePhase = 13;
			}
		} else if (gamePhase == 13) { // GREEN OR RED
			if (NCCS_1.optionPad1_Chosen) {
				R13OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 14;
			} else if (NCCS_2.optionPad2_Chosen) {
				R13OptionChosen = 2;
				incrementRed ("right");
				gamePhase = 14;
			}
		} else if (gamePhase == 14) { // GREEN OR BLUE
			if (NCCS_1.optionPad1_Chosen) {
				R14OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 15;
			} else if (NCCS_2.optionPad2_Chosen) {
				R14OptionChosen = 2;
				incrementBlue ("right");
				gamePhase = 15;
			}
		} else if (gamePhase == 15) { // GREEN OR YELLOW
			if (NCCS_1.optionPad1_Chosen) {
				R15OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 16;
			} else if (NCCS_2.optionPad2_Chosen) {
				R15OptionChosen = 2;
				incrementYellow ("right");
				gamePhase = 16;
			}
		} else if (gamePhase == 16) { // GREEN OR ORANGE
			if (NCCS_1.optionPad1_Chosen) {
				R16OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 17;
			} else if (NCCS_2.optionPad2_Chosen) {
				R16OptionChosen = 2;
				incrementOrange ("right");
				gamePhase = 17;
			}
		} else if (gamePhase == 17) { // GREEN OR MAGENTA
			if (NCCS_1.optionPad1_Chosen) {
				R17OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 18;
			} else if (NCCS_2.optionPad2_Chosen) {
				R17OptionChosen = 2;
				incrementMagenta ("right");
				gamePhase = 18;
			}
		} else if (gamePhase == 18) { // GREEN OR CYAN
			if (NCCS_1.optionPad1_Chosen) {
				R18OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 19;
			} else if (NCCS_2.optionPad2_Chosen) {
				R18OptionChosen = 2;
				incrementCyan ("right");
				gamePhase = 19;
			}
		} else if (gamePhase == 19) { // YELLOW OR RED
			if (NCCS_1.optionPad1_Chosen) {
				R19OptionChosen = 1;
				incrementYellow ("left");
				gamePhase = 20;
			} else if (NCCS_2.optionPad2_Chosen) {
				R19OptionChosen = 2;
				incrementRed ("right");
				gamePhase = 20;
			}
		} else if (gamePhase == 20) { // YELLOW OR BLUE
			if (NCCS_1.optionPad1_Chosen) {
				R20OptionChosen = 1;
				incrementYellow ("left");
				gamePhase = 21;
			} else if (NCCS_2.optionPad2_Chosen) {
				R20OptionChosen = 2;
				incrementBlue ("right");
				gamePhase = 21;
			}
		} else if (gamePhase == 21) { // YELLOW OR GREEN
			if (NCCS_1.optionPad1_Chosen) {
				R21OptionChosen = 1;
				incrementYellow ("left");
				gamePhase = 22;
			} else if (NCCS_2.optionPad2_Chosen) {
				R21OptionChosen = 2;
				incrementGreen ("right");
				gamePhase = 22;
			}
		} else if (gamePhase == 22) { // YELLOW or ORANGE
			if (NCCS_1.optionPad1_Chosen) {
				R22OptionChosen = 1;
				incrementYellow ("left");
				gamePhase = 23;
			} else if (NCCS_2.optionPad2_Chosen) {
				R22OptionChosen = 2;
				incrementOrange ("right");
				gamePhase = 23;
			}
		} else if (gamePhase == 23) { // YELLOW OR MAGENTA
			if (NCCS_1.optionPad1_Chosen) {
				R23OptionChosen = 1;
				incrementYellow ("left");
				gamePhase = 24;
			} else if (NCCS_2.optionPad2_Chosen) {
				R23OptionChosen = 2;
				incrementMagenta ("right");
				gamePhase = 24;
			}
		} else if (gamePhase == 24) { // YELLOW OR CYAN
			if (NCCS_1.optionPad1_Chosen) {
				R24OptionChosen = 1;
				incrementYellow ("left");
				gamePhase = 25;
			} else if (NCCS_2.optionPad2_Chosen) {
				R24OptionChosen = 2;
				incrementCyan ("right");
				gamePhase = 25;
			}
		} else if (gamePhase == 25) { // ORANGE OR RED
			if (NCCS_1.optionPad1_Chosen) {
				R25OptionChosen = 1;
				incrementOrange ("left");
				gamePhase = 26;
			} else if (NCCS_2.optionPad2_Chosen) {
				R25OptionChosen = 2;
				incrementYellow ("right");
				gamePhase = 26;
			}
		} else if (gamePhase == 26) { // ORANGE OR BLUE
			if (NCCS_1.optionPad1_Chosen) {
				R26OptionChosen = 1;
				incrementOrange ("left");
				gamePhase = 27;
			} else if (NCCS_2.optionPad2_Chosen) {
				R26OptionChosen = 2;
				incrementBlue ("right");
				gamePhase = 27;
			}
		} else if (gamePhase == 27) { // ORANGE OR GREEN
			if (NCCS_1.optionPad1_Chosen) {
				R27OptionChosen = 1;
				incrementOrange ("left");
				gamePhase = 28;
			} else if (NCCS_2.optionPad2_Chosen) {
				R27OptionChosen = 2;
				incrementGreen ("right");
				gamePhase = 28;
			}
		} else if (gamePhase == 28) { // ORANGE OR YELLOW
			if (NCCS_1.optionPad1_Chosen) {
				R28OptionChosen = 1;
				incrementOrange ("left");
				gamePhase = 29;
			} else if (NCCS_2.optionPad2_Chosen) {
				R28OptionChosen = 2;
				incrementYellow ("right");
				gamePhase = 29;
			}
		} else if (gamePhase == 29) { // ORANGE OR MAGENTA
			if (NCCS_1.optionPad1_Chosen) {
				R29OptionChosen = 1;
				incrementOrange ("left");
				gamePhase = 30;
			} else if (NCCS_2.optionPad2_Chosen) {
				R29OptionChosen = 2;
				incrementMagenta ("right");
				gamePhase = 30;
			}
		} else if (gamePhase == 30) { // ORANGE OR CYAN
			if (NCCS_1.optionPad1_Chosen) {
				R30OptionChosen = 1;
				incrementOrange ("left");
				gamePhase = 31;
			} else if (NCCS_2.optionPad2_Chosen) {
				R30OptionChosen = 2;
				incrementCyan ("right");
				gamePhase = 31;
			}
		} else if (gamePhase == 31) { // MAGENTA or RED
			if (NCCS_1.optionPad1_Chosen) {
				R31OptionChosen = 1;
				incrementMagenta ("left");
				gamePhase = 32;
			} else if (NCCS_2.optionPad2_Chosen) {
				R31OptionChosen = 2;
				incrementRed("right");
				gamePhase = 32;
			}
		} else if (gamePhase == 32) { // MAGENTA or BLUE
			if (NCCS_1.optionPad1_Chosen) {
				R32OptionChosen = 1;
				incrementMagenta("left");
				gamePhase = 33;
			} else if (NCCS_2.optionPad2_Chosen) {
				R32OptionChosen = 2;
				incrementBlue ("right");
				gamePhase = 33;
			}
		} else if (gamePhase == 33) { // MAGENTA or GREEN
			if (NCCS_1.optionPad1_Chosen) {
				R33OptionChosen = 1;
				incrementMagenta("left");
				gamePhase = 34;
			} else if (NCCS_2.optionPad2_Chosen) {
				R33OptionChosen = 2;
				incrementGreen("right");
				gamePhase = 34;
			}
		} else if (gamePhase == 34) { // MAGENTA or YELLOW
			if (NCCS_1.optionPad1_Chosen) {
				R34OptionChosen = 1;
				incrementMagenta("left");
				gamePhase = 35;
			} else if (NCCS_2.optionPad2_Chosen) {
				R34OptionChosen = 2;
				incrementBlue ("right");
				gamePhase = 35;
			}
		} else if (gamePhase == 35) { // MAGENTA or ORANGE
			if (NCCS_1.optionPad1_Chosen) {
				R35OptionChosen = 1;
				incrementMagenta("left");
				gamePhase = 36;
			} else if (NCCS_2.optionPad2_Chosen) {
				R35OptionChosen = 2;
				incrementOrange ("right");
				gamePhase = 36;
			}
		} else if (gamePhase == 36) { // MAGENTA or CYAN
			if (NCCS_1.optionPad1_Chosen) {
				R36OptionChosen = 1;
				incrementMagenta("left");
				gamePhase = 37;
			} else if (NCCS_2.optionPad2_Chosen) {
				R36OptionChosen = 2;
				incrementCyan ("right");
				gamePhase = 37;
			}
		} else if (gamePhase == 37) { // CYAN or RED
			if (NCCS_1.optionPad1_Chosen) {
				R37OptionChosen = 1;
				incrementCyan("left");
				gamePhase = 38;
			} else if (NCCS_2.optionPad2_Chosen) {
				R37OptionChosen = 2;
				incrementRed ("right");
				gamePhase = 38;
			}
		} else if (gamePhase == 38) { // CYAN or BLUE
			if (NCCS_1.optionPad1_Chosen) {
				R38OptionChosen = 1;
				incrementCyan("left");
				gamePhase = 39;
			} else if (NCCS_2.optionPad2_Chosen) {
				R38OptionChosen = 2;
				incrementBlue ("right");
				gamePhase = 39;
			}
		} else if (gamePhase == 39) { // CYAN or GREEN
			if (NCCS_1.optionPad1_Chosen) {
				R39OptionChosen = 1;
				incrementCyan("left");
				gamePhase = 40;
			} else if (NCCS_2.optionPad2_Chosen) {
				R39OptionChosen = 2;
				incrementGreen ("right");
				gamePhase = 40;
			}
		} else if (gamePhase == 40) { // CYAN or YELLOW
			if (NCCS_1.optionPad1_Chosen) {
				R40OptionChosen = 1;
				incrementCyan("left");
				gamePhase = 41;
			} else if (NCCS_2.optionPad2_Chosen) {
				R40OptionChosen = 2;
				incrementYellow ("right");
				gamePhase = 41;
			}
		} else if (gamePhase == 41) { // CYAN or ORANGE
			if (NCCS_1.optionPad1_Chosen) {
				R41OptionChosen = 1;
				incrementCyan("left");
				gamePhase = 42;
			} else if (NCCS_2.optionPad2_Chosen) {
				R41OptionChosen = 2;
				incrementOrange ("right");
				gamePhase = 42;
			}
		} else if (gamePhase == 42) { // CYAN or MAGENTA
			if (NCCS_1.optionPad1_Chosen) {
				R42OptionChosen = 1;
				incrementCyan("left");
				gamePhase = 43;
			} else if (NCCS_2.optionPad2_Chosen) {
				R42OptionChosen = 2;
				incrementMagenta ("right");
				gamePhase = 43;
			}
		}
	} 

	void writeToFile(){
		// INPUT WRITER
		string path = Application.dataPath.ToString() + @"\Colour Survey Results.txt";
		if (File.Exists (path)) {
			File.Delete (path);
			writeToFile ();
		} if (!File.Exists (path)) {
			string mainTitleText = "YOUR RESULTS" + Environment.NewLine;
			// ROOM 1 - RED VS BLUE
			string H1Text = "ROOM 1 - Q1 - RED OR BLUE" + Environment.NewLine;
			string R1Choice = "";
			if (R1OptionChosen == 1) {R1Choice = "RED" + Environment.NewLine;}
			if (R1OptionChosen == 2) {R1Choice = "BLUE" + Environment.NewLine;}
			// ROOM 2 - RED VS GREEN
			string H2Text = "ROOM 2 - Q3 - RED OR GREEN" + Environment.NewLine;
			string R2Choice = "";
			if (R2OptionChosen == 1) {R2Choice = "RED" + Environment.NewLine;}
			if (R2OptionChosen == 2) {R2Choice = "GREEN" + Environment.NewLine;}
			// ROOM 3 - RED VS YELLOW
			string H3Text = "ROOM 3 - Q3 - RED OR YELLOW" + Environment.NewLine;
			string R3Choice = "";
			if (R3OptionChosen == 1) {R3Choice = "RED" + Environment.NewLine;}
			if (R3OptionChosen == 2) {R3Choice = "YELLOW" + Environment.NewLine;}
			// ROOM 4 - RED VS ORANGE
			string H4Text = "ROOM 4 - Q4 - RED OR ORANGE" + Environment.NewLine;
			string R4Choice = "";
			if (R4OptionChosen == 1) {R4Choice = "RED" + Environment.NewLine;}
			if (R4OptionChosen == 2) {R4Choice = "ORANGE" + Environment.NewLine;}
			// ROOM 5 - RED VS MAGENTA
			string H5Text = "ROOM 5 - Q5 - RED OR MAGENTA" + Environment.NewLine;
			string R5Choice = "";
			if (R5OptionChosen == 1) {R5Choice = "RED" + Environment.NewLine;}
			if (R5OptionChosen == 2) {R5Choice = "MAGENTA" + Environment.NewLine;}
			// ROOM 6 - RED VS CYAN
			string H6Text = "ROOM 6 - Q6 - RED OR CYAN" + Environment.NewLine;
			string R6Choice = "";
			if (R6OptionChosen == 1) {R6Choice = "RED" + Environment.NewLine;}
			if (R6OptionChosen == 2) {R6Choice = "CYAN" + Environment.NewLine;}
			// ROOM 7 - BLUE OR RED
			string H7Text = "ROOM 7 - Q7 - BLUE OR RED" + Environment.NewLine;
			string R7Choice = "";
			if (R7OptionChosen == 1) {R7Choice = "BLUE" + Environment.NewLine;}
			if (R7OptionChosen == 2) {R7Choice = "RED" + Environment.NewLine;}
			// ROOM 8 - BLUE OR GREEN
			string H8Text = "ROOM 8 - Q8 - BLUE OR GREEN" + Environment.NewLine;
			string R8Choice = "";
			if (R8OptionChosen == 1) {R8Choice = "BLUE" + Environment.NewLine;}
			if (R8OptionChosen == 2) {R8Choice = "GREEN" + Environment.NewLine;}
			// ROOM 9 - BLUE OR YELLOW
			string H9Text = "ROOM 9 - Q9 - BLUE OR YELLOW" + Environment.NewLine;
			string R9Choice = "";
			if (R9OptionChosen == 1) {R9Choice = "BLUE" + Environment.NewLine;}
			if (R9OptionChosen == 2) {R9Choice = "YELLOW" + Environment.NewLine;}
			// ROOM 10 - BLUE OR ORANGE
			string H10Text = "ROOM 10 - Q10 - BLUE OR ORANGE" + Environment.NewLine;
			string R10Choice = "";
			if (R10OptionChosen == 1) {R10Choice = "BLUE" + Environment.NewLine;}
			if (R10OptionChosen == 2) {R10Choice = "ORANGE" + Environment.NewLine;}
			// ROOM 11 - BLUE OR MAGENTA
			string H11Text = "ROOM 11 - Q11 - BLUE OR MAGENTA" + Environment.NewLine;
			string R11Choice = "";
			if (R11OptionChosen == 1) {R11Choice = "BLUE" + Environment.NewLine;}
			if (R11OptionChosen == 2) {R11Choice = "MAGENTA" + Environment.NewLine;}
			// ROOM 12 - BLUE OR CYAN
			string H12Text = "ROOM 12 - Q12 - BLUE OR CYAN" + Environment.NewLine;
			string R12Choice = "";
			if (R12OptionChosen == 1) {R12Choice = "BLUE" + Environment.NewLine;}
			if (R12OptionChosen == 2) {R12Choice = "CYAN" + Environment.NewLine;}
			// ROOM 13 - GREEN OR RED
			string H13Text = "ROOM 13 - Q13 - GREEN OR RED" + Environment.NewLine;
			string R13Choice = "";
			if (R13OptionChosen == 1) {R13Choice = "GREEN" + Environment.NewLine;}
			if (R13OptionChosen == 2) {R13Choice = "RED" + Environment.NewLine;}
			// ROOM 14 - GREEN OR BLUE
			string H14Text = "ROOM 14 - Q14 - GREEN OR BLUE" + Environment.NewLine;
			string R14Choice = "";
			if (R14OptionChosen == 1) {R14Choice = "GREEN" + Environment.NewLine;}
			if (R14OptionChosen == 2) {R14Choice = "BLUE" + Environment.NewLine;}
			// ROOM 15 - GREEN OR YELLOW
			string H15Text = "ROOM 15 - Q15 - GREEN OR YELLOW" + Environment.NewLine;
			string R15Choice = "";
			if (R15OptionChosen == 1) {R15Choice = "GREEN" + Environment.NewLine;}
			if (R15OptionChosen == 2) {R15Choice = "YELLOW" + Environment.NewLine;}
			// ROOM 16 - GREEN OR ORANGE
			string H16Text = "ROOM 16 - Q16 - GREEN OR ORANGE" + Environment.NewLine;
			string R16Choice = "";
			if (R16OptionChosen == 1) {R16Choice = "GREEN" + Environment.NewLine;}
			if (R16OptionChosen == 2) {R16Choice = "ORANGE" + Environment.NewLine;}
			// ROOM 17 - GREEN OR MAGENTA
			string H17Text = "ROOM 17 - Q17 - GREEN OR MAGENTA" + Environment.NewLine;
			string R17Choice = "";
			if (R17OptionChosen == 1) {R17Choice = "GREEN" + Environment.NewLine;}
			if (R17OptionChosen == 2) {R17Choice = "MAGENTA" + Environment.NewLine;}
			// ROOM 18 - GREEN OR CYAN
			string H18Text = "ROOM 18 - Q18 - GREEN OR CYAN" + Environment.NewLine;
			string R18Choice = "";
			if (R18OptionChosen == 1) {R18Choice = "GREEN" + Environment.NewLine;}
			if (R18OptionChosen == 2) {R18Choice = "CYAN" + Environment.NewLine;}
			// ROOM 19 - YELLOW OR RED
			string H19Text = "ROOM 19 - Q19 - YELLOW OR RED" + Environment.NewLine;
			string R19Choice = "";
			if (R19OptionChosen == 1) {R19Choice = "YELLOW" + Environment.NewLine;}
			if (R19OptionChosen == 2) {R19Choice = "RED" + Environment.NewLine;}
			// ROOM 20 - YELLOW OR BLUE
			string H20Text = "ROOM 20 - Q20 - YELLOW OR BLUE" + Environment.NewLine;
			string R20Choice = "";
			if (R20OptionChosen == 1) {R20Choice = "YELLOW" + Environment.NewLine;}
			if (R20OptionChosen == 2) {R20Choice = "BLUE" + Environment.NewLine;}
			// ROOM 21 - YELLOW OR GREEN
			string H21Text = "ROOM 21 - Q21 - YELLOW OR GREEN" + Environment.NewLine;
			string R21Choice = "";
			if (R21OptionChosen == 1) {R21Choice = "YELLOW" + Environment.NewLine;}
			if (R21OptionChosen == 2) {R21Choice = "GREEN" + Environment.NewLine;}
			// ROOM 22 - YELLOW OR GREEN
			string H22Text = "ROOM 22 - Q22 - YELLOW OR ORANGE" + Environment.NewLine;
			string R22Choice = "";
			if (R22OptionChosen == 1) {R22Choice = "YELLOW" + Environment.NewLine;}
			if (R22OptionChosen == 2) {R22Choice = "ORANGE" + Environment.NewLine;}
			// ROOM 23 - YELLOW OR MAGENTA
			string H23Text = "ROOM 23 - Q23 - YELLOW OR MAGENTA" + Environment.NewLine;
			string R23Choice = "";
			if (R23OptionChosen == 1) {R23Choice = "YELLOW" + Environment.NewLine;}
			if (R23OptionChosen == 2) {R23Choice = "MAGENTA" + Environment.NewLine;}
			// ROOM 24 - YELLOW OR CYAN
			string H24Text = "ROOM 24 - Q24 - YELLOW OR CYAN" + Environment.NewLine;
			string R24Choice = "";
			if (R24OptionChosen == 1) {R24Choice = "YELLOW" + Environment.NewLine;}
			if (R24OptionChosen == 2) {R24Choice = "CYAN" + Environment.NewLine;}
			// ROOM 25 - ORANGE OR RED
			string H25Text = "ROOM 25 - Q25 - ORANGE OR RED" + Environment.NewLine;
			string R25Choice = "";
			if (R25OptionChosen == 1) {R25Choice = "ORANGE" + Environment.NewLine;}
			if (R25OptionChosen == 2) {R25Choice = "RED" + Environment.NewLine;}
			// ROOM 26 - ORANGE OR BLUE
			string H26Text = "ROOM 26 - Q26 - ORANGE OR BLUE" + Environment.NewLine;
			string R26Choice = "";
			if (R26OptionChosen == 1) {R26Choice = "ORANGE" + Environment.NewLine;}
			if (R26OptionChosen == 2) {R26Choice = "BLUE" + Environment.NewLine;}
			// ROOM 27 - ORANGE OR GREEN
			string H27Text = "ROOM 27 - Q27 - ORANGE OR GREEN" + Environment.NewLine;
			string R27Choice = "";
			if (R27OptionChosen == 1) {R27Choice = "ORANGE" + Environment.NewLine;}
			if (R27OptionChosen == 2) {R27Choice = "GREEN" + Environment.NewLine;}
			// ROOM 28 - ORANGE OR YELLOW
			string H28Text = "ROOM 28 - Q28 - ORANGE OR YELLOW" + Environment.NewLine;
			string R28Choice = "";
			if (R28OptionChosen == 1) {R28Choice = "ORANGE" + Environment.NewLine;}
			if (R28OptionChosen == 2) {R28Choice = "YELLOW" + Environment.NewLine;}
			// ROOM 29 - ORANGE OR MAGENTA
			string H29Text = "ROOM 29 - Q29 - ORANGE OR MAGENTA" + Environment.NewLine;
			string R29Choice = "";
			if (R29OptionChosen == 1) {R29Choice = "ORANGE" + Environment.NewLine;}
			if (R29OptionChosen == 2) {R29Choice = "MAGENTA" + Environment.NewLine;}
			// ROOM 30 - ORANGE OR MAGENTA
			string H30Text = "ROOM 30 - Q30 - ORANGE OR CYAN" + Environment.NewLine;
			string R30Choice = "";
			if (R30OptionChosen == 1) {R30Choice = "ORANGE" + Environment.NewLine;}
			if (R30OptionChosen == 2) {R30Choice = "CYAN" + Environment.NewLine;}
			// ROOM 31 - MAGENTA OR RED
			string H31Text = "ROOM 31 - Q31 - MAGENTA OR RED" + Environment.NewLine;
			string R31Choice = "";
			if (R31OptionChosen == 1) {R31Choice = "MAGENTA" + Environment.NewLine;}
			if (R31OptionChosen == 2) {R31Choice = "RED" + Environment.NewLine;}
			// ROOM 32 - MAGENTA OR BLUE
			string H32Text = "ROOM 32 - Q32 - MAGENTA OR BLUE" + Environment.NewLine;
			string R32Choice = "";
			if (R32OptionChosen == 1) {R32Choice = "MAGENTA" + Environment.NewLine;}
			if (R32OptionChosen == 2) {R32Choice = "BLUE" + Environment.NewLine;}
			// ROOM 33 - MAGENTA OR GREEN
			string H33Text = "ROOM 33 - Q33 - MAGENTA OR GREEN" + Environment.NewLine;
			string R33Choice = "";
			if (R33OptionChosen == 1) {R33Choice = "MAGENTA" + Environment.NewLine;}
			if (R33OptionChosen == 2) {R33Choice = "GREEN" + Environment.NewLine;}
			// ROOM 34 - MAGENTA OR YELLOW
			string H34Text = "ROOM 34 - Q34 - MAGENTA OR YELLOW" + Environment.NewLine;
			string R34Choice = "";
			if (R34OptionChosen == 1) {R34Choice = "MAGENTA" + Environment.NewLine;}
			if (R34OptionChosen == 2) {R34Choice = "YELLOW" + Environment.NewLine;}
			// ROOM 35 - MAGENTA OR ORANGE
			string H35Text = "ROOM 35 - Q35 - MAGENTA OR ORANGE" + Environment.NewLine;
			string R35Choice = "";
			if (R35OptionChosen == 1) {R35Choice = "MAGENTA" + Environment.NewLine;}
			if (R35OptionChosen == 2) {R35Choice = "ORANGE" + Environment.NewLine;}
			// ROOM 36 - MAGENTA OR CYAN
			string H36Text = "ROOM 36 - Q36 - MAGENTA OR CYAN" + Environment.NewLine;
			string R36Choice = "";
			if (R36OptionChosen == 1) {R36Choice = "MAGENTA" + Environment.NewLine;}
			if (R36OptionChosen == 2) {R36Choice = "CYAN" + Environment.NewLine;}
			// ROOM 37 - CYAN OR RED
			string H37Text = "ROOM 37 - Q37 - CYAN OR RED" + Environment.NewLine;
			string R37Choice = "";
			if (R37OptionChosen == 1) {R37Choice = "CYAN" + Environment.NewLine;}
			if (R37OptionChosen == 2) {R37Choice = "RED" + Environment.NewLine;}
			// ROOM 38 - CYAN OR BLUE
			string H38Text = "ROOM 38 - Q38 - CYAN OR BLUE" + Environment.NewLine;
			string R38Choice = "";
			if (R38OptionChosen == 1) {R38Choice = "CYAN" + Environment.NewLine;}
			if (R38OptionChosen == 2) {R38Choice = "BLUE" + Environment.NewLine;}
			// ROOM 39 - CYAN OR GREEN
			string H39Text = "ROOM 39 - Q39 - CYAN OR GREEN" + Environment.NewLine;
			string R39Choice = "";
			if (R39OptionChosen == 1) {R39Choice = "CYAN" + Environment.NewLine;}
			if (R39OptionChosen == 2) {R39Choice = "GREEN" + Environment.NewLine;}
			// ROOM 40 - CYAN OR YELLOW
			string H40Text = "ROOM 40 - Q40 - CYAN OR YELLOW" + Environment.NewLine;
			string R40Choice = "";
			if (R40OptionChosen == 1) {R40Choice = "CYAN" + Environment.NewLine;}
			if (R40OptionChosen == 2) {R40Choice = "YELLOW" + Environment.NewLine;}
			// ROOM 41 - CYAN OR ORANGE
			string H41Text = "ROOM 41 - Q41 - CYAN OR ORANGE" + Environment.NewLine;
			string R41Choice = "";
			if (R41OptionChosen == 1) {R41Choice = "CYAN" + Environment.NewLine;}
			if (R41OptionChosen == 2) {R41Choice = "ORANGE" + Environment.NewLine;}
			// ROOM 42 - CYAN OR MAGENTA
			string H42Text = "ROOM 42 - Q42 - CYAN OR MAGENTA" + Environment.NewLine;
			string R42Choice = "";
			if (R42OptionChosen == 1) {R42Choice = "CYAN" + Environment.NewLine;}
			if (R42OptionChosen == 2) {R42Choice = "MAGENTA" + Environment.NewLine;}

			// TIME TAKEN
			string headerTimeText = Environment.NewLine + "TIME TAKEN - COLOUR SURVEY" + Environment.NewLine;
			string R1TimeTakenText = "ROOM 1 TIME TAKEN: " + R1TimeTaken + Environment.NewLine;
			string R2TimeTakenText = "ROOM 2 TIME TAKEN: " + R2TimeTaken + Environment.NewLine;
			string R3TimeTakenText = "ROOM 3 TIME TAKEN: " + R3TimeTaken + Environment.NewLine;
			string R4TimeTakenText = "ROOM 4 TIME TAKEN: " + R4TimeTaken + Environment.NewLine;
			string R5TimeTakenText = "ROOM 5 TIME TAKEN: " + R5TimeTaken + Environment.NewLine;
			string R6TimeTakenText = "ROOM 6 TIME TAKEN: " + R6TimeTaken + Environment.NewLine;
			string R7TimeTakenText = "ROOM 7 TIME TAKEN: " + R7TimeTaken + Environment.NewLine;
			string R8TimeTakenText = "ROOM 8 TIME TAKEN: " + R8TimeTaken + Environment.NewLine;
			string R9TimeTakenText = "ROOM 9 TIME TAKEN: " + R9TimeTaken + Environment.NewLine;
			string R10TimeTakenText = "ROOM 10 TIME TAKEN: " + R10TimeTaken + Environment.NewLine;
			string R11TimeTakenText = "ROOM 11 TIME TAKEN: " + R11TimeTaken + Environment.NewLine;
			string R12TimeTakenText = "ROOM 12 TIME TAKEN: " + R12TimeTaken + Environment.NewLine;
			string R13TimeTakenText = "ROOM 13 TIME TAKEN: " + R13TimeTaken + Environment.NewLine;
			string R14TimeTakenText = "ROOM 14 TIME TAKEN: " + R14TimeTaken + Environment.NewLine;
			string R15TimeTakenText = "ROOM 15 TIME TAKEN: " + R15TimeTaken + Environment.NewLine;
			string R16TimeTakenText = "ROOM 16 TIME TAKEN: " + R16TimeTaken + Environment.NewLine;
			string R17TimeTakenText = "ROOM 17 TIME TAKEN: " + R17TimeTaken + Environment.NewLine;
			string R18TimeTakenText = "ROOM 18 TIME TAKEN: " + R18TimeTaken + Environment.NewLine;
			string R19TimeTakenText = "ROOM 19 TIME TAKEN: " + R19TimeTaken + Environment.NewLine;
			string R20TimeTakenText = "ROOM 20 TIME TAKEN: " + R20TimeTaken + Environment.NewLine;
			string R21TimeTakenText = "ROOM 21 TIME TAKEN: " + R21TimeTaken + Environment.NewLine;
			string R22TimeTakenText = "ROOM 22 TIME TAKEN: " + R22TimeTaken + Environment.NewLine;
			string R23TimeTakenText = "ROOM 23 TIME TAKEN: " + R23TimeTaken + Environment.NewLine;
			string R24TimeTakenText = "ROOM 24 TIME TAKEN: " + R24TimeTaken + Environment.NewLine;
			string R25TimeTakenText = "ROOM 25 TIME TAKEN: " + R25TimeTaken + Environment.NewLine;
			string R26TimeTakenText = "ROOM 26 TIME TAKEN: " + R26TimeTaken + Environment.NewLine;
			string R27TimeTakenText = "ROOM 27 TIME TAKEN: " + R27TimeTaken + Environment.NewLine;
			string R28TimeTakenText = "ROOM 28 TIME TAKEN: " + R28TimeTaken + Environment.NewLine;
			string R29TimeTakenText = "ROOM 29 TIME TAKEN: " + R29TimeTaken + Environment.NewLine;
			string R30TimeTakenText = "ROOM 30 TIME TAKEN: " + R30TimeTaken + Environment.NewLine;
			string R31TimeTakenText = "ROOM 31 TIME TAKEN: " + R31TimeTaken + Environment.NewLine;
			string R32TimeTakenText = "ROOM 32 TIME TAKEN: " + R32TimeTaken + Environment.NewLine;
			string R33TimeTakenText = "ROOM 33 TIME TAKEN: " + R33TimeTaken + Environment.NewLine;
			string R34TimeTakenText = "ROOM 34 TIME TAKEN: " + R34TimeTaken + Environment.NewLine;
			string R35TimeTakenText = "ROOM 35 TIME TAKEN: " + R35TimeTaken + Environment.NewLine;
			string R36TimeTakenText = "ROOM 36 TIME TAKEN: " + R36TimeTaken + Environment.NewLine;
			string R37TimeTakenText = "ROOM 37 TIME TAKEN: " + R37TimeTaken + Environment.NewLine;
			string R38TimeTakenText = "ROOM 38 TIME TAKEN: " + R38TimeTaken + Environment.NewLine;
			string R39TimeTakenText = "ROOM 39 TIME TAKEN: " + R39TimeTaken + Environment.NewLine;
			string R40TimeTakenText = "ROOM 40 TIME TAKEN: " + R40TimeTaken + Environment.NewLine;
			string R41TimeTakenText = "ROOM 41 TIME TAKEN: " + R41TimeTaken + Environment.NewLine;
			string R42TimeTakenText = "ROOM 42 TIME TAKEN: " + R42TimeTaken + Environment.NewLine;


			// Colours Chosen
			string headerColoursChosen = Environment.NewLine + "COLOURS CHOSEN" + Environment.NewLine;
			string redColoursChosen = "RED: " + redChosen.ToString () + " / 12" + Environment.NewLine;
			string blueColourChosen = "BLUE: " + blueChosen.ToString () + " / 12" + Environment.NewLine;
			string greenColourChosen = "GREEN: " + greenChosen.ToString () + " / 12" + Environment.NewLine;
			string yellowColourChosen = "YELLOW: " + yellowChosen.ToString () + " / 12" + Environment.NewLine;
			string orangeColourChosen = "ORANGE: " + orangeChosen.ToString () + " / 12" + Environment.NewLine;
			string magentaColourChosen = "MAGENTA: " + magentaChosen.ToString () + " / 12" + Environment.NewLine;
			string cyanColourChosen = "CYAN: " + cyanChosen.ToString () + " / 12" + Environment.NewLine;

			// Colours on Side Chosen
			string headerColoursSideChosen = Environment.NewLine + "COLOURS CHOSEN - RESPECTIVE OF SIDE";
			string redOnLeft = Environment.NewLine + "RED ON LEFT: " + RonLeft.ToString () + " / 6";
			string blueOnLeft = Environment.NewLine + "BLUE ON LEFT: " + BonLeft.ToString () + " / 6";
			string greenOnLeft = Environment.NewLine + "GREEN ON LEFT: " + GonLeft.ToString () + " / 6";
			string yellowOnLeft = Environment.NewLine + "YELLOW ON LEFT: " + YonLeft.ToString () + " / 6";
			string orangeOnLeft = Environment.NewLine + "ORANGE ON LEFT: " + OonLeft.ToString () + " / 6";
			string magentaOnLeft = Environment.NewLine + "MAGENTA ON LEFT: " + MonLeft.ToString () + " / 6";
			string cyanOnLeft = Environment.NewLine + "CYAN ON LEFT: " + ConLeft.ToString () + " / 6";

			string redOnRight = Environment.NewLine + "RED ON RIGHT: " + RonRight.ToString () + " / 6";
			string blueOnRight = Environment.NewLine + "BLUE ON RIGHT: " + BonRight.ToString () + " / 6";
			string greenOnRight = Environment.NewLine + "GREEN ON RIGHT: " + GonRight.ToString () + " / 6";
			string yellowOnRight = Environment.NewLine + "YELLOW ON RIGHT: " + YonRight.ToString () + " / 6";
			string orangeOnRight = Environment.NewLine + "ORANGE ON RIGHT: " + OonRight.ToString () + " / 6";
			string magentaOnRight = Environment.NewLine + "MAGENTA ON RIGHT: " + MonRight.ToString () + " / 6";
			string cyanOnRight = Environment.NewLine + "CYAN ON RIGHT: " + ConRight.ToString () + " / 6";

			// PRINT RESULTS
			string wholeText = mainTitleText + Environment.NewLine + H1Text + R1Choice + Environment.NewLine + H2Text + R2Choice + Environment.NewLine +
			                   H3Text + R3Choice + Environment.NewLine + H4Text + R4Choice + Environment.NewLine + H5Text + R5Choice + Environment.NewLine +
			                   H6Text + R6Choice + Environment.NewLine + H7Text + R7Choice + Environment.NewLine + H8Text + R8Choice + Environment.NewLine +
			                   H9Text + R9Choice + Environment.NewLine + H10Text + R10Choice + Environment.NewLine + H11Text + R11Choice + Environment.NewLine +
			                   H12Text + R12Choice + Environment.NewLine + H13Text + R13Choice + Environment.NewLine + H14Text + R14Choice + Environment.NewLine +
			                   H15Text + R15Choice + Environment.NewLine + H16Text + R16Choice + Environment.NewLine + H17Text + R17Choice + Environment.NewLine +
			                   H18Text + R18Choice + Environment.NewLine + H19Text + R19Choice + Environment.NewLine + H20Text + R20Choice + Environment.NewLine +
			                   H21Text + R21Choice + Environment.NewLine + H22Text + R22Choice + Environment.NewLine + H23Text + R23Choice + Environment.NewLine +
			                   H24Text + R24Choice + Environment.NewLine + H25Text + R25Choice + Environment.NewLine + H26Text + R26Choice + Environment.NewLine +
			                   H27Text + R27Choice + Environment.NewLine + H28Text + R28Choice + Environment.NewLine + H29Text + R29Choice + Environment.NewLine +
			                   H30Text + R30Choice + Environment.NewLine + H31Text + R31Choice + Environment.NewLine + H32Text + R32Choice + Environment.NewLine +
			                   H33Text + R33Choice + Environment.NewLine + H34Text + R34Choice + Environment.NewLine + H35Text + R35Choice + Environment.NewLine +
			                   H36Text + R36Choice + Environment.NewLine + H37Text + R37Choice + Environment.NewLine + H38Text + R38Choice + Environment.NewLine +
			                   H39Text + R39Choice + Environment.NewLine + H40Text + R40Choice + Environment.NewLine + H41Text + R41Choice + Environment.NewLine +
			                   H42Text + R42Choice + Environment.NewLine;

			string timeTakenText = headerTimeText + R1TimeTakenText + R2TimeTakenText + R3TimeTakenText + R4TimeTakenText + R5TimeTakenText + R6TimeTakenText + R7TimeTakenText +
			                       R8TimeTakenText + R9TimeTakenText + R10TimeTakenText + R11TimeTakenText + R12TimeTakenText + R13TimeTakenText + R14TimeTakenText + R15TimeTakenText +
			                       R16TimeTakenText + R17TimeTakenText + R18TimeTakenText + R19TimeTakenText + R20TimeTakenText + R21TimeTakenText + R22TimeTakenText + R23TimeTakenText +
			                       R24TimeTakenText + R25TimeTakenText + R26TimeTakenText + R27TimeTakenText + R28TimeTakenText + R29TimeTakenText + R30TimeTakenText + R31TimeTakenText +
			                       R32TimeTakenText + R33TimeTakenText + R34TimeTakenText + R35TimeTakenText + R36TimeTakenText + R37TimeTakenText + R38TimeTakenText + R39TimeTakenText +
			                       R40TimeTakenText + R41TimeTakenText + R42TimeTakenText;

			string colourText = headerColoursChosen + redColoursChosen + blueColourChosen + greenColourChosen + yellowColourChosen + orangeColourChosen + magentaColourChosen + cyanColourChosen;
			string colourSideText = headerColoursSideChosen + redOnLeft + blueOnLeft + greenOnLeft + yellowOnLeft + orangeOnLeft + magentaOnLeft +
			                        cyanOnLeft + redOnRight + blueOnRight + greenOnRight + yellowOnRight + orangeOnRight + magentaOnRight + cyanOnRight;
			
			File.WriteAllText (path, wholeText + timeTakenText + colourText + colourSideText);
		}
	}
}

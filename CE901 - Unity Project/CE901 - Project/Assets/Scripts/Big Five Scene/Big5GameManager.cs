using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Big5GameManager : MonoBehaviour {

	// Main Room Game Objects
	Renderer mainPortrait, mainPortraitPlacard;
	Renderer mainAChoice, mainBChoice, mainCChoice, mainDChoice, mainEChoice;
	GameObject player;

	// Reference to Option Pad Script
	Big5CollectionScript B5CS_1, B5CS_2, B5CS_3, B5CS_4, B5CS_5;

	// Record Keeping
	public int R1OptionChosen, R2OptionChosen, R3OptionChosen, R4OptionChosen, R5OptionChosen; 
	public int R6OptionChosen, R7OptionChosen, R8OptionChosen, R9OptionChosen, R10OptionChosen; 

	public int R11OptionChosen, R12OptionChosen, R13OptionChosen, R14OptionChosen, R15OptionChosen; 
	public int R16OptionChosen, R17OptionChosen, R18OptionChosen, R19OptionChosen, R20OptionChosen; 

	private string R1TimeTaken, R2TimeTaken, R3TimeTaken, R4TimeTaken, R5TimeTaken, R6TimeTaken, R7TimeTaken, R8TimeTaken, R9TimeTaken, R10TimeTaken;
	private string R11TimeTaken, R12TimeTaken, R13TimeTaken, R14TimeTaken, R15TimeTaken, R16TimeTaken, R17TimeTaken, R18TimeTaken, R19TimeTaken, R20TimeTaken;

	// Game Loop Integer
	public int gamePhase;
	// Placard Headers
	public Texture[] B5PlacardHeaders;
	// Rorschach Images
	public Texture[] B5QuestionArray;
	// Rorschach Answers
	public Texture[] B5AnswerArray;
	// Rorschach Canvas
	private GameObject TutorialText;
	// Timer
	private float B5Timer;
	private string minutes;
	private string seconds;
	private Text B5TimerCanvas;

	private bool R1TimeTakenCheck, R2TimeTakenCheck, R3TimeTakenCheck, R4TimeTakenCheck, R5TimeTakenCheck, R6TimeTakenCheck, R7TimeTakenCheck, R8TimeTakenCheck, R9TimeTakenCheck, R10TimeTakenCheck;
	private bool R11TimeTakenCheck, R12TimeTakenCheck, R13TimeTakenCheck, R14TimeTakenCheck, R15TimeTakenCheck, R16TimeTakenCheck, R17TimeTakenCheck, R18TimeTakenCheck, R19TimeTakenCheck, R20TimeTakenCheck;

	// Use this for initialization
	void Start () {
		mainPortrait = GameObject.Find ("mainPortrait").GetComponent<Renderer> ();
		mainPortraitPlacard = GameObject.Find ("mainPortraitPlacard").GetComponent<Renderer>();

		// Choices
		mainAChoice = GameObject.Find ("Option Choice A Stand Text").GetComponent<Renderer>();
		mainBChoice = GameObject.Find ("Option Choice B Stand Text").GetComponent<Renderer>();
		mainCChoice = GameObject.Find ("Option Choice C Stand Text").GetComponent<Renderer>();
		mainDChoice = GameObject.Find ("Option Choice D Stand Text").GetComponent<Renderer>();
		mainEChoice = GameObject.Find ("Option Choice E Stand Text").GetComponent<Renderer>();

		// Game Loop Start
		gamePhase = 1;

		// Player Ref
		player = GameObject.Find("Player");

		// BIG 5 CS Reference
		B5CS_1 = GameObject.Find("Option Pad 1").GetComponent<Big5CollectionScript>();
		B5CS_2 = GameObject.Find("Option Pad 2").GetComponent<Big5CollectionScript>();
		B5CS_3 = GameObject.Find("Option Pad 3").GetComponent<Big5CollectionScript>();
		B5CS_4 = GameObject.Find("Option Pad 4").GetComponent<Big5CollectionScript>();
		B5CS_5 = GameObject.Find("Option Pad 5").GetComponent<Big5CollectionScript>();

		// Tutorial Text
		TutorialText = GameObject.Find("Tutorial Text");
		//Invoke ("TutorialTextOff", 11f);

		B5TimerCanvas = GameObject.Find ("TimerText").GetComponent<Text> ();

		// Timer
		B5Timer = 0.0f;
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



	}

	void TutorialTextOn(){
		TutorialText.SetActive (true);
	}

	void TutorialTextOff(){
		TutorialText.SetActive (false);
	}

	void EndOfGame(){
		TutorialText.SetActive (true);
		TutorialText.GetComponent<Text> ().text = "Thank you for playing the Big Five Personality Test Scenario \n You are now being moved to the Main Menu";
	}

	void resetTimer(){
		B5Timer = 0f;
		minutes = "";
		seconds = "";
	}

	void startTimer(){
		B5Timer += Time.deltaTime;
	}

	void displayTimer(){
		minutes = Mathf.Floor (B5Timer / 60).ToString("00");
		seconds = Mathf.RoundToInt (B5Timer % 60).ToString("00");
		B5TimerCanvas.text = minutes + ":" + seconds;
	}

	void blankTimer(){
		B5TimerCanvas.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

		startTimer ();
		displayTimer ();
		blankTimer ();

		gameLoop ();

		if (gamePhase > 20) {
			player.transform.position = new Vector3 (0, 15, 0);
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
		switch (gamePhase) {
		case 1:
			// QUESTION 01
			mainPortrait.material.mainTexture = B5QuestionArray [0];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [0];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];
			break;
		case 2:
			// QUESTION 02
			mainPortrait.material.mainTexture = B5QuestionArray [1];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [1];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R1TimeTakenCheck){
				//B5Timer -= 15.0f;
				displayTimer ();
				blankTimer ();
				R1TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R1TimeTakenCheck = true;
			}
			break;
		case 3:
			// QUESTION 03
			mainPortrait.material.mainTexture = B5QuestionArray [2];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [2];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R2TimeTakenCheck){
				R2TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R2TimeTakenCheck = true;
			}

			break;
		case 4:
			// QUESTION 04
			mainPortrait.material.mainTexture = B5QuestionArray [3];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [3];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R3TimeTakenCheck){
				R3TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R3TimeTakenCheck = true;
			}

			break;
		case 5:
			// QUESTION 05
			mainPortrait.material.mainTexture = B5QuestionArray [4];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [4];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R4TimeTakenCheck){
				R4TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R4TimeTakenCheck = true;
			}

			break;
		case 6:
			// QUESTION 06
			mainPortrait.material.mainTexture = B5QuestionArray [5];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [5];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R5TimeTakenCheck){
				R5TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R5TimeTakenCheck = true;
			}

			break;
		case 7:
			// QUESTION 07
			mainPortrait.material.mainTexture = B5QuestionArray [6];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [6];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R6TimeTakenCheck){
				R6TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R6TimeTakenCheck = true;
			}

			break;
		case 8:
			// QUESTION 08
			mainPortrait.material.mainTexture = B5QuestionArray [7];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [7];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R7TimeTakenCheck){
				R7TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R7TimeTakenCheck = true;
			}

			break;
		case 9:
			// QUESTION 09
			mainPortrait.material.mainTexture = B5QuestionArray [8];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [8];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R8TimeTakenCheck){
				R8TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R8TimeTakenCheck = true;
			}

			break;
		case 10:
			// QUESTION 10
			mainPortrait.material.mainTexture = B5QuestionArray [9];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [9];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R9TimeTakenCheck){
				R9TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R9TimeTakenCheck = true;
			}

			break;
		case 11:
			// QUESTION 11
			mainPortrait.material.mainTexture = B5QuestionArray [10];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [10];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R10TimeTakenCheck){
				R10TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R10TimeTakenCheck = true;
			}

			break;
		case 12:
			// QUESTION 12
			mainPortrait.material.mainTexture = B5QuestionArray [11];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [11];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R11TimeTakenCheck){
				R11TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R11TimeTakenCheck = true;
			}

			break;
		case 13:
			// QUESTION 13
			mainPortrait.material.mainTexture = B5QuestionArray [12];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [12];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R12TimeTakenCheck){
				R12TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R12TimeTakenCheck = true;
			}

			break;
		case 14:
			// QUESTION 14
			mainPortrait.material.mainTexture = B5QuestionArray [13];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [13];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R13TimeTakenCheck){
				R13TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R13TimeTakenCheck = true;
			}

			break;
		case 15:
			// QUESTION 15
			mainPortrait.material.mainTexture = B5QuestionArray [14];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [14];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R14TimeTakenCheck){
				R14TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R14TimeTakenCheck = true;
			}

			break;
		case 16:
			// QUESTION 16
			mainPortrait.material.mainTexture = B5QuestionArray [15];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [15];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R15TimeTakenCheck){
				R15TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R15TimeTakenCheck = true;
			}

			break;
		case 17:
			// QUESTION 17
			mainPortrait.material.mainTexture = B5QuestionArray [16];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [16];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R16TimeTakenCheck){
				R16TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R16TimeTakenCheck = true;
			}

			break;
		case 18:
			// QUESTION 18
			mainPortrait.material.mainTexture = B5QuestionArray [17];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [17];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R17TimeTakenCheck){
				R17TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R17TimeTakenCheck = true;
			}

			break;
		case 19:
			// QUESTION 19
			mainPortrait.material.mainTexture = B5QuestionArray [18];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [18];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R18TimeTakenCheck){
				R18TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R18TimeTakenCheck = true;
			}

			break;
		case 20:
			// QUESTION 20
			mainPortrait.material.mainTexture = B5QuestionArray [19];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [19];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R19TimeTakenCheck){
				R19TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R19TimeTakenCheck = true;
			}

			break;
		case 21:
			// QUESTION 20
			mainPortrait.material.mainTexture = B5QuestionArray [20];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [20];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R20TimeTakenCheck){
				R20TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R20TimeTakenCheck = true;
			}

			break;
		} 
	}

	void OnTriggerStay (Collider other)
	{
		if (other.name == "Player") {
			if (Input.GetKeyDown (KeyCode.E)) {
				if (gamePhase <= 21 && (B5CS_1.optionPad1_Chosen || B5CS_2.optionPad2_Chosen || B5CS_3.optionPad3_Chosen || B5CS_4.optionPad4_Chosen || B5CS_5.optionPad5_Chosen)) {
					checkCollection ();
					B5CS_1.resetPads ();
					B5CS_2.resetPads ();
					B5CS_3.resetPads ();
					B5CS_4.resetPads ();
					B5CS_5.resetPads ();
				}
			}
		}
	}
		
	private void backToMainMenu(){
		SceneManager.LoadSceneAsync ("MainMenu");
	}

	void checkCollection()
	{
		if (gamePhase == 1) {
			// Room 1 - Bat - Butterfly - Moth - Scary Face
			if (B5CS_1.optionPad1_Chosen) {
				R1OptionChosen = 1;
				gamePhase = 2;
			} else if (B5CS_2.optionPad2_Chosen) {
				R1OptionChosen = 2;
				gamePhase = 2;
			} else if (B5CS_3.optionPad3_Chosen) {
				R1OptionChosen = 3;
				gamePhase = 2;
			} else if (B5CS_4.optionPad4_Chosen) {
				R1OptionChosen = 4;
				gamePhase = 2;
			} else if (B5CS_5.optionPad5_Chosen) {
				R1OptionChosen = 5;
				gamePhase = 2;
			}
		} else if (gamePhase == 2) {
			if (B5CS_1.optionPad1_Chosen) {
				R2OptionChosen = 1;
				gamePhase = 3;
			} else if (B5CS_2.optionPad2_Chosen) {
				R2OptionChosen = 2;
				gamePhase = 3;
			} else if (B5CS_3.optionPad3_Chosen) {
				R2OptionChosen = 3;
				gamePhase = 3;
			} else if (B5CS_4.optionPad4_Chosen) {
				R2OptionChosen = 4;
				gamePhase = 3;
			} else if (B5CS_5.optionPad5_Chosen) {
				R2OptionChosen = 5;
				gamePhase = 3;
			}
		} else if (gamePhase == 3) {
			if (B5CS_1.optionPad1_Chosen) {
				R3OptionChosen = 1;
				gamePhase = 4;
			} else if (B5CS_2.optionPad2_Chosen) {
				R3OptionChosen = 2;
				gamePhase = 4;
			} else if (B5CS_3.optionPad3_Chosen) {
				R3OptionChosen = 3;
				gamePhase = 4;
			} else if (B5CS_4.optionPad4_Chosen) {
				R3OptionChosen = 4;
				gamePhase = 4;
			} else if (B5CS_5.optionPad5_Chosen) {
				R3OptionChosen = 5;
				gamePhase = 4;
			}
		} else if (gamePhase == 4) {
			if (B5CS_1.optionPad1_Chosen) {
				R4OptionChosen = 1;
				gamePhase = 5;
			} else if (B5CS_2.optionPad2_Chosen) {
				R4OptionChosen = 2;
				gamePhase = 5;
			} else if (B5CS_3.optionPad3_Chosen) {
				R4OptionChosen = 3;
				gamePhase = 5;
			} else if (B5CS_4.optionPad4_Chosen) {
				R4OptionChosen = 4;
				gamePhase = 5;
			} else if (B5CS_5.optionPad5_Chosen) {
				R4OptionChosen = 5;
				gamePhase = 5;
			}
		} else if (gamePhase == 5) {
			if (B5CS_1.optionPad1_Chosen) {
				R5OptionChosen = 1;
				gamePhase = 6;
			} else if (B5CS_2.optionPad2_Chosen) {
				R5OptionChosen = 2;
				gamePhase = 6;
			} else if (B5CS_3.optionPad3_Chosen) {
				R5OptionChosen = 3;
				gamePhase = 6;
			} else if (B5CS_4.optionPad4_Chosen) {
				R5OptionChosen = 4;
				gamePhase = 6;
			} else if (B5CS_5.optionPad5_Chosen) {
				R5OptionChosen = 5;
				gamePhase = 6;
			}
		} else if (gamePhase == 6) {
			if (B5CS_1.optionPad1_Chosen) {
				R6OptionChosen = 1;
				gamePhase = 7;
			} else if (B5CS_2.optionPad2_Chosen) {
				R6OptionChosen = 2;
				gamePhase = 7;
			} else if (B5CS_3.optionPad3_Chosen) {
				R6OptionChosen = 3;
				gamePhase = 7;
			} else if (B5CS_4.optionPad4_Chosen) {
				R6OptionChosen = 4;
				gamePhase = 7;
			} else if (B5CS_5.optionPad5_Chosen) {
				R6OptionChosen = 5;
				gamePhase = 7;
			}
		} else if (gamePhase == 7) {
			if (B5CS_1.optionPad1_Chosen) {
				R7OptionChosen = 1;
				gamePhase = 8;
			} else if (B5CS_2.optionPad2_Chosen) {
				R7OptionChosen = 2;
				gamePhase = 8;
			} else if (B5CS_3.optionPad3_Chosen) {
				R7OptionChosen = 3;
				gamePhase = 8;
			} else if (B5CS_4.optionPad4_Chosen) {
				R7OptionChosen = 4;
				gamePhase = 8;
			} else if (B5CS_5.optionPad5_Chosen) {
				R7OptionChosen = 5;
				gamePhase = 8;
			}
		} else if (gamePhase == 8) {
			if (B5CS_1.optionPad1_Chosen) {
				R8OptionChosen = 1;
				gamePhase = 9;
			} else if (B5CS_2.optionPad2_Chosen) {
				R8OptionChosen = 2;
				gamePhase = 9;
			} else if (B5CS_3.optionPad3_Chosen) {
				R8OptionChosen = 3;
				gamePhase = 9;
			} else if (B5CS_4.optionPad4_Chosen) {
				R8OptionChosen = 4;
				gamePhase = 9;
			} else if (B5CS_5.optionPad5_Chosen) {
				R8OptionChosen = 5;
				gamePhase = 9;
			}
		} else if (gamePhase == 9) {
			if (B5CS_1.optionPad1_Chosen) {
				R9OptionChosen = 1;
				gamePhase = 10;
			} else if (B5CS_2.optionPad2_Chosen) {
				R9OptionChosen = 2;
				gamePhase = 10;
			} else if (B5CS_3.optionPad3_Chosen) {
				R9OptionChosen = 3;
				gamePhase = 10;
			} else if (B5CS_4.optionPad4_Chosen) {
				R9OptionChosen = 4;
				gamePhase = 10;
			} else if (B5CS_5.optionPad5_Chosen) {
				R9OptionChosen = 5;
				gamePhase = 10;
			}
		} else if (gamePhase == 10) {
			if (B5CS_1.optionPad1_Chosen) {
				R10OptionChosen = 1;
				gamePhase = 11;
			} else if (B5CS_2.optionPad2_Chosen) {
				R10OptionChosen = 2;
				gamePhase = 11;
			} else if (B5CS_3.optionPad3_Chosen) {
				R10OptionChosen = 3;
				gamePhase = 11;
			} else if (B5CS_4.optionPad4_Chosen) {
				R10OptionChosen = 4;
				gamePhase = 11;
			} else if (B5CS_5.optionPad5_Chosen) {
				R10OptionChosen = 5;
				gamePhase = 11;
			}
		} else if (gamePhase == 11) {
			if (B5CS_1.optionPad1_Chosen) {
				R11OptionChosen = 1;
				gamePhase = 12;
			} else if (B5CS_2.optionPad2_Chosen) {
				R11OptionChosen = 2;
				gamePhase = 12;
			} else if (B5CS_3.optionPad3_Chosen) {
				R11OptionChosen = 3;
				gamePhase = 12;
			} else if (B5CS_4.optionPad4_Chosen) {
				R11OptionChosen = 4;
				gamePhase = 12;
			} else if (B5CS_5.optionPad5_Chosen) {
				R11OptionChosen = 5;
				gamePhase = 12;
			}
		} else if (gamePhase == 12) {
			if (B5CS_1.optionPad1_Chosen) {
				R12OptionChosen = 1;
				gamePhase = 13;
			} else if (B5CS_2.optionPad2_Chosen) {
				R12OptionChosen = 2;
				gamePhase = 13;
			} else if (B5CS_3.optionPad3_Chosen) {
				R12OptionChosen = 3;
				gamePhase = 13;
			} else if (B5CS_4.optionPad4_Chosen) {
				R12OptionChosen = 4;
				gamePhase = 13;
			} else if (B5CS_5.optionPad5_Chosen) {
				R12OptionChosen = 5;
				gamePhase = 13;
			}
		} else if (gamePhase == 13) {
			if (B5CS_1.optionPad1_Chosen) {
				R13OptionChosen = 1;
				gamePhase = 14;
			} else if (B5CS_2.optionPad2_Chosen) {
				R13OptionChosen = 2;
				gamePhase = 14;
			} else if (B5CS_3.optionPad3_Chosen) {
				R13OptionChosen = 3;
				gamePhase = 14;
			} else if (B5CS_4.optionPad4_Chosen) {
				R13OptionChosen = 4;
				gamePhase = 14;
			} else if (B5CS_5.optionPad5_Chosen) {
				R13OptionChosen = 5;
				gamePhase = 14;
			}
		} else if (gamePhase == 14) {
			if (B5CS_1.optionPad1_Chosen) {
				R14OptionChosen = 1;
				gamePhase = 15;
			} else if (B5CS_2.optionPad2_Chosen) {
				R14OptionChosen = 2;
				gamePhase = 15;
			} else if (B5CS_3.optionPad3_Chosen) {
				R14OptionChosen = 3;
				gamePhase = 15;
			} else if (B5CS_4.optionPad4_Chosen) {
				R14OptionChosen = 4;
				gamePhase = 15;
			} else if (B5CS_5.optionPad5_Chosen) {
				R14OptionChosen = 5;
				gamePhase = 15;
			}
		} else if (gamePhase == 15) {
			if (B5CS_1.optionPad1_Chosen) {
				R15OptionChosen = 1;
				gamePhase = 16;
			} else if (B5CS_2.optionPad2_Chosen) {
				R15OptionChosen = 2;
				gamePhase = 16;
			} else if (B5CS_3.optionPad3_Chosen) {
				R15OptionChosen = 3;
				gamePhase = 16;
			} else if (B5CS_4.optionPad4_Chosen) {
				R15OptionChosen = 4;
				gamePhase = 16;
			} else if (B5CS_5.optionPad5_Chosen) {
				R15OptionChosen = 5;
				gamePhase = 16;
			}
		} else if (gamePhase == 16) {
			if (B5CS_1.optionPad1_Chosen) {
				R16OptionChosen = 1;
				gamePhase = 17;
			} else if (B5CS_2.optionPad2_Chosen) {
				R16OptionChosen = 2;
				gamePhase = 17;
			} else if (B5CS_3.optionPad3_Chosen) {
				R16OptionChosen = 3;
				gamePhase = 17;
			} else if (B5CS_4.optionPad4_Chosen) {
				R16OptionChosen = 4;
				gamePhase = 17;
			} else if (B5CS_5.optionPad5_Chosen) {
				R16OptionChosen = 5;
				gamePhase = 17;
			}
		} else if (gamePhase == 17) {
			if (B5CS_1.optionPad1_Chosen) {
				R17OptionChosen = 1;
				gamePhase = 18;
			} else if (B5CS_2.optionPad2_Chosen) {
				R17OptionChosen = 2;
				gamePhase = 18;
			} else if (B5CS_3.optionPad3_Chosen) {
				R17OptionChosen = 3;
				gamePhase = 18;
			} else if (B5CS_4.optionPad4_Chosen) {
				R17OptionChosen = 4;
				gamePhase = 18;
			} else if (B5CS_5.optionPad5_Chosen) {
				R17OptionChosen = 5;
				gamePhase = 18;
			}
		} else if (gamePhase == 18) {
			if (B5CS_1.optionPad1_Chosen) {
				R18OptionChosen = 1;
				gamePhase = 19;
			} else if (B5CS_2.optionPad2_Chosen) {
				R18OptionChosen = 2;
				gamePhase = 19;
			} else if (B5CS_3.optionPad3_Chosen) {
				R18OptionChosen = 3;
				gamePhase = 19;
			} else if (B5CS_4.optionPad4_Chosen) {
				R18OptionChosen = 4;
				gamePhase = 19;
			} else if (B5CS_5.optionPad5_Chosen) {
				R18OptionChosen = 5;
				gamePhase = 19;
			}
		} else if (gamePhase == 19) {
			if (B5CS_1.optionPad1_Chosen) {
				R19OptionChosen = 1;
				gamePhase = 20;
			} else if (B5CS_2.optionPad2_Chosen) {
				R19OptionChosen = 2;
				gamePhase = 20;
			} else if (B5CS_3.optionPad3_Chosen) {
				R19OptionChosen = 3;
				gamePhase = 20;
			} else if (B5CS_4.optionPad4_Chosen) {
				R19OptionChosen = 4;
				gamePhase = 20;
			} else if (B5CS_5.optionPad5_Chosen) {
				R19OptionChosen = 5;
				gamePhase = 20;
			}
		} else if (gamePhase == 20) {
			if (B5CS_1.optionPad1_Chosen) {
				R20OptionChosen = 1;
				gamePhase = 21;
			} else if (B5CS_2.optionPad2_Chosen) {
				R20OptionChosen = 2;
				gamePhase = 21;
			} else if (B5CS_3.optionPad3_Chosen) {
				R20OptionChosen = 3;
				gamePhase = 21;
			} else if (B5CS_4.optionPad4_Chosen) {
				R20OptionChosen = 4;
				gamePhase = 21;
			} else if (B5CS_5.optionPad5_Chosen) {
				R20OptionChosen = 5;
				gamePhase = 21;
			}
		}
	}
	void writeToFile(){
		string path = Application.dataPath.ToString() + @"\Big Five Personality Survey Results.txt";
		if (File.Exists (path)) {
			File.Delete (path);
			writeToFile ();
		}
		if (!File.Exists (path)) {
			string mainTitleText = "YOUR RESULTS" + Environment.NewLine;

			// ROOM 1 - QUESTION 01
			string header1Text = "ROOM 1 - Q1: I am the life of the party" + Environment.NewLine;
			string R1Choice = "";
			if (R1OptionChosen == 1) {R1Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R1OptionChosen == 2) {R1Choice = "DISAGREE" + Environment.NewLine;}
			if (R1OptionChosen == 3) {R1Choice = "NEUTRAL" + Environment.NewLine;}
			if (R1OptionChosen == 4) {R1Choice = "AGREE" + Environment.NewLine;}
			if (R1OptionChosen == 5) {R1Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 2 - QUESTION 02
			string header2Text = "ROOM 2 - Q2: I feel little concern for others" + Environment.NewLine;
			string R2Choice = "";
			if (R2OptionChosen == 1) {R2Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R2OptionChosen == 2) {R2Choice = "DISAGREE" + Environment.NewLine;}
			if (R2OptionChosen == 3) {R2Choice = "NEUTRAL" + Environment.NewLine;}
			if (R2OptionChosen == 4) {R2Choice = "AGREE" + Environment.NewLine;}
			if (R2OptionChosen == 5) {R2Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 3 - QUESTION 03
			string header3Text = "ROOM 3 - Q3: I am always prepared" + Environment.NewLine;
			string R3Choice = "";
			if (R3OptionChosen == 1) {R3Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R3OptionChosen == 2) {R3Choice = "DISAGREE" + Environment.NewLine;}
			if (R3OptionChosen == 3) {R3Choice = "NEUTRAL" + Environment.NewLine;}
			if (R3OptionChosen == 4) {R3Choice = "AGREE" + Environment.NewLine;}
			if (R3OptionChosen == 5) {R3Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 4 - QUESTION 04
			string header4Text = "ROOM 4 - Q4: I get stressed out easily" + Environment.NewLine;
			string R4Choice = "";
			if (R4OptionChosen == 1) {R4Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R4OptionChosen == 2) {R4Choice = "DISAGREE" + Environment.NewLine;}
			if (R4OptionChosen == 3) {R4Choice = "NEUTRAL" + Environment.NewLine;}
			if (R4OptionChosen == 4) {R4Choice = "AGREE" + Environment.NewLine;}
			if (R4OptionChosen == 5) {R4Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 5 - QUESTION 05
			string header5Text = "ROOM 5 - Q5: I have a rich vocabulary" + Environment.NewLine;
			string R5Choice = "";
			if (R5OptionChosen == 1) {R5Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R5OptionChosen == 2) {R5Choice = "DISAGREE" + Environment.NewLine;}
			if (R5OptionChosen == 3) {R5Choice = "NEUTRAL" + Environment.NewLine;}
			if (R5OptionChosen == 4) {R5Choice = "AGREE" + Environment.NewLine;}
			if (R5OptionChosen == 5) {R5Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 6 - QUESTION 06
			string header6Text = "ROOM 6 - Q6: I don't talk a lot" + Environment.NewLine;
			string R6Choice = "";
			if (R6OptionChosen == 1) {R6Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R6OptionChosen == 2) {R6Choice = "DISAGREE" + Environment.NewLine;}
			if (R6OptionChosen == 3) {R6Choice = "NEUTRAL" + Environment.NewLine;}
			if (R6OptionChosen == 4) {R6Choice = "AGREE" + Environment.NewLine;}
			if (R6OptionChosen == 5) {R6Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 7 - QUESTION 07
			string header7Text = "ROOM 7 - Q7: I am interested in people" + Environment.NewLine;
			string R7Choice = "";
			if (R7OptionChosen == 1) {R7Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R7OptionChosen == 2) {R7Choice = "DISAGREE" + Environment.NewLine;}
			if (R7OptionChosen == 3) {R7Choice = "NEUTRAL" + Environment.NewLine;}
			if (R7OptionChosen == 4) {R7Choice = "AGREE" + Environment.NewLine;}
			if (R7OptionChosen == 5) {R7Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 8 - QUESTION 08
			string header8Text = "ROOM 8 - Q8: I leave my belongings around" + Environment.NewLine;
			string R8Choice = "";
			if (R8OptionChosen == 1) {R8Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R8OptionChosen == 2) {R8Choice = "DISAGREE" + Environment.NewLine;}
			if (R8OptionChosen == 3) {R8Choice = "NEUTRAL" + Environment.NewLine;}
			if (R8OptionChosen == 4) {R8Choice = "AGREE" + Environment.NewLine;}
			if (R8OptionChosen == 5) {R8Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 9 - QUESTION 09
			string header9Text = "ROOM 9 - Q9: I am relaxed most of the time" + Environment.NewLine;
			string R9Choice = "";
			if (R9OptionChosen == 1) {R9Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R9OptionChosen == 2) {R9Choice = "DISAGREE" + Environment.NewLine;}
			if (R9OptionChosen == 3) {R9Choice = "NEUTRAL" + Environment.NewLine;}
			if (R9OptionChosen == 4) {R9Choice = "AGREE" + Environment.NewLine;}
			if (R9OptionChosen == 5) {R9Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 10 - QUESTION 10
			string header10Text = "ROOM 10 - Q10: I have difficulty understanding abstract ideas" + Environment.NewLine;
			string R10Choice = "";
			if (R10OptionChosen == 1) {R10Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R10OptionChosen == 2) {R10Choice = "DISAGREE" + Environment.NewLine;}
			if (R10OptionChosen == 3) {R10Choice = "NEUTRAL" + Environment.NewLine;}
			if (R10OptionChosen == 4) {R10Choice = "AGREE" + Environment.NewLine;}
			if (R10OptionChosen == 5) {R10Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 11 - QUESTION 11
			string header11Text = "ROOM 11 - Q11: I feel comfortable around people" + Environment.NewLine;
			string R11Choice = "";
			if (R11OptionChosen == 1) {R11Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R11OptionChosen == 2) {R11Choice = "DISAGREE" + Environment.NewLine;}
			if (R11OptionChosen == 3) {R11Choice = "NEUTRAL" + Environment.NewLine;}
			if (R11OptionChosen == 4) {R11Choice = "AGREE" + Environment.NewLine;}
			if (R11OptionChosen == 5) {R11Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 12 - QUESTION 12
			string header12Text = "ROOM 12 - Q12: I insult people" + Environment.NewLine;
			string R12Choice = "";
			if (R12OptionChosen == 1) {R12Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R12OptionChosen == 2) {R12Choice = "DISAGREE" + Environment.NewLine;}
			if (R12OptionChosen == 3) {R12Choice = "NEUTRAL" + Environment.NewLine;}
			if (R12OptionChosen == 4) {R12Choice = "AGREE" + Environment.NewLine;}
			if (R12OptionChosen == 5) {R12Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 13 - QUESTION 13
			string header13Text = "ROOM 13 - Q13: I pay attention to details" + Environment.NewLine;
			string R13Choice = "";
			if (R13OptionChosen == 1) {R13Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R13OptionChosen == 2) {R13Choice = "DISAGREE" + Environment.NewLine;}
			if (R13OptionChosen == 3) {R13Choice = "NEUTRAL" + Environment.NewLine;}
			if (R13OptionChosen == 4) {R13Choice = "AGREE" + Environment.NewLine;}
			if (R13OptionChosen == 5) {R13Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 14 - QUESTION 14
			string header14Text = "ROOM 14 - Q14: I worry about things" + Environment.NewLine;
			string R14Choice = "";
			if (R14OptionChosen == 1) {R14Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R14OptionChosen == 2) {R14Choice = "DISAGREE" + Environment.NewLine;}
			if (R14OptionChosen == 3) {R14Choice = "NEUTRAL" + Environment.NewLine;}
			if (R14OptionChosen == 4) {R14Choice = "AGREE" + Environment.NewLine;}
			if (R14OptionChosen == 5) {R14Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 15 - QUESTION 15
			string header15Text = "ROOM 15 - Q15: I have a vivid imagination" + Environment.NewLine;
			string R15Choice = "";
			if (R15OptionChosen == 1) {R15Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R15OptionChosen == 2) {R15Choice = "DISAGREE" + Environment.NewLine;}
			if (R15OptionChosen == 3) {R15Choice = "NEUTRAL" + Environment.NewLine;}
			if (R15OptionChosen == 4) {R15Choice = "AGREE" + Environment.NewLine;}
			if (R15OptionChosen == 5) {R15Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 16 - QUESTION 16
			string header16Text = "ROOM 16 - Q16: I keep in the background" + Environment.NewLine;
			string R16Choice = "";
			if (R16OptionChosen == 1) {R16Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R16OptionChosen == 2) {R16Choice = "DISAGREE" + Environment.NewLine;}
			if (R16OptionChosen == 3) {R16Choice = "NEUTRAL" + Environment.NewLine;}
			if (R16OptionChosen == 4) {R16Choice = "AGREE" + Environment.NewLine;}
			if (R16OptionChosen == 5) {R16Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 17 - QUESTION 17
			string header17Text = "ROOM 17 - Q17: I sympathize with others' feelings" + Environment.NewLine;
			string R17Choice = "";
			if (R17OptionChosen == 1) {R17Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R17OptionChosen == 2) {R17Choice = "DISAGREE" + Environment.NewLine;}
			if (R17OptionChosen == 3) {R17Choice = "NEUTRAL" + Environment.NewLine;}
			if (R17OptionChosen == 4) {R17Choice = "AGREE" + Environment.NewLine;}
			if (R17OptionChosen == 5) {R17Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 18 - QUESTION 18
			string header18Text = "ROOM 18 - Q18: I make a mess of things" + Environment.NewLine;
			string R18Choice = "";
			if (R18OptionChosen == 1) {R18Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R18OptionChosen == 2) {R18Choice = "DISAGREE" + Environment.NewLine;}
			if (R18OptionChosen == 3) {R18Choice = "NEUTRAL" + Environment.NewLine;}
			if (R18OptionChosen == 4) {R18Choice = "AGREE" + Environment.NewLine;}
			if (R18OptionChosen == 5) {R18Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 19 - QUESTION 09
			string header19Text = "ROOM 19 - Q19: I seldom feel blue" + Environment.NewLine;
			string R19Choice = "";
			if (R19OptionChosen == 1) {R19Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R19OptionChosen == 2) {R19Choice = "DISAGREE" + Environment.NewLine;}
			if (R19OptionChosen == 3) {R19Choice = "NEUTRAL" + Environment.NewLine;}
			if (R19OptionChosen == 4) {R19Choice = "AGREE" + Environment.NewLine;}
			if (R19OptionChosen == 5) {R19Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 20 - QUESTION 10
			string header20Text = "ROOM 20 - Q20: I am not interested in abstract ideas" + Environment.NewLine;
			string R20Choice = "";
			if (R20OptionChosen == 1) {R20Choice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (R20OptionChosen == 2) {R20Choice = "DISAGREE" + Environment.NewLine;}
			if (R20OptionChosen == 3) {R20Choice = "NEUTRAL" + Environment.NewLine;}
			if (R20OptionChosen == 4) {R20Choice = "AGREE" + Environment.NewLine;}
			if (R20OptionChosen == 5) {R20Choice = "STRONGLY AGREE" + Environment.NewLine;}

			// TIME TAKEN
			string headerTimeText = Environment.NewLine + "TIME TAKEN - BIG FIVE PERSONALITY TEST" + Environment.NewLine;
			string room1TimeTakenText = "ROOM ONE TIME TAKEN: " + R1TimeTaken + Environment.NewLine;
			string room2TimeTakenText = "ROOM TWO TIME TAKEN: " + R2TimeTaken + Environment.NewLine;
			string room3TimeTakenText = "ROOM THREE TIME TAKEN: " + R3TimeTaken + Environment.NewLine;
			string room4TimeTakenText = "ROOM FOUR TIME TAKEN: " + R4TimeTaken + Environment.NewLine;
			string room5TimeTakenText = "ROOM FIVE TIME TAKEN: " + R5TimeTaken + Environment.NewLine;
			string room6TimeTakenText = "ROOM SIX TIME TAKEN: " + R6TimeTaken + Environment.NewLine;
			string room7TimeTakenText = "ROOM SEVEN TIME TAKEN: " + R7TimeTaken + Environment.NewLine;
			string room8TimeTakenText = "ROOM EIGHT TIME TAKEN: " + R8TimeTaken + Environment.NewLine;
			string room9TimeTakenText = "ROOM NINE TIME TAKEN: " + R9TimeTaken + Environment.NewLine;
			string room10TimeTakenText = "ROOM TEN TIME TAKEN: " + R10TimeTaken + Environment.NewLine;

			string room11TimeTakenText = "ROOM ELEVEN TIME TAKEN: " + R11TimeTaken + Environment.NewLine;
			string room12TimeTakenText = "ROOM TWELVE TIME TAKEN: " + R12TimeTaken + Environment.NewLine;
			string room13TimeTakenText = "ROOM THIRTEEN TIME TAKEN: " + R13TimeTaken + Environment.NewLine;
			string room14TimeTakenText = "ROOM FOURTEEN TIME TAKEN: " + R14TimeTaken + Environment.NewLine;
			string room15TimeTakenText = "ROOM FIFTHTEEN TIME TAKEN: " + R15TimeTaken + Environment.NewLine;
			string room16TimeTakenText = "ROOM SIXTEEN TIME TAKEN: " + R16TimeTaken + Environment.NewLine;
			string room17TimeTakenText = "ROOM SEVENTEEN TIME TAKEN: " + R17TimeTaken + Environment.NewLine;
			string room18TimeTakenText = "ROOM EIGHTEEN TIME TAKEN: " + R18TimeTaken + Environment.NewLine;
			string room19TimeTakenText = "ROOM NINETEEN TIME TAKEN: " + R19TimeTaken + Environment.NewLine;
			string room20TimeTakenText = "ROOM TWENTY TIME TAKEN: " + R20TimeTaken + Environment.NewLine;


			string wholeText = mainTitleText + header1Text + R1Choice + Environment.NewLine + header2Text + R2Choice +
			                   Environment.NewLine + header3Text + R3Choice + Environment.NewLine + header4Text + R4Choice +
			                   Environment.NewLine + header5Text + R5Choice + Environment.NewLine + header6Text + R6Choice +
			                   Environment.NewLine + header7Text + R7Choice + Environment.NewLine + header8Text + R8Choice +
			                   Environment.NewLine + header9Text + R9Choice + Environment.NewLine + header10Text + R10Choice +
			                   Environment.NewLine + header11Text + R11Choice + Environment.NewLine + header12Text + R12Choice +
			                   Environment.NewLine + header13Text + R13Choice + Environment.NewLine + header14Text + R14Choice +
			                   Environment.NewLine + header15Text + R15Choice + Environment.NewLine + header16Text + R16Choice +
			                   Environment.NewLine + header17Text + R17Choice + Environment.NewLine + header18Text + R18Choice +
			                   Environment.NewLine + header19Text + R19Choice + Environment.NewLine + header20Text + R20Choice;

			string timeTakenText = headerTimeText + room1TimeTakenText + room2TimeTakenText + room3TimeTakenText + room4TimeTakenText + room5TimeTakenText +
			                       room6TimeTakenText + room7TimeTakenText + room8TimeTakenText + room9TimeTakenText + room10TimeTakenText + room11TimeTakenText + room12TimeTakenText + room13TimeTakenText + room14TimeTakenText + room15TimeTakenText +
			                       room16TimeTakenText + room17TimeTakenText + room18TimeTakenText + room19TimeTakenText + room20TimeTakenText;

			File.WriteAllText (path, wholeText + timeTakenText);
		}
	}

}

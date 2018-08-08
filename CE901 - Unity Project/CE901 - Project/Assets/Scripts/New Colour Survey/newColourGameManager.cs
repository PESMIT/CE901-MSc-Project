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
	GameObject choiceButton, player;

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
	public int R41OptionChosen, R42OptionChosen;

	private int RonLeft, RonRight, BonLeft, BonRight, GonLeft, GonRight, YonLeft, YonRight, OonLeft, OonRight, MonLeft, MonRight, ConLeft, ConRight;
	private int leftChosen, rightchosen;
	private int redChosen, blueChosen, greenChosen, yellowChosen, orangeChosen, magentaChosen, cyanChosen;

	private string R1TimeTaken, R2TimeTaken, R3TimeTaken, R4TimeTaken, R5TimeTaken, R6TimeTaken, R7TimeTaken, R8TimeTaken, R9TimeTaken, R10TimeTaken;
	private string R11TimeTaken, R12TimeTaken, R13TimeTaken, R14TimeTaken, R15TimeTaken, R16TimeTaken, R17TimeTaken, R18TimeTaken, R19TimeTaken, R20TimeTaken;


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
		// Choice Button Tower
		choiceButton = GameObject.Find("choiceButton");
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
		//blankTimer ();

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
			// Question 21 (Yellow and Blue)
			portraitA.material = NCQuestionArray [3];
			portraitB.material = NCQuestionArray [1];
			mainAChoice.material.mainTexture = NCAnswerArray [3];
			mainBChoice.material.mainTexture = NCAnswerArray [1];

			// Timer
			if (!R20TimeTakenCheck) {
				displayTimer ();
				blankTimer ();
				R20TimeTaken = NCTimerCanvas.text;
				resetTimer ();
				R20TimeTakenCheck = true;
			}
			break;
		}
	}

	void OnTriggerStay(Collider other){
		if (other.name == "Player") {
			if (Input.GetKeyDown (KeyCode.E)) {
				if (gamePhase <= 21 && (NCCS_1.optionPad1_Chosen || NCCS_2.optionPad2_Chosen)) {
					checkCollection ();
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
		}
		// RED OR GREEN
		else if (gamePhase == 2) {
			if (NCCS_1.optionPad1_Chosen) {
				R2OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 3;
			} else if (NCCS_2.optionPad2_Chosen) {
				R2OptionChosen = 2;
				incrementGreen ("right");
				gamePhase = 3;
			}
		}
		// RED OR YELLOW
		else if (gamePhase == 3) {
			if (NCCS_1.optionPad1_Chosen) {
				R3OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 4;
			} else if (NCCS_2.optionPad2_Chosen) {
				R3OptionChosen = 2;
				incrementYellow ("right");
				gamePhase = 4;
			}
		}
		// RED OR ORANGE
		else if (gamePhase == 4) {
			if (NCCS_1.optionPad1_Chosen) {
				R4OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 5;
			} else if (NCCS_2.optionPad2_Chosen) {
				R4OptionChosen = 2;
				incrementOrange ("right");
				gamePhase = 5;
			}
		} 
		// RED OR MAGENTA
		else if (gamePhase == 5) {
			if (NCCS_1.optionPad1_Chosen) {
				R5OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 6;
			} else if (NCCS_2.optionPad2_Chosen) {
				R5OptionChosen = 2;
				incrementMagenta ("right");
				gamePhase = 6;
			}
		} 
		// RED OR CYAN
		else if (gamePhase == 6) {
			if (NCCS_1.optionPad1_Chosen) {
				R6OptionChosen = 1;
				incrementRed ("left");
				gamePhase = 7;
			} else if (NCCS_2.optionPad2_Chosen) {
				R6OptionChosen = 2;
				incrementCyan ("right");
				gamePhase = 7;
			}
		} 
		// BLUE OR RED
		else if (gamePhase == 7) {
			if (NCCS_1.optionPad1_Chosen) {
				R7OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 8;
			} else if (NCCS_2.optionPad2_Chosen) {
				R7OptionChosen = 2;
				incrementRed ("right");
				gamePhase = 8;
			}
		}
		// BLUE OR GREEN
		else if (gamePhase == 8) {
			if (NCCS_1.optionPad1_Chosen) {
				R8OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 9;
			} else if (NCCS_2.optionPad2_Chosen) {
				R8OptionChosen = 2;
				incrementGreen ("right");
				gamePhase = 9;
			}
		} 
		// BLUE OR YELLOW
		else if (gamePhase == 9) {
			if (NCCS_1.optionPad1_Chosen) {
				R9OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 10;
			} else if (NCCS_2.optionPad2_Chosen) {
				R9OptionChosen = 2;
				incrementYellow ("right");
				gamePhase = 10;
			}
		} 
		// BLUE OR ORANGE
		else if (gamePhase == 10) {
			if (NCCS_1.optionPad1_Chosen) {
				R10OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 11;
			} else if (NCCS_2.optionPad2_Chosen) {
				R10OptionChosen = 2;
				incrementOrange ("right");
				gamePhase = 11;
			}
		} 
		// BLUE OR MAGENTA
		else if (gamePhase == 11) {
			if (NCCS_1.optionPad1_Chosen) {
				R11OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 12;
			} else if (NCCS_2.optionPad2_Chosen) {
				R11OptionChosen = 2;
				incrementMagenta ("right");
				gamePhase = 12;
			}
		} 
		// BLUE OR CYAN
		else if (gamePhase == 12) {
			if (NCCS_1.optionPad1_Chosen) {
				R12OptionChosen = 1;
				incrementBlue ("left");
				gamePhase = 13;
			} else if (NCCS_2.optionPad2_Chosen) {
				R2OptionChosen = 2;
				incrementCyan ("right");
				gamePhase = 13;
			}
		} 
		// GREEN OR RED
		else if (gamePhase == 13) {
			if (NCCS_1.optionPad1_Chosen) {
				R13OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 14;
			} else if (NCCS_2.optionPad2_Chosen) {
				R13OptionChosen = 2;
				incrementRed ("right");
				gamePhase = 14;
			}
		} 
		// GREEN OR BLUE
		else if (gamePhase == 14) {
			if (NCCS_1.optionPad1_Chosen) {
				R14OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 15;
			} else if (NCCS_2.optionPad2_Chosen) {
				R14OptionChosen = 2;
				incrementBlue ("right");
				gamePhase = 15;
			}
		} 
		// GREEN OR YELLOW
		else if (gamePhase == 15) {
			if (NCCS_1.optionPad1_Chosen) {
				R15OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 16;
			} else if (NCCS_2.optionPad2_Chosen) {
				R15OptionChosen = 2;
				incrementYellow ("right");
				gamePhase = 16;
			}
		} 
		// GREEN OR ORANGE
		else if (gamePhase == 16) {
			if (NCCS_1.optionPad1_Chosen) {
				R16OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 17;
			} else if (NCCS_2.optionPad2_Chosen) {
				R16OptionChosen = 2;
				incrementOrange ("right");
				gamePhase = 17;
			}
		} 
		// GREEN OR MAGENTA
		else if (gamePhase == 17) {
			if (NCCS_1.optionPad1_Chosen) {
				R17OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 18;
			} else if (NCCS_2.optionPad2_Chosen) {
				R17OptionChosen = 2;
				incrementMagenta ("right");
				gamePhase = 18;
			}
		} 
		// GREEN OR CYAN
		else if (gamePhase == 18) {
			if (NCCS_1.optionPad1_Chosen) {
				R18OptionChosen = 1;
				incrementGreen ("left");
				gamePhase = 19;
			} else if (NCCS_2.optionPad2_Chosen) {
				R18OptionChosen = 2;
				incrementCyan ("right");
				gamePhase = 19;
			}
		} 
		// YELLOW OR RED
		else if (gamePhase == 19) {
			if (NCCS_1.optionPad1_Chosen) {
				R19OptionChosen = 1;
				incrementYellow ("left");
				gamePhase = 20;
			} else if (NCCS_2.optionPad2_Chosen) {
				R19OptionChosen = 2;
				incrementRed ("right");
				gamePhase = 20;
			}
		} 
		// YELLOW OR BLUE
		else if (gamePhase == 20) {
			if (NCCS_1.optionPad1_Chosen) {
				R20OptionChosen = 1;
				incrementYellow ("left");
				gamePhase = 21;
			} else if (NCCS_2.optionPad2_Chosen) {
				R20OptionChosen = 2;
				incrementBlue ("right");
				gamePhase = 21;
			}
		} else if (gamePhase == 21) {
			if (NCCS_1.optionPad1_Chosen) {
				R21OptionChosen = 1;
				gamePhase = 22;
			} else if (NCCS_2.optionPad2_Chosen) {
				R21OptionChosen = 2;
				gamePhase = 22;
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
			                   H18Text + R18Choice + Environment.NewLine + H19Text + R19Choice + Environment.NewLine + H20Text + R20Choice + Environment.NewLine;

			string timeTakenText = headerTimeText + R1TimeTakenText + R2TimeTakenText + R3TimeTakenText + R4TimeTakenText + R5TimeTakenText + R6TimeTakenText + R7TimeTakenText +
			                       R8TimeTakenText + R9TimeTakenText + R10TimeTakenText + R11TimeTakenText + R12TimeTakenText + R13TimeTakenText + R14TimeTakenText + R15TimeTakenText +
			                       R16TimeTakenText + R17TimeTakenText + R18TimeTakenText + R19TimeTakenText + R20TimeTakenText;

			string colourText = headerColoursChosen + redColoursChosen + blueColourChosen + greenColourChosen + yellowColourChosen + orangeColourChosen + magentaColourChosen + cyanColourChosen;
			string colourSideText = headerColoursSideChosen + redOnLeft + blueOnLeft + greenOnLeft + yellowOnLeft + orangeOnLeft + magentaOnLeft +
			                        cyanOnLeft + redOnRight + blueOnRight + greenOnRight + yellowOnRight + orangeOnRight + magentaOnRight + cyanOnRight;
			
			File.WriteAllText (path, wholeText + timeTakenText + colourText + colourSideText);
		}
	}
}

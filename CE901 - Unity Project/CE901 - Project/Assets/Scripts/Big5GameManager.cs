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
	GameObject choiceButton;
	GameObject player;

	// Reference to Option Pad Script
	Big5CollectionScript B5CS_1, B5CS_2, B5CS_3, B5CS_4, B5CS_5;

	// Record Keeping
	public int room1OptionChosen, room2OptionChosen, room3OptionChosen, room4OptionChosen, room5OptionChosen; 
	public int room6OptionChosen, room7OptionChosen, room8OptionChosen, room9OptionChosen, room10OptionChosen; 
	private string room1TimeTaken, room2TimeTaken, room3TimeTaken, room4TimeTaken, room5TimeTaken, room6TimeTaken, room7TimeTaken, room8TimeTaken, room9TimeTaken, room10TimeTaken;

	// Game Loop Integer
	public int gamePhase;
	// Placard Headers
	public Texture[] B5PlacardHeaders;
	// Rorschach Images
	public Texture[] B5ImageArray;
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

		// Choice Button Tower
		choiceButton = GameObject.Find("choiceButton");

		// Game Loop Start
		gamePhase = 1;

		// Player Ref
		player = GameObject.Find("Player");

		// rorCS Reference
		B5CS_1 = GameObject.Find("Option Pad 1").GetComponent<Big5CollectionScript>();
		B5CS_2 = GameObject.Find("Option Pad 2").GetComponent<Big5CollectionScript>();
		B5CS_3 = GameObject.Find("Option Pad 3").GetComponent<Big5CollectionScript>();
		B5CS_4 = GameObject.Find("Option Pad 4").GetComponent<Big5CollectionScript>();

		// Tutorial Text
		TutorialText = GameObject.Find("Tutorial Text");
		//Invoke ("TutorialTextOff", 11f);

		B5TimerCanvas = GameObject.Find ("TimerText").GetComponent<Text> ();

		// Timer
		B5Timer = 0.0f;
		room1TimeTaken = "";
		room2TimeTaken = "";
		room3TimeTaken = "";
		room4TimeTaken = "";
		room5TimeTaken = "";
		room6TimeTaken = "";
		room7TimeTaken = "";
		room8TimeTaken = "";
		room9TimeTaken = "";
		room10TimeTaken = "";

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

		if (gamePhase > 10) {
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
			// Q1
			mainPortrait.material.mainTexture = B5ImageArray [1];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [1];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];
			break;
		case 2:
			// Animals - Beard - Humans - Laughing
			mainPortrait.material.mainTexture = B5ImageArray [2];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [2];
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
				room1TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R1TimeTakenCheck = true;
			}
			break;
		case 3:
			// Birds - Bones - Humans - Instruments
			mainPortrait.material.mainTexture = B5ImageArray [3];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [3];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R2TimeTakenCheck){
				room2TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R2TimeTakenCheck = true;
			}

			break;
		case 4:
			// Animal Hide - Bat - Cocoon - Flower
			mainPortrait.material.mainTexture = B5ImageArray [4];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [4];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R3TimeTakenCheck){
				room3TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R3TimeTakenCheck = true;
			}

			break;
		case 5:
			// Bat - Butterfly - Moth - Sheep
			mainPortrait.material.mainTexture = B5ImageArray [5];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [5];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R4TimeTakenCheck){
				room4TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R4TimeTakenCheck = true;
			}

			break;
		case 6:
			// Animal Hide - Instruments - Staff - Tower
			mainPortrait.material.mainTexture = B5ImageArray [6];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [6];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R5TimeTakenCheck){
				room5TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R5TimeTakenCheck = true;
			}

			break;
		case 7:
			// Arrow - Dish or Bowl - Human Faces - Vase
			mainPortrait.material.mainTexture = B5ImageArray [7];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [7];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R6TimeTakenCheck){
				room6TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R6TimeTakenCheck = true;
			}

			break;
		case 8:
			// Aniamls - Face - Organ - Trophy 
			mainPortrait.material.mainTexture = B5ImageArray [8];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [8];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R7TimeTakenCheck){
				room7TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R7TimeTakenCheck = true;
			}

			break;
		case 9:
			// Flower - Giraffe - Human - Tower
			mainPortrait.material.mainTexture = B5ImageArray [9];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [9];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R8TimeTakenCheck){
				room8TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R8TimeTakenCheck = true;
			}

			break;
		case 10:
			// Banana - Crab - Lobster - Spider
			mainPortrait.material.mainTexture = B5ImageArray [10];
			mainPortraitPlacard.material.mainTexture = B5PlacardHeaders [10];

			mainAChoice.material.mainTexture = B5AnswerArray [1];
			mainBChoice.material.mainTexture = B5AnswerArray [2];
			mainCChoice.material.mainTexture = B5AnswerArray [3];
			mainDChoice.material.mainTexture = B5AnswerArray [4];
			mainEChoice.material.mainTexture = B5AnswerArray [5];

			// Timer
			if(!R9TimeTakenCheck){
				room9TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R9TimeTakenCheck = true;
			}

			break;
		case 11:
			// Timer
			if(!R10TimeTakenCheck){
				room10TimeTaken = B5TimerCanvas.text;
				resetTimer ();
				R10TimeTakenCheck = true;
			}

			break;
		}
	}

	void OnTriggerStay (Collider other)
	{
		if (other.name == "Player") {
			if (Input.GetKeyDown (KeyCode.E)) {
				if (gamePhase <= 10 && (B5CS_1.optionPad1_Chosen || B5CS_2.optionPad2_Chosen || B5CS_3.optionPad3_Chosen || B5CS_4.optionPad4_Chosen)) {
					checkCollection ();
					B5CS_1.resetPads ();
					B5CS_2.resetPads ();
					B5CS_3.resetPads ();
					B5CS_4.resetPads ();
				}
			}
		}
	}

	void writeToFile(){
		string path = Application.dataPath.ToString() + @"\Big Five Personality Survey Results.txt";
		if (!File.Exists (path)) {
			string mainTitleText = "YOUR RESULTS" + Environment.NewLine;

			// ROOM 1
			string header1Text = "ROOM 1 - Question 1: I am the life of the party" + Environment.NewLine;
			string roomOneChoice = "";
			if (room1OptionChosen == 1) {roomOneChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room1OptionChosen == 2) {roomOneChoice = "DISAGREE" + Environment.NewLine;}
			if (room1OptionChosen == 3) {roomOneChoice = "NEUTRAL" + Environment.NewLine;}
			if (room1OptionChosen == 4) {roomOneChoice = "AGREE" + Environment.NewLine;}
			if (room1OptionChosen == 5) {roomOneChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 2
			string header2Text = "ROOM 2 - Question 2: I feel little concern for others" + Environment.NewLine;
			string roomTwoChoice = "";
			if (room2OptionChosen == 1) {roomTwoChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room2OptionChosen == 2) {roomTwoChoice = "DISAGREE" + Environment.NewLine;}
			if (room2OptionChosen == 3) {roomTwoChoice = "NEUTRAL" + Environment.NewLine;}
			if (room2OptionChosen == 4) {roomTwoChoice = "AGREE" + Environment.NewLine;}
			if (room2OptionChosen == 5) {roomTwoChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 3
			string header3Text = "ROOM 3 - Question 3: I am always prepared" + Environment.NewLine;
			string roomThreeChoice = "";
			if (room3OptionChosen == 1) {roomThreeChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room3OptionChosen == 2) {roomThreeChoice = "DISAGREE" + Environment.NewLine;}
			if (room3OptionChosen == 3) {roomThreeChoice = "NEUTRAL" + Environment.NewLine;}
			if (room3OptionChosen == 4) {roomThreeChoice = "AGREE" + Environment.NewLine;}
			if (room3OptionChosen == 5) {roomThreeChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 4 - ANIMAL HIDE - BAT - COCOON - FLOWER
			string header4Text = "ROOM 4 - Question 4: I get stressed out easily" + Environment.NewLine;
			string roomFourChoice = "";
			if (room4OptionChosen == 1) {roomFourChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room4OptionChosen == 2) {roomFourChoice = "DISAGREE" + Environment.NewLine;}
			if (room4OptionChosen == 3) {roomFourChoice = "NEUTRAL" + Environment.NewLine;}
			if (room4OptionChosen == 4) {roomFourChoice = "AGREE" + Environment.NewLine;}
			if (room4OptionChosen == 5) {roomFourChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 5 - BAT - BUTTERFLY - MOTH - SHEEP
			string header5Text = "ROOM 5 - Question 5: I have a rich vocabulary" + Environment.NewLine;
			string roomFiveChoice = "";
			if (room5OptionChosen == 1) {roomFiveChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room5OptionChosen == 2) {roomFiveChoice = "DISAGREE" + Environment.NewLine;}
			if (room5OptionChosen == 3) {roomFiveChoice = "NEUTRAL" + Environment.NewLine;}
			if (room5OptionChosen == 4) {roomFiveChoice = "AGREE" + Environment.NewLine;}
			if (room5OptionChosen == 5) {roomFiveChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 6 - ANIMAL HIDE - INSTRUMENTS - STAFF - TOWER
			string header6Text = "ROOM 6 - Question 6: I don't talk a lot" + Environment.NewLine;
			string roomSixChoice = "";
			if (room6OptionChosen == 1) {roomSixChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room6OptionChosen == 2) {roomSixChoice = "DISAGREE" + Environment.NewLine;}
			if (room6OptionChosen == 3) {roomSixChoice = "NEUTRAL" + Environment.NewLine;}
			if (room6OptionChosen == 4) {roomSixChoice = "AGREE" + Environment.NewLine;}
			if (room6OptionChosen == 5) {roomSixChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 7 - BIRDS - BONES - HUMANS - INSTRUMENTS
			string header7Text = "ROOM 7 - Question 7: I am interested in people" + Environment.NewLine;
			string roomSevenChoice = "";
			if (room7OptionChosen == 1) {roomSevenChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room7OptionChosen == 2) {roomSevenChoice = "DISAGREE" + Environment.NewLine;}
			if (room7OptionChosen == 3) {roomSevenChoice = "NEUTRAL" + Environment.NewLine;}
			if (room7OptionChosen == 4) {roomSevenChoice = "AGREE" + Environment.NewLine;}
			if (room7OptionChosen == 5) {roomSevenChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 8 - ANIMAL HIDE - BAT - COCOON - FLOWER
			string header8Text = "ROOM 8 - Question 8: I leave my belongings around" + Environment.NewLine;
			string roomEightChoice = "";
			if (room8OptionChosen == 1) {roomEightChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room8OptionChosen == 2) {roomEightChoice = "DISAGREE" + Environment.NewLine;}
			if (room8OptionChosen == 3) {roomEightChoice = "NEUTRAL" + Environment.NewLine;}
			if (room8OptionChosen == 4) {roomEightChoice = "AGREE" + Environment.NewLine;}
			if (room8OptionChosen == 5) {roomEightChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 9 - FLOWER - GIRAFFE - HUMAN - TOWER
			string header9Text = "ROOM 9 - I am relaxed most of the time" + Environment.NewLine;
			string roomNineChoice = "";
			if (room9OptionChosen == 1) {roomNineChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room9OptionChosen == 2) {roomNineChoice = "DISAGREE" + Environment.NewLine;}
			if (room9OptionChosen == 3) {roomNineChoice = "NEUTRAL" + Environment.NewLine;}
			if (room9OptionChosen == 4) {roomNineChoice = "AGREE" + Environment.NewLine;}
			if (room9OptionChosen == 5) {roomNineChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// ROOM 10 - BANANA - CRAB - LOBSTER - SPIDER
			string header10Text = "ROOM 10 - I have difficulty understanding abstract ideas" + Environment.NewLine;
			string roomTenChoice = "";
			if (room10OptionChosen == 1) {roomTenChoice = "STRONGLY DISAGREE" + Environment.NewLine;}
			if (room10OptionChosen == 2) {roomTenChoice = "DISAGREE" + Environment.NewLine;}
			if (room10OptionChosen == 3) {roomTenChoice = "NEUTRAL" + Environment.NewLine;}
			if (room10OptionChosen == 4) {roomTenChoice = "AGREE" + Environment.NewLine;}
			if (room10OptionChosen == 5) {roomTenChoice = "STRONGLY AGREE" + Environment.NewLine;}

			// TIME TAKEN
			string headerTimeText = Environment.NewLine + "TIME TAKEN - BIG FIVE PERSONALITY TEST" + Environment.NewLine;
			string room1TimeTakenText = "ROOM ONE TIME TAKEN: " + room1TimeTaken + Environment.NewLine;
			string room2TimeTakenText = "ROOM TWO TIME TAKEN: " + room2TimeTaken + Environment.NewLine;
			string room3TimeTakenText = "ROOM THREE TIME TAKEN: " + room3TimeTaken + Environment.NewLine;
			string room4TimeTakenText = "ROOM FOUR TIME TAKEN: " + room4TimeTaken + Environment.NewLine;
			string room5TimeTakenText = "ROOM FIVE TIME TAKEN: " + room5TimeTaken + Environment.NewLine;
			string room6TimeTakenText = "ROOM SIX TIME TAKEN: " + room6TimeTaken + Environment.NewLine;
			string room7TimeTakenText = "ROOM SEVEN TIME TAKEN: " + room7TimeTaken + Environment.NewLine;
			string room8TimeTakenText = "ROOM EIGHT TIME TAKEN: " + room8TimeTaken + Environment.NewLine;
			string room9TimeTakenText = "ROOM NINE TIME TAKEN: " + room9TimeTaken + Environment.NewLine;
			string room10TimeTakenText = "ROOM TEN TIME TAKEN: " + room10TimeTaken + Environment.NewLine;


			string wholeText = header1Text + roomOneChoice + Environment.NewLine + header2Text + roomTwoChoice +
				Environment.NewLine + header3Text + roomThreeChoice + Environment.NewLine + header4Text + roomFourChoice +
				Environment.NewLine + header5Text + roomFiveChoice + Environment.NewLine + header6Text + roomSixChoice +
				Environment.NewLine + header7Text + roomSevenChoice + Environment.NewLine + header8Text + roomEightChoice +
				Environment.NewLine + header9Text + roomNineChoice + Environment.NewLine + header10Text + roomTenChoice;

			string timeTakenText = headerTimeText + room1TimeTakenText + room2TimeTakenText + room3TimeTakenText + room4TimeTakenText + room5TimeTakenText +
				room6TimeTakenText + room7TimeTakenText + room8TimeTakenText + room9TimeTakenText + room10TimeTakenText;

			File.WriteAllText (path, wholeText + timeTakenText);
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
				room1OptionChosen = 1;
				gamePhase = 2;
			} else if (B5CS_2.optionPad2_Chosen) {
				room1OptionChosen = 2;
				gamePhase = 2;
			} else if (B5CS_3.optionPad3_Chosen) {
				room1OptionChosen = 3;
				gamePhase = 2;
			} else if (B5CS_4.optionPad4_Chosen) {
				room1OptionChosen = 4;
				gamePhase = 2;
			}
		} else if (gamePhase == 2) {
			if (B5CS_1.optionPad1_Chosen) {
				room2OptionChosen = 1;
				gamePhase = 3;
			} else if (B5CS_2.optionPad2_Chosen) {
				room2OptionChosen = 2;
				gamePhase = 3;
			} else if (B5CS_3.optionPad3_Chosen) {
				room2OptionChosen = 3;
				gamePhase = 3;
			} else if (B5CS_4.optionPad4_Chosen) {
				room2OptionChosen = 4;
				gamePhase = 3;
			}
		} else if (gamePhase == 3) {
			if (B5CS_1.optionPad1_Chosen) {
				room3OptionChosen = 1;
				gamePhase = 4;
			} else if (B5CS_2.optionPad2_Chosen) {
				room3OptionChosen = 2;
				gamePhase = 4;
			} else if (B5CS_3.optionPad3_Chosen) {
				room3OptionChosen = 3;
				gamePhase = 4;
			} else if (B5CS_4.optionPad4_Chosen) {
				room3OptionChosen = 4;
				gamePhase = 4;
			}
		} else if (gamePhase == 4) {
			if (B5CS_1.optionPad1_Chosen) {
				room4OptionChosen = 1;
				gamePhase = 5;
			} else if (B5CS_2.optionPad2_Chosen) {
				room4OptionChosen = 2;
				gamePhase = 5;
			} else if (B5CS_3.optionPad3_Chosen) {
				room4OptionChosen = 3;
				gamePhase = 5;
			} else if (B5CS_4.optionPad4_Chosen) {
				room4OptionChosen = 4;
				gamePhase = 5;
			} 
		} else if (gamePhase == 5) {
			if (B5CS_1.optionPad1_Chosen) {
				room5OptionChosen = 1;
				gamePhase = 6;
			} else if (B5CS_2.optionPad2_Chosen) {
				room5OptionChosen = 2;
				gamePhase = 6;
			} else if (B5CS_3.optionPad3_Chosen) {
				room5OptionChosen = 3;
				gamePhase = 6;
			} else if (B5CS_4.optionPad4_Chosen) {
				room5OptionChosen = 4;
				gamePhase = 6;
			} 
		} else if (gamePhase == 6) {
			if (B5CS_1.optionPad1_Chosen) {
				room6OptionChosen = 1;
				gamePhase = 7;
			} else if (B5CS_2.optionPad2_Chosen) {
				room6OptionChosen = 2;
				gamePhase = 7;
			} else if (B5CS_3.optionPad3_Chosen) {
				room6OptionChosen = 3;
				gamePhase = 7;
			} else if (B5CS_4.optionPad4_Chosen) {
				room6OptionChosen = 4;
				gamePhase = 7;
			}
		} else if (gamePhase == 7) {
			if (B5CS_1.optionPad1_Chosen) {
				room7OptionChosen = 1;
				gamePhase = 8;
			} else if (B5CS_2.optionPad2_Chosen) {
				room7OptionChosen = 2;
				gamePhase = 8;
			} else if (B5CS_3.optionPad3_Chosen) {
				room7OptionChosen = 3;
				gamePhase = 8;
			} else if (B5CS_4.optionPad4_Chosen) {
				room7OptionChosen = 4;
				gamePhase = 8;
			}
		} else if (gamePhase == 8) {
			if (B5CS_1.optionPad1_Chosen) {
				room8OptionChosen = 1;
				gamePhase = 9;
			} else if (B5CS_2.optionPad2_Chosen) {
				room8OptionChosen = 2;
				gamePhase = 9;
			} else if (B5CS_3.optionPad3_Chosen) {
				room8OptionChosen = 3;
				gamePhase = 9;
			} else if (B5CS_4.optionPad4_Chosen) {
				room8OptionChosen = 4;
				gamePhase = 9;
			}
		} else if (gamePhase == 9) {
			if (B5CS_1.optionPad1_Chosen) {
				room9OptionChosen = 1;
				gamePhase = 10;
			} else if (B5CS_2.optionPad2_Chosen) {
				room9OptionChosen = 2;
				gamePhase = 10;
			} else if (B5CS_3.optionPad3_Chosen) {
				room9OptionChosen = 3;
				gamePhase = 10;
			} else if (B5CS_4.optionPad4_Chosen) {
				room9OptionChosen = 4;
				gamePhase = 10;
			}
		} else if (gamePhase == 10) {
			if (B5CS_1.optionPad1_Chosen) {
				room10OptionChosen = 1;
				gamePhase = 11;
			} else if (B5CS_2.optionPad2_Chosen) {
				room10OptionChosen = 2;
				gamePhase = 11;
			} else if (B5CS_3.optionPad3_Chosen) {
				room10OptionChosen = 3;
				gamePhase = 11;
			} else if (B5CS_4.optionPad4_Chosen) {
				room10OptionChosen = 4;
				gamePhase = 11;
			}
		}
	}
}

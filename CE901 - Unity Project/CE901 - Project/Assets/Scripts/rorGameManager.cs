using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class rorGameManager : MonoBehaviour {

	// Main Room Game Objects
	Renderer mainPortrait, mainPortraitPlacard;
	Renderer mainAChoice, mainBChoice, mainCChoice, mainDChoice;
	GameObject choiceButton;
	GameObject player;

	// Reference to Option Pad Script
	rorCollectionScript rorCS_1, rorCS_2, rorCS_3, rorCS_4;

	// Record Keeping
	public int room1OptionChosen, room2OptionChosen, room3OptionChosen, room4OptionChosen, room5OptionChosen; 
	public int room6OptionChosen, room7OptionChosen, room8OptionChosen, room9OptionChosen, room10OptionChosen; 

	// Game Loop Integer
	public int gamePhase;
	// Placard Headers
	public Texture[] rorPlacardHeaders;
	// Rorschach Images
	public Texture[] rorImageArray;
	// Rorschach Answers
	public Texture[] rorAnswerArray;

	private GameObject TutorialText;




	// Use this for initialization
	void Start () {
		mainPortrait = GameObject.Find ("mainPortrait").GetComponent<Renderer> ();
		mainPortraitPlacard = GameObject.Find ("mainPortraitPlacard").GetComponent<Renderer>();

		// Choices
		mainAChoice = GameObject.Find ("Option Choice A Stand Text").GetComponent<Renderer>();
		mainBChoice = GameObject.Find ("Option Choice B Stand Text").GetComponent<Renderer>();
		mainCChoice = GameObject.Find ("Option Choice C Stand Text").GetComponent<Renderer>();
		mainDChoice = GameObject.Find ("Option Choice D Stand Text").GetComponent<Renderer>();

		// Choice Button Tower
		choiceButton = GameObject.Find("choiceButton");

		// Game Loop Start
		gamePhase = 1;

		// Player Ref
		player = GameObject.Find("Player");

		// rorCS Reference
		rorCS_1 = GameObject.Find("Option Pad 1").GetComponent<rorCollectionScript>();
		rorCS_2 = GameObject.Find("Option Pad 2").GetComponent<rorCollectionScript>();
		rorCS_3 = GameObject.Find("Option Pad 3").GetComponent<rorCollectionScript>();
		rorCS_4 = GameObject.Find("Option Pad 4").GetComponent<rorCollectionScript>();

		// Tutorial Text
		TutorialText = GameObject.Find("Tutorial Text");
		Invoke ("TutorialTextOff", 11f);
	}

	void TutorialTextOn(){
		TutorialText.SetActive (true);
	}

	void TutorialTextOff(){
		TutorialText.SetActive (false);
	}

	void EndOfGame(){
		TutorialText.SetActive (true);
		TutorialText.GetComponent<Text> ().text = "Thank you for playing the Rorschach Test Scenario \n You are now being moved to the Main Menu";
	}
	
	// Update is called once per frame
	void Update () {
		gameLoop ();
		if (gamePhase > 10) {
			player.transform.position = new Vector3 (0, 15, 0);
			writeToFile ();
			EndOfGame ();
			Invoke ("backToMainMenu", 5);
		}
		if (Input.GetKeyDown (KeyCode.T)) {
			TutorialTextOn ();
			Invoke ("TutorialTextOff", 10);
		}
	}

	void gameLoop(){
		switch (gamePhase) {
		case 1:
			// Bat - Butterfly - Moth - Scary Face
			mainPortrait.material.mainTexture = rorImageArray [1];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [1];

			mainAChoice.material.mainTexture = rorAnswerArray [1];
			mainBChoice.material.mainTexture = rorAnswerArray [2];
			mainCChoice.material.mainTexture = rorAnswerArray [3];
			mainDChoice.material.mainTexture = rorAnswerArray [4];
			break;
		case 2:
			// Animals - Beard - Humans - Laughing
			mainPortrait.material.mainTexture = rorImageArray [2];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [2];

			mainAChoice.material.mainTexture = rorAnswerArray [5];
			mainBChoice.material.mainTexture = rorAnswerArray [6];
			mainCChoice.material.mainTexture = rorAnswerArray [7];
			mainDChoice.material.mainTexture = rorAnswerArray [8];
			break;
		case 3:
			// Birds - Bones - Humans - Instruments
			mainPortrait.material.mainTexture = rorImageArray [3];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [3];

			mainAChoice.material.mainTexture = rorAnswerArray [9];
			mainBChoice.material.mainTexture = rorAnswerArray [10];
			mainCChoice.material.mainTexture = rorAnswerArray [11];
			mainDChoice.material.mainTexture = rorAnswerArray [12];
			break;
		case 4:
			// Animal Hide - Bat - Cocoon - Flower
			mainPortrait.material.mainTexture = rorImageArray [4];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [4];

			mainAChoice.material.mainTexture = rorAnswerArray [13];
			mainBChoice.material.mainTexture = rorAnswerArray [14];
			mainCChoice.material.mainTexture = rorAnswerArray [15];
			mainDChoice.material.mainTexture = rorAnswerArray [16];
			break;
		case 5:
			// Bat - Butterfly - Moth - Sheep
			mainPortrait.material.mainTexture = rorImageArray [5];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [5];

			mainAChoice.material.mainTexture = rorAnswerArray [17];
			mainBChoice.material.mainTexture = rorAnswerArray [18];
			mainCChoice.material.mainTexture = rorAnswerArray [19];
			mainDChoice.material.mainTexture = rorAnswerArray [20];
			break;
		case 6:
			// Animal Hide - Instruments - Staff - Tower
			mainPortrait.material.mainTexture = rorImageArray [6];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [6];

			mainAChoice.material.mainTexture = rorAnswerArray [21];
			mainBChoice.material.mainTexture = rorAnswerArray [22];
			mainCChoice.material.mainTexture = rorAnswerArray [23];
			mainDChoice.material.mainTexture = rorAnswerArray [24];
			break;
		case 7:
			// Arrow - Dish or Bowl - Human Faces - Vase
			mainPortrait.material.mainTexture = rorImageArray [7];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [7];

			mainAChoice.material.mainTexture = rorAnswerArray [25];
			mainBChoice.material.mainTexture = rorAnswerArray [26];
			mainCChoice.material.mainTexture = rorAnswerArray [27];
			mainDChoice.material.mainTexture = rorAnswerArray [28];
			break;
		case 8:
			// Aniamls - Face - Organ - Trophy 
			mainPortrait.material.mainTexture = rorImageArray [8];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [8];

			mainAChoice.material.mainTexture = rorAnswerArray [29];
			mainBChoice.material.mainTexture = rorAnswerArray [30];
			mainCChoice.material.mainTexture = rorAnswerArray [31];
			mainDChoice.material.mainTexture = rorAnswerArray [32];
			break;
		case 9:
			// Flower - Giraffe - Human - Tower
			mainPortrait.material.mainTexture = rorImageArray [9];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [9];

			mainAChoice.material.mainTexture = rorAnswerArray [33];
			mainBChoice.material.mainTexture = rorAnswerArray [34];
			mainCChoice.material.mainTexture = rorAnswerArray [35];
			mainDChoice.material.mainTexture = rorAnswerArray [36];
			break;
		case 10:
			// Banana - Crab - Lobster - Spider
			mainPortrait.material.mainTexture = rorImageArray [10];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [10];

			mainAChoice.material.mainTexture = rorAnswerArray [37];
			mainBChoice.material.mainTexture = rorAnswerArray [38];
			mainCChoice.material.mainTexture = rorAnswerArray [39];
			mainDChoice.material.mainTexture = rorAnswerArray [40];
			break;
		}
	}

	void OnTriggerStay (Collider other)
	{
		if (other.name == "Player") {
			if (Input.GetKeyDown (KeyCode.E)) {
				if (gamePhase <= 10 && (rorCS_1.optionPad1_Chosen || rorCS_2.optionPad2_Chosen || rorCS_3.optionPad3_Chosen || rorCS_4.optionPad4_Chosen)) {
					checkCollection ();
					rorCS_1.resetPads ();
					rorCS_2.resetPads ();
					rorCS_3.resetPads ();
					rorCS_4.resetPads ();
				}
			}
		}
	}

	void writeToFile(){
		string path = Application.dataPath.ToString() + @"\Rorschach Survey Results.txt";
		if (!File.Exists (path)) {
			string mainTitleText = "YOUR RESULTS" + Environment.NewLine;

			// ROOM 1 - BAT - BUTTERFLY - MOTH - SCARY FACE
			string header1Text = "ROOM 1 - Rorschach Image" + Environment.NewLine;
			string roomOneChoice = "";
			if (room1OptionChosen == 1) {roomOneChoice = "BAT" + Environment.NewLine;}
			if (room1OptionChosen == 2) {roomOneChoice = "BUTTERFLY" + Environment.NewLine;}
			if (room1OptionChosen == 3) {roomOneChoice = "MOTH" + Environment.NewLine;}
			if (room1OptionChosen == 4) {roomOneChoice = "SCARY FACE" + Environment.NewLine;}

			// ROOM 2 - Animals - Beard - Humans - Laughing
			string header2Text = "ROOM 2 - Rorschach Image" + Environment.NewLine;
			string roomTwoChoice = "";
			if (room2OptionChosen == 1) {roomTwoChoice = "ANIMALS" + Environment.NewLine;}
			if (room2OptionChosen == 2) {roomTwoChoice = "BEARD" + Environment.NewLine;}
			if (room2OptionChosen == 3) {roomTwoChoice = "HUMANS" + Environment.NewLine;}
			if (room2OptionChosen == 4) {roomTwoChoice = "LAUGHING" + Environment.NewLine;}

			// ROOM 3 - BIRDS - BONES - HUMANS - INSTRUMENTS
			string header3Text = "ROOM 3 - Rorschach Image" + Environment.NewLine;
			string roomThreeChoice = "";
			if (room3OptionChosen == 1) {roomThreeChoice = "BIRDS" + Environment.NewLine;}
			if (room3OptionChosen == 2) {roomThreeChoice = "BONES" + Environment.NewLine;}
			if (room3OptionChosen == 3) {roomThreeChoice = "HUMANS" + Environment.NewLine;}
			if (room3OptionChosen == 4) {roomThreeChoice = "INSTRUMENTS" + Environment.NewLine;}

			// ROOM 4 - ANIMAL HIDE - BAT - COCOON - FLOWER
			string header4Text = "ROOM 4 - Rorschach Image" + Environment.NewLine;
			string roomFourChoice = "";
			if (room4OptionChosen == 1) {roomFourChoice = "ANIMAL HIDE" + Environment.NewLine;}
			if (room4OptionChosen == 2) {roomFourChoice = "BAT" + Environment.NewLine;}
			if (room4OptionChosen == 3) {roomFourChoice = "COCOON" + Environment.NewLine;}
			if (room4OptionChosen == 4) {roomFourChoice = "FLOWER" + Environment.NewLine;}

			// ROOM 5 - BAT - BUTTERFLY - MOTH - SHEEP
			string header5Text = "ROOM 5 - Rorschach Image" + Environment.NewLine;
			string roomFiveChoice = "";
			if (room5OptionChosen == 1) {roomFiveChoice = "BAT" + Environment.NewLine;}
			if (room5OptionChosen == 2) {roomFiveChoice = "BUTTERFLY" + Environment.NewLine;}
			if (room5OptionChosen == 3) {roomFiveChoice = "MOTH" + Environment.NewLine;}
			if (room5OptionChosen == 4) {roomFiveChoice = "SHEEP" + Environment.NewLine;}

			// ROOM 6 - ANIMAL HIDE - INSTRUMENTS - STAFF - TOWER
			string header6Text = "ROOM 6 - Rorschach Image" + Environment.NewLine;
			string roomSixChoice = "";
			if (room6OptionChosen == 1) {roomSixChoice = "ANIMAL HIDE" + Environment.NewLine;}
			if (room6OptionChosen == 2) {roomSixChoice = "INSTRUMENTS" + Environment.NewLine;}
			if (room6OptionChosen == 3) {roomSixChoice = "STAFF" + Environment.NewLine;}
			if (room6OptionChosen == 4) {roomSixChoice = "TOWER" + Environment.NewLine;}

			// ROOM 7 - BIRDS - BONES - HUMANS - INSTRUMENTS
			string header7Text = "ROOM 7 - Rorschach Image" + Environment.NewLine;
			string roomSevenChoice = "";
			if (room7OptionChosen == 1) {roomSevenChoice = "BIRDS" + Environment.NewLine;}
			if (room7OptionChosen == 2) {roomSevenChoice = "BONES" + Environment.NewLine;}
			if (room7OptionChosen == 3) {roomSevenChoice = "HUMANS" + Environment.NewLine;}
			if (room7OptionChosen == 4) {roomSevenChoice = "INSTRUMENTS" + Environment.NewLine;}

			// ROOM 8 - ANIMAL HIDE - BAT - COCOON - FLOWER
			string header8Text = "ROOM 8 - Rorschach Image" + Environment.NewLine;
			string roomEightChoice = "";
			if (room8OptionChosen == 1) {roomEightChoice = "ANIMAL HIDE" + Environment.NewLine;}
			if (room8OptionChosen == 2) {roomEightChoice = "BAT" + Environment.NewLine;}
			if (room8OptionChosen == 3) {roomEightChoice = "COCOON" + Environment.NewLine;}
			if (room8OptionChosen == 4) {roomEightChoice = "FLOWER" + Environment.NewLine;}

			// ROOM 9 - FLOWER - GIRAFFE - HUMAN - TOWER
			string header9Text = "ROOM 9 - Rorschach Image" + Environment.NewLine;
			string roomNineChoice = "";
			if (room9OptionChosen == 1) {roomNineChoice = "FLOWER" + Environment.NewLine;}
			if (room9OptionChosen == 2) {roomNineChoice = "GIRAFFE" + Environment.NewLine;}
			if (room9OptionChosen == 3) {roomNineChoice = "HUMAN" + Environment.NewLine;}
			if (room9OptionChosen == 4) {roomNineChoice = "TOWER" + Environment.NewLine;}

			// ROOM 10 - BANANA - CRAB - LOBSTER - SPIDER
			string header10Text = "ROOM 10 - Rorschach Image" + Environment.NewLine;
			string roomTenChoice = "";
			if (room10OptionChosen == 1) {roomTenChoice = "BANANA" + Environment.NewLine;}
			if (room10OptionChosen == 2) {roomTenChoice = "CRAB" + Environment.NewLine;}
			if (room10OptionChosen == 3) {roomTenChoice = "LOBSTER" + Environment.NewLine;}
			if (room10OptionChosen == 4) {roomTenChoice = "SPIDER" + Environment.NewLine;}

			string wholeText = header1Text + roomOneChoice + Environment.NewLine + header2Text + roomTwoChoice +
			                   Environment.NewLine + header3Text + roomThreeChoice + Environment.NewLine + header4Text + roomFourChoice +
			                   Environment.NewLine + header5Text + roomFiveChoice + Environment.NewLine + header6Text + roomSixChoice +
			                   Environment.NewLine + header7Text + roomSevenChoice + Environment.NewLine + header8Text + roomEightChoice +
			                   Environment.NewLine + header9Text + roomNineChoice + Environment.NewLine + header10Text + roomTenChoice;

			File.WriteAllText (path, wholeText);
		}
	}


	private void backToMainMenu(){
		SceneManager.LoadSceneAsync ("MainMenu");
	}

	void checkCollection()
	{
		if (gamePhase == 1) {
			// Room 1 - Bat - Butterfly - Moth - Scary Face
			if (rorCS_1.optionPad1_Chosen) {
				room1OptionChosen = 1;
				gamePhase = 2;
			} else if (rorCS_2.optionPad2_Chosen) {
				room1OptionChosen = 2;
				gamePhase = 2;
			} else if (rorCS_3.optionPad3_Chosen) {
				room1OptionChosen = 3;
				gamePhase = 2;
			} else if (rorCS_4.optionPad4_Chosen) {
				room1OptionChosen = 4;
				gamePhase = 2;
			}
		} else if (gamePhase == 2) {
			if (rorCS_1.optionPad1_Chosen) {
				room2OptionChosen = 1;
				gamePhase = 3;
			} else if (rorCS_2.optionPad2_Chosen) {
				room2OptionChosen = 2;
				gamePhase = 3;
			} else if (rorCS_3.optionPad3_Chosen) {
				room2OptionChosen = 3;
				gamePhase = 3;
			} else if (rorCS_4.optionPad4_Chosen) {
				room2OptionChosen = 4;
				gamePhase = 3;
			}
		} else if (gamePhase == 3) {
			if (rorCS_1.optionPad1_Chosen) {
				room3OptionChosen = 1;
				gamePhase = 4;
			} else if (rorCS_2.optionPad2_Chosen) {
				room3OptionChosen = 2;
				gamePhase = 4;
			} else if (rorCS_3.optionPad3_Chosen) {
				room3OptionChosen = 3;
				gamePhase = 4;
			} else if (rorCS_4.optionPad4_Chosen) {
				room3OptionChosen = 4;
				gamePhase = 4;
			}
		} else if (gamePhase == 4) {
			if (rorCS_1.optionPad1_Chosen) {
				room4OptionChosen = 1;
				gamePhase = 5;
			} else if (rorCS_2.optionPad2_Chosen) {
				room4OptionChosen = 2;
				gamePhase = 5;
			} else if (rorCS_3.optionPad3_Chosen) {
				room4OptionChosen = 3;
				gamePhase = 5;
			} else if (rorCS_4.optionPad4_Chosen) {
				room4OptionChosen = 4;
				gamePhase = 5;
			} 
		} else if (gamePhase == 5) {
			if (rorCS_1.optionPad1_Chosen) {
				room5OptionChosen = 1;
				gamePhase = 6;
			} else if (rorCS_2.optionPad2_Chosen) {
				room5OptionChosen = 2;
				gamePhase = 6;
			} else if (rorCS_3.optionPad3_Chosen) {
				room5OptionChosen = 3;
				gamePhase = 6;
			} else if (rorCS_4.optionPad4_Chosen) {
				room5OptionChosen = 4;
				gamePhase = 6;
			} 
		} else if (gamePhase == 6) {
			if (rorCS_1.optionPad1_Chosen) {
				room6OptionChosen = 1;
				gamePhase = 7;
			} else if (rorCS_2.optionPad2_Chosen) {
				room6OptionChosen = 2;
				gamePhase = 7;
			} else if (rorCS_3.optionPad3_Chosen) {
				room6OptionChosen = 3;
				gamePhase = 7;
			} else if (rorCS_4.optionPad4_Chosen) {
				room6OptionChosen = 4;
				gamePhase = 7;
			}
		} else if (gamePhase == 7) {
			if (rorCS_1.optionPad1_Chosen) {
				room7OptionChosen = 1;
				gamePhase = 8;
			} else if (rorCS_2.optionPad2_Chosen) {
				room7OptionChosen = 2;
				gamePhase = 8;
			} else if (rorCS_3.optionPad3_Chosen) {
				room7OptionChosen = 3;
				gamePhase = 8;
			} else if (rorCS_4.optionPad4_Chosen) {
				room7OptionChosen = 4;
				gamePhase = 8;
			}
		} else if (gamePhase == 8) {
			if (rorCS_1.optionPad1_Chosen) {
				room8OptionChosen = 1;
				gamePhase = 9;
			} else if (rorCS_2.optionPad2_Chosen) {
				room8OptionChosen = 2;
				gamePhase = 9;
			} else if (rorCS_3.optionPad3_Chosen) {
				room8OptionChosen = 3;
				gamePhase = 9;
			} else if (rorCS_4.optionPad4_Chosen) {
				room8OptionChosen = 4;
				gamePhase = 9;
			}
		} else if (gamePhase == 9) {
			if (rorCS_1.optionPad1_Chosen) {
				room9OptionChosen = 1;
				gamePhase = 10;
			} else if (rorCS_2.optionPad2_Chosen) {
				room9OptionChosen = 2;
				gamePhase = 10;
			} else if (rorCS_3.optionPad3_Chosen) {
				room9OptionChosen = 3;
				gamePhase = 10;
			} else if (rorCS_4.optionPad4_Chosen) {
				room9OptionChosen = 4;
				gamePhase = 10;
			}
		} else if (gamePhase == 10) {
			if (rorCS_1.optionPad1_Chosen) {
				room10OptionChosen = 1;
				gamePhase = 11;
			} else if (rorCS_2.optionPad2_Chosen) {
				room10OptionChosen = 2;
				gamePhase = 11;
			} else if (rorCS_3.optionPad3_Chosen) {
				room10OptionChosen = 3;
				gamePhase = 11;
			} else if (rorCS_4.optionPad4_Chosen) {
				room10OptionChosen = 4;
				gamePhase = 11;
			}
		}
	}
}

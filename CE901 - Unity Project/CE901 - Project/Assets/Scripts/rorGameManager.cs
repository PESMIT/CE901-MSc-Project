using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rorGameManager : MonoBehaviour {

	// Main Room Game Objects
	Renderer mainPortrait, mainPortraitPlacard;
	Renderer mainAChoice, mainBChoice, mainCChoice, mainDChoice;
	GameObject choiceButton;

	// Reference to Option Pad Script
	rorCollectionScript rorCS_1, rorCS_2, rorCS_3, rorCS_4;

	// Game Loop Integer
	public int gamePhase;
	// Placard Headers
	public Texture[] rorPlacardHeaders;
	// Rorschach Images
	public Texture[] rorImageArray;
	// Rorschach Answers
	public Texture[] rorAnswerArray;




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

		// rorCS Reference
		rorCS_1 = GameObject.Find("Option Pad 1").GetComponent<rorCollectionScript>();
		rorCS_2 = GameObject.Find("Option Pad 2").GetComponent<rorCollectionScript>();
		rorCS_3 = GameObject.Find("Option Pad 3").GetComponent<rorCollectionScript>();
		rorCS_4 = GameObject.Find("Option Pad 4").GetComponent<rorCollectionScript>();
	}
	
	// Update is called once per frame
	void Update () {
		gameLoop ();
	}

	void gameLoop(){
		switch (gamePhase) {
		case 1:
			mainPortrait.material.mainTexture = rorImageArray [1];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [1];

			mainAChoice.material.mainTexture = rorAnswerArray [1];
			mainBChoice.material.mainTexture = rorAnswerArray [2];
			mainCChoice.material.mainTexture = rorAnswerArray [3];
			mainDChoice.material.mainTexture = rorAnswerArray [4];
			break;
		case 2:
			mainPortrait.material.mainTexture = rorImageArray [2];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [2];

			mainAChoice.material.mainTexture = rorAnswerArray [5];
			mainBChoice.material.mainTexture = rorAnswerArray [6];
			mainCChoice.material.mainTexture = rorAnswerArray [7];
			mainDChoice.material.mainTexture = rorAnswerArray [8];
			break;
		case 3:
			mainPortrait.material.mainTexture = rorImageArray [3];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [3];

			mainAChoice.material.mainTexture = rorAnswerArray [9];
			mainBChoice.material.mainTexture = rorAnswerArray [10];
			mainCChoice.material.mainTexture = rorAnswerArray [11];
			mainDChoice.material.mainTexture = rorAnswerArray [12];
			break;
		case 4:
			mainPortrait.material.mainTexture = rorImageArray [4];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [4];

			mainAChoice.material.mainTexture = rorAnswerArray [13];
			mainBChoice.material.mainTexture = rorAnswerArray [14];
			mainCChoice.material.mainTexture = rorAnswerArray [15];
			mainDChoice.material.mainTexture = rorAnswerArray [16];
			break;
		case 5:
			mainPortrait.material.mainTexture = rorImageArray [5];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [5];

			mainAChoice.material.mainTexture = rorAnswerArray [17];
			mainBChoice.material.mainTexture = rorAnswerArray [18];
			mainCChoice.material.mainTexture = rorAnswerArray [19];
			mainDChoice.material.mainTexture = rorAnswerArray [20];
			break;
		case 6:
			mainPortrait.material.mainTexture = rorImageArray [6];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [6];

			mainAChoice.material.mainTexture = rorAnswerArray [21];
			mainBChoice.material.mainTexture = rorAnswerArray [22];
			mainCChoice.material.mainTexture = rorAnswerArray [23];
			mainDChoice.material.mainTexture = rorAnswerArray [24];
			break;
		case 7:
			mainPortrait.material.mainTexture = rorImageArray [7];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [7];

			mainAChoice.material.mainTexture = rorAnswerArray [25];
			mainBChoice.material.mainTexture = rorAnswerArray [26];
			mainCChoice.material.mainTexture = rorAnswerArray [27];
			mainDChoice.material.mainTexture = rorAnswerArray [28];
			break;
		case 8:
			mainPortrait.material.mainTexture = rorImageArray [8];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [8];

			mainAChoice.material.mainTexture = rorAnswerArray [29];
			mainBChoice.material.mainTexture = rorAnswerArray [30];
			mainCChoice.material.mainTexture = rorAnswerArray [31];
			mainDChoice.material.mainTexture = rorAnswerArray [32];
			break;
		case 9:
			mainPortrait.material.mainTexture = rorImageArray [9];
			mainPortraitPlacard.material.mainTexture = rorPlacardHeaders [9];

			mainAChoice.material.mainTexture = rorAnswerArray [33];
			mainBChoice.material.mainTexture = rorAnswerArray [34];
			mainCChoice.material.mainTexture = rorAnswerArray [35];
			mainDChoice.material.mainTexture = rorAnswerArray [36];
			break;
		case 10:
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
				if (gamePhase < 10) {
					gamePhase += 1;
					rorCS_1.resetPads ();
				} else if (gamePhase >= 3) {
					gamePhase = 1;
				}
			}
		}
	}
}

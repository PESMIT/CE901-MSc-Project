﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour {
	// Canvas
	Text welcomeText, controlsText, controlsTextCont, objectiveText, objectiveTextCont, teleporterCorrectText, teleporterCorrectTextCont, teleporterIncorrectText, teleporterIncorrectTextCont;

	//Objective Text
	Text choiceText;

	public bool tutorialTextOn = false;
	public bool teleTextCorrect = false;
	public bool teleTextIncorrect = false;
	public bool choiceTextOn = false;


	// Use this for initialization
	void Start () {

		welcomeText = GameObject.Find ("Welcome Text").GetComponent<Text> ();
		controlsText = GameObject.Find("Controls Text").GetComponent<Text> ();
		controlsTextCont = GameObject.Find("Controls Text Cont").GetComponent<Text> ();
		objectiveText = GameObject.Find ("Objective Text").GetComponent<Text> ();
		objectiveTextCont = GameObject.Find ("Objective Text Cont").GetComponent<Text> ();
		choiceText = GameObject.Find ("Choice Text").GetComponent<Text> ();

		teleporterCorrectText = GameObject.Find ("Teleporter Correct Text").GetComponent<Text> ();
		teleporterCorrectTextCont = GameObject.Find ("Teleporter Correct Text Cont").GetComponent<Text> ();
		teleporterIncorrectText = GameObject.Find ("Teleporter Incorrect Text").GetComponent<Text> ();
		teleporterIncorrectTextCont = GameObject.Find ("Teleporter Incorrect Text Cont").GetComponent<Text> ();

		Invoke ("RemoveChoiceText", 0.01f);
		Invoke ("DisplayTutorialOne", 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			Invoke ("DisplayTutorialOne", 0.5f);
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			Invoke ("DisplayChoiceText", 0.5f);
		}
	}

	public void DisplayTeleporterCorrect(){
		teleTextCorrect = true;
		teleporterCorrectText.text = "YOU HAVE MADE A CHOICE AND HAVE ACTIVATED THE TELEPORTER";
		teleporterCorrectTextCont.text = "NOW STEP ONTO THE GREEN LIT TELEPORTER TO MOVE TO THE NEXT STAGE";
		Invoke ("RemoveTeleporterCanvas", 2.5f);
	}

	public void DisplayTeleporterIncorrect(){
		teleTextIncorrect = true;
		teleporterIncorrectText.text = "YOU HAVE NOT YET MADE A CHOICE BY PLACING A SPHERE ON A CHOICE PAD";
		teleporterIncorrectTextCont.text = "PLACE A SPHERE ON A CHOICE PAD AND THE TELEPORTER WILL ACTIVATE";
		Invoke ("RemoveTeleporterCanvas", 2.5f);
	}

	public void DisplayChoiceText(){
		choiceTextOn = true;
		choiceText.text = "Choose between Option A and Option B\n by placing a sphere on the respective platform.".ToUpper();
		Invoke ("RemoveChoiceText", 2.5f);
	}

	public void RemoveChoiceText(){
		choiceTextOn = false;
		choiceText.text = "";
	}

	public void RemoveTeleporterCanvas(){
		teleTextCorrect = false;
		teleTextIncorrect = false;
		teleporterCorrectText.text = "";
		teleporterCorrectTextCont.text = "";
		teleporterIncorrectText.text = "";
		teleporterIncorrectTextCont.text = "";
	}

	public void DisplayTutorialOne(){
		tutorialTextOn = true;
		welcomeText.text = "WELCOME TO THE COLOUR SURVEY";
		controlsText.text = "YOU CAN MOVE AROUND WITH THE W/A/S/D KEYS";
		controlsTextCont.text = "YOU CAN PICK UP OBJECTS CLOSEST TO YOU WITH THE E KEY";
		objectiveText.text = "PLACE THE SPHERE OBJECT ONTO A PANEL OF YOUR CHOOSING";
		objectiveTextCont.text = "PRESS T TO SHOW THIS TUTORIAL AGAIN";
		Invoke ("RemoveTutorialOne", 5.0f);
	}

	public void RemoveTutorialOne(){
		tutorialTextOn = false;
		welcomeText.text = "";
		controlsText.text = "";
		controlsTextCont.text = "";
		objectiveText.text = "";
		objectiveTextCont.text = "";
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour {

	GameObject pauseMenu, mainCamera;
	Camera_Control mainCameraCC;
	Camera_Control playerCC;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1.0f;
		pauseMenu = GameObject.Find ("Pause Menu");
		mainCamera = GameObject.Find ("Main Camera");
		mainCameraCC = mainCamera.GetComponent<Camera_Control> ();
		playerCC = GameObject.Find ("Player").GetComponent<Camera_Control> ();
		pauseMenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if (pauseMenu.activeSelf == true) {
				PauseMenuOff ();
			} else if (pauseMenu.activeSelf == false) {
				PauseMenuOn ();
			}
		}
	}

	void PauseMenuOn(){
		pauseMenu.SetActive (true);
		mainCameraCC.isPaused = true;
		playerCC.isPaused = true;
		Time.timeScale = 0.0f;
	}

	void PauseMenuOff(){
		pauseMenu.SetActive (false);
		mainCameraCC.isPaused = false;
		playerCC.isPaused = false;
		Time.timeScale = 1.0f;
	}
}

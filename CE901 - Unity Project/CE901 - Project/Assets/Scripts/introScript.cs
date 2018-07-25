using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introScript : MonoBehaviour {

	Camera_Control playerCC;
	Player_Movement playerMM;
	Animator intro;
	Camera playerCam, introCam;


	// Use this for initialization
	void Start () {
		intro = GetComponent<Animator> ();
		playerCC = GameObject.Find ("Player").GetComponent<Camera_Control> ();
		playerMM = GameObject.Find ("Player").GetComponent<Player_Movement> ();
		playerCam = GameObject.Find ("Player").GetComponentInChildren<Camera> ();
		introCam = GameObject.Find ("Animation Camera").GetComponent<Camera> ();


	}
	
	// Update is called once per frame
	void Update () {
		if (intro.GetCurrentAnimatorStateInfo (0).IsName ("rorIntro")) {
			playerCC.isPaused = true;
			playerMM.playerMovementisPaused = true;
		}
		if (!intro.GetCurrentAnimatorStateInfo(0).IsName("rorIntro")) {
			playerCC.isPaused = false;
			playerMM.playerMovementisPaused = false;
			playerCam.depth = 2;
			introCam.depth = 1;
		}
	}
}

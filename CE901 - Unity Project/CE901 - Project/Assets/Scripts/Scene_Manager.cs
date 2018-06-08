using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void onClick(int level){
		if (level == 0) {
			SceneManager.LoadSceneAsync ("MainMenu");
		} else if (level == 1) {
			SceneManager.LoadSceneAsync ("SurveySelection");
		} else if (level == 2) {
			SceneManager.LoadSceneAsync ("FirstScenario");
		} else {
			Debug.Log ("No Scene Number matches that input");
		}
	}

	public void onQuit(){
		Application.Quit ();
	}
}

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
			SceneManager.LoadScene ("FirstScenario");
		} else {
			Debug.Log ("Incorrect Scene Number to load");
		}
	}

	public void onQuit(){
		Application.Quit ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rorCanvas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnGUI(){
		GUI.Box (new Rect (Screen.width / 2, Screen.height / 2, 20, 20), "");
	}
}

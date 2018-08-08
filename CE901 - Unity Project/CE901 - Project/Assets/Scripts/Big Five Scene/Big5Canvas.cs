using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big5Canvas : MonoBehaviour {

	private Pickup_Script playerPS;
	private GUIStyle carryGUI, nonCarryGUI;

	// Use this for initialization
	void Start () {
		playerPS = GameObject.Find ("Player").GetComponent<Pickup_Script> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnGUI(){

		Texture2D greenTexture = new Texture2D (20, 20);
		Texture2D blackTexture = new Texture2D (20, 20);

		carryGUI = new GUIStyle (GUI.skin.box);
		carryGUI.normal.textColor = Color.green;
		carryGUI.normal.background = greenTexture;

		nonCarryGUI = new GUIStyle (GUI.skin.box);
		nonCarryGUI.normal.textColor = Color.black;
		nonCarryGUI.normal.background = blackTexture;

		if (playerPS.carrying) 
		{
			for (int y = 0; y < greenTexture.height; ++y) {
				for (int x = 0; x < greenTexture.width; ++x) {
					float r = Random.value;
					Color color = new Color (0, 255, 0);
					greenTexture.SetPixel (x, y, color);
				} 
			}
			greenTexture.Apply ();
			GUI.Box (new Rect (Screen.width / 2, Screen.height / 2, 20, 20), "", carryGUI);
		} 
		else 
		{
			for (int y = 0; y < blackTexture.height; ++y) {
				for (int x = 0; x < blackTexture.width; ++x) {
					float r = Random.value;
					Color color = new Color (0, 0, 0);
					blackTexture.SetPixel (x, y, color);
				} 
			}
			blackTexture.Apply ();
			GUI.Box (new Rect (Screen.width / 2, Screen.height / 2, 20, 20), "", nonCarryGUI);
		}


	}
}

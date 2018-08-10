using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour {
	private static SoundManager instance = null;
	private Slider mainSlider;
	private Text currentVolume;
	private AudioSource cameraAS;

	private static SoundManager Instance{
		get{ return instance; }
	}

	void Awake(){
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}

	void Start(){
		cameraAS = GameObject.Find ("Main Camera").GetComponent<AudioSource> ();
		if(SceneManager.GetActiveScene().name == "SettingsScene"){
			

		}
	}

	void playSound(){
		cameraAS.Play ();
	}

	void Update(){
		if (SceneManager.GetActiveScene ().name == "SettingsScene") {
			mainSlider = GameObject.Find ("Volume Slider").GetComponent<Slider>();
			mainSlider.onValueChanged.AddListener (delegate {ValueChangeCheck ();});
			mainSlider.value = this.GetComponent<AudioSource> ().volume;
			currentVolume = GameObject.Find ("Current Volume").GetComponent<Text> ();
			currentVolume.text = "CURRENT VOLUME: " + (mainSlider.value * 100).ToString("F2") + "%";
		}
	}

	void ValueChangeCheck(){
		this.GetComponent<AudioSource>().volume = mainSlider.value;
	}
}

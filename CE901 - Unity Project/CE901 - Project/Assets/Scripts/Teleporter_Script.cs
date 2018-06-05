using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter_Script : MonoBehaviour {

	GameObject platform1, platform2, player;
	Collection_Trigger choice1, choice2;
	Material m_Material;

	// Use this for initialization
	void Start () {
		platform1 = GameObject.Find ("Platform_1");
		platform2 = GameObject.Find ("Platform_2");
		player = GameObject.Find ("Player");
		choice1 = platform1.GetComponent<Collection_Trigger> ();
		choice2 = platform2.GetComponent<Collection_Trigger> ();
		m_Material = GetComponent<Renderer> ().material;
	}
	
	// Update is called once per frame
	void Update () {
		if (choice1.platform1Chosen) {
			m_Material.color = Color.green;
		} else if (choice1.platform2Chosen) {
			m_Material.color = Color.green;
		} else if (choice2.platform1Chosen) {
			m_Material.color = Color.green;
		} else if (choice2.platform2Chosen) {
			m_Material.color = Color.green;
		} else {
			m_Material.color = Color.black;
		}
	}

	void OnTriggerEnter(Collider other){
		if (choice1.platform1Chosen && !choice2.platform2Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform 1 Chosen - Now Teleporting");
				player.transform.position = new Vector3 (0, 7);
			}
		}
		else if (!choice1.platform1Chosen && choice2.platform2Chosen) {
			if (other.name == "Player_Position") {
				Debug.Log ("Platform 2 Chosen - Now Teleporting");
				player.transform.position = new Vector3 (0, 7);
			}
		}
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour {

	public bool isPaused = false;

	public enum RotationAxis{
		MouseX = 1,
		MouseY = 2
	}

	public RotationAxis axes = RotationAxis.MouseX;

	public float minimumVert = -45.0f;
	public float maximumVert = 45.0f;
	public float sensHorizontal = 1.5f;
	public float sensVertical = 0.1f;

	public float _rotationX = 0;

	// Update is called once per frame
	void Update () {
		if (!isPaused) {
			if (axes == RotationAxis.MouseX) {
				transform.Rotate (0, Input.GetAxis ("Mouse X") * sensHorizontal, 0);
			} else if (axes == RotationAxis.MouseY) {
				_rotationX -= Input.GetAxis ("Mouse Y") * sensVertical;
				_rotationX = Mathf.Clamp (_rotationX, minimumVert, maximumVert);
				float rotationY = transform.localEulerAngles.y;
				transform.localEulerAngles = new Vector3 (_rotationX, rotationY, 0);
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;

public class Player_Movement : MonoBehaviour {

	public float speed = 6.0f;
	public float gravity = -9.8f;
	public float pushPower = 2.0f;

	private CharacterController _charCont;

	public bool playerMovementisPaused;

	// Use this for initialization
	void Start () {
		_charCont = GetComponent<CharacterController> ();
		playerMovementisPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!playerMovementisPaused) {
			float deltaX = Input.GetAxis ("Horizontal") * speed;
			float deltaZ = Input.GetAxis ("Vertical") * speed;
			Vector3 movement = new Vector3 (deltaX, 0, deltaZ);
			movement = Vector3.ClampMagnitude (movement, speed);  // Limits max speed

			movement.y = gravity;

			movement *= Time.deltaTime;
			movement = transform.TransformDirection (movement);
			_charCont.Move (movement);
		}

	}

	void OnControllerColliderHit(ControllerColliderHit hit){
		if (!playerMovementisPaused) {
			Rigidbody body = hit.collider.attachedRigidbody;
			if(body == null || body.isKinematic)
				return;
			if(hit.moveDirection.y < -0.3f)
				return;
			Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
			body.velocity = pushDir * pushPower;
		}
	}
}

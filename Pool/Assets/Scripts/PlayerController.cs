using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed; // adjust speed of player movement in Unity Editor

	private Rigidbody rb;

	void Start (){
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate (){
		float moveHorizontal = Input.GetAxis ("Horizontal"); // use left and right arrow keys to move player
		float moveVertical = Input.GetAxis ("Vertical"); // use up and down arrow keys to move player

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

}
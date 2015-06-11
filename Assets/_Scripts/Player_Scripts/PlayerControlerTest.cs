using UnityEngine;
using System.Collections;

public class PlayerControlerTest : MonoBehaviour {

	Rigidbody playerRigidbody;
	Vector3 movement;  
	public float speed = 6f;
	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent <Rigidbody> ();
	}


	void FixedUpdate ()
	{
		// Store the input axes.
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		
		// Move the player around the scene.
		Move (h, v);
	}

	void Move (float h, float v)
	{
		// Set the movement vector based on the axis input.
		movement.Set (h, 0f, v);
		
		// Normalise the movement vector and make it proportional to the speed per second.
		movement = movement.normalized * speed * Time.deltaTime;
		
		// Move the player to it's current position plus the movement.
		playerRigidbody.MovePosition (transform.position + movement);
	}
}



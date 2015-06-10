using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 6f;            // The speed that the player will move at.
		
	private Vector3 moveDirection = Vector3.zero;                   // The vector to store the direction of the player's movement.
	private Vector3 rightDirection = Vector3.zero;
	Rigidbody playerRigidbody;          // Reference to the player's rigidbody.
	int floorMask;                      // A layer mask so that a ray can be cast just at gameobjects on the floor layer.

	void Awake ()
		{
			// Create a layer mask for the floor layer.
			floorMask = LayerMask.GetMask ("Terrain");
			
			// Set up references.
			playerRigidbody = GetComponent <Rigidbody> ();
		}
		
		
	void FixedUpdate ()
		{
			// Store the input axes.
			float h = Input.GetAxisRaw ("Horizontal");
			float v = Input.GetAxisRaw ("Vertical");
			
			// Move the player around the scene.
			Move (h,v);
		
		}
		
	void Move (float h, float v)
	{
		moveDirection.Set (h, 0, v);

		// Normalise the movement vector and make it proportional to the speed per second.
		moveDirection = moveDirection.normalized * speed * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		playerRigidbody.MovePosition (transform.position + moveDirection);
	}

}
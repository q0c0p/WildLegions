using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed_ = 6f;            // The speed that the player will move at.
	private Vector3 moveDirection_ = Vector3.zero;                   // The vector to store the direction of the player's movement.
	private Vector3 rightDirection_ = Vector3.zero;
	Rigidbody playerRigidbody_;          // Reference to the player's rigidbody.
	int floorMask_;                      // A layer mask so that a ray can be cast just at gameobjects on the floor layer.

	void Awake ()
		{
			// Create a layer mask for the floor layer.
			floorMask_ = LayerMask.GetMask ("Terrain");
			
			// Set up references.
			playerRigidbody_ = GetComponent <Rigidbody> ();
		}
		
		
	void FixedUpdate ()
		{
			// Store the input axes.
			float h_ = Input.GetAxisRaw ("Horizontal");
			float v_ = Input.GetAxisRaw ("Vertical");
			
			// Move the player around the scene.
			Move (h_,v_);
		
		}
		
	void Move (float h, float v)
	{
		moveDirection_.Set (0, 0, v);

		// Normalise the movement vector and make it proportional to the speed per second.
		moveDirection_ = moveDirection_.normalized * speed_ * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		playerRigidbody_.MovePosition (transform.position + moveDirection_);
	}

}
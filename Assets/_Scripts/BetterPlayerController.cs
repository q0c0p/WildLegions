using UnityEngine;
using System.Collections;

public class BetterPlayerController : MonoBehaviour {
	/*
	float speed = 6f; 
	float jumpSpeed = 8f; 
	float turnSpeed = 60f;
	float gravity = 20f;
	float camRayLength = 100f;          // The length of the ray from the camera into the scene.
	int floorMask;                      // A layer mask so that a ray can be cast just at gameobjects on the floor layer.

	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;


	void Awake ()
	{
		// Create a layer mask for the floor layer.
		floorMask = LayerMask.GetMask ("Floor");
		
		// Set up references.
		//anim = GetComponent <Animator> ();
		controller = GetComponent <CharacterController> ();
	}

	void Start(){
	controller = GetComponent<CharacterController>();
	}
	
	void FixedUpdate() {
		if (controller.isGrounded) { 
			//Quaternion turn = Turning (); 
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			//moveDirection = transform.Rotate(turn); 
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

	Quaternion Turning ()
	{
		Quaternion newRotation = Quaternion.identity;
		// Create a ray from the mouse cursor on screen in the direction of the camera.
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		
		// Create a RaycastHit variable to store information about what was hit by the ray.
		RaycastHit floorHit;
		
		// Perform the raycast and if it hits something on the floor layer...
		if(Physics.Raycast (camRay, out floorHit, camRayLength, floorMask))
		{
			// Create a vector from the player to the point on the floor the raycast from the mouse hit.
			Vector3 playerToMouse = floorHit.point - transform.position;
			
			// Ensure the vector is entirely along the floor plane.
			playerToMouse.y = 0f;
			
			// Create a quaternion (rotation) based on looking down the vector from the player to the mouse.
			newRotation = Quaternion.LookRotation (playerToMouse);
			

		}
		// Set the player's rotation to this new rotation.
		return (newRotation);
	}
	*/
}
using UnityEngine;
using System.Collections;

public class ButterflyBehaviourScript : MonoBehaviour {
	
	public float mSpeed;
	private Rigidbody mCharacterController;
	public Animation mAnimation;

	void Start ()
	{
		mCharacterController = GetComponent<Rigidbody>();
		mAnimation = GetComponent<Animation>();
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		mCharacterController.MovePosition(transform.position + movement * mSpeed * Time.deltaTime);
		//Quaternion newRotation = Quaternion.LookRotation (Vector3.zero);
		//mCharacterController.MoveRotation (newRotation);
		mAnimation.Play("Take 001");
	}
}

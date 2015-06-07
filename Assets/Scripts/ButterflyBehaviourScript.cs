using UnityEngine;
using System.Collections;

public class ButterflyBehaviourScript : MonoBehaviour {
	
	public float mSpeed;
	private CharacterController mCharacterController;
	public Animation mAnimation;

	void Start ()
	{
		mCharacterController = GetComponent<CharacterController>();
		mAnimation = GetComponent<Animation>();
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		mCharacterController.SimpleMove (movement * mSpeed);

		mAnimation.Play("Take 001");
	}
}

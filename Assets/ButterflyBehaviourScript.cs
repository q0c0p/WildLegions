using UnityEngine;
using System.Collections;

public class ButterflyBehaviourScript : MonoBehaviour {

	public float speed;
	
	private CharacterController cc;
	
	void Start ()
	{
		cc = GetComponent<CharacterController>();
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		cc.SimpleMove (movement * speed);
	}
}

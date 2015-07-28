using UnityEngine;
using System.Collections;

public class KittenController : MonoBehaviour {

	NpcAnimationAdapter anim;

	void Start()
	{
		anim = new KittenAnimationAdapterImpl (gameObject);
	}

	void FixedUpdate ()
	{


		// Store the input axes.
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		bool meow = Input.GetKey ("m");
		bool jump = Input.GetKey ("j");

		if (h != 0f) {

			anim.Walk (true);
		} else {
			anim.Walk (false);
		}
		if (v != 0f) {
			
			anim.Run (true);
		} else {
			anim.Run (false);
		}
		if (meow) {
			
			anim.Scream ();
		}
		if (jump) {
			
			anim.Jump ();
		}
		/*
		 if(v != 0){
			anim.Jump();
		}
		*/

	}

}


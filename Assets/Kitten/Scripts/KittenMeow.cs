using UnityEngine;
using System.Collections;

public class KittenMeow : MonoBehaviour {

	Animator anim;
	
	void Awake () {
		
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Animate ();
	}
	
	void Animate () {
		anim.SetBool ("kitten_Meow", true);
	}
}

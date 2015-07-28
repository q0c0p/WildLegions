using UnityEngine;
using System.Collections;

public class KittenItching : MonoBehaviour {

	Animator anim;

	void Awake () {
	
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Animate ();
	}

	void Animate () {
		anim.SetBool ("kitten_Itching", true);
	}
}

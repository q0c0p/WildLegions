﻿using UnityEngine;
using System.Collections;

public class PlayerControlerTest : MonoBehaviour {

	GameObject player_;
	Vector3 movement_;  
	public float speed_ = 6f;
	public float rotateSpeed_ = 50f ;

	public float smooth = 2.0F;
	// Use this for initialization
	void Start () {
		player_ = GetComponent <GameObject> ();
	}


	void FixedUpdate ()
	{
		Rotation ();
		Move ();
	}
	
	void Rotation ()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(Vector3.up, rotateSpeed_ * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(Vector3.up, -rotateSpeed_ * Time.deltaTime);
		}
	}

	void Move ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate(Vector3.forward* speed_ * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate(Vector3.forward* -speed_ * Time.deltaTime);
		}
	}

}



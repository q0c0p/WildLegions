﻿using UnityEngine;
using System.Collections;

public class AnimalController : MonoBehaviour {
	private AnimalAction action_;
	private AnimalMovement movement_;
	public string animalName = "mouzou";
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void setAction(AnimalAction action)
	{
		action_ = action;
		action_.playAction(this);
	}
	public void setMovement(AnimalMovement movement)
	{
		movement_ = movement;
		movement_.move (this);
	}

	void onTriggerEnter(Collider other)
	{
		print ("something is there");
		/*
		if (other.gameObject.tag == "Player") {
			print ("I go away from the player");
			setAction(new GoAwayFrom(other.gameObject));
		}
		*/
	}
	void onTriggerStay(Collider other)
	{
		print ("something is there");
		/*
		if (other.gameObject.tag == "Player") {
			print ("I go away from the player");
			setAction(new GoAwayFrom(other.gameObject));
		}
		*/
	}
}

﻿using UnityEngine;
using System.Collections;

public class Follow : AnimalAction
{
	private GameObject other_;
	private Vector3 target_;
	private NavMeshAgent nav_;

	public Follow (GameObject entity, GameObject other)
	{
		entity_ = entity;
		other_ = other;
		target_ = other_.transform.position;
		nav_ = entity_.GetComponent<NavMeshAgent>();
		startAction ();
	}
	public override void playAction()
	{
		if(other_.transform.position != target_)
		{
			target_ = other_.transform.position;
			startAction ();
		}
	}
	public void startAction()
	{
		Vector3 direction = other_.transform.position - entity_.transform.position;
		nav_.SetDestination (direction);
	}
}
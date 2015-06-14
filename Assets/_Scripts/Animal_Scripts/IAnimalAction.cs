﻿using UnityEngine;
using System.Collections;

public interface IAnimalAction {
	void playAction();
}
public class Eat : IAnimalAction
{
	private AnimalController entity_;
	public Eat (AnimalController entity)
	{
		entity_ = entity;
	}

	public void playAction()
	{
		MonoBehaviour.print ("I eat !"+entity_.animalName);
	}
}
public class Attack : IAnimalAction
{
	private AnimalController entity_;
	public Attack (AnimalController entity)
	{
		entity_ = entity;
	}
	public void playAction()
	{
		MonoBehaviour.print ("Attack!");
	}
}
public class Follow : IAnimalAction
{
	private AnimalController entity_;
	public Follow (AnimalController entity)
	{
		entity_ = entity;
	}
	public void playAction()
	{
		MonoBehaviour.print ("I follow my master !");
	}

}
public class WalkAround : IAnimalAction
{
	private AnimalController entity_;
	public WalkAround (AnimalController entity)
	{
		entity_ = entity;
	}
	public void playAction()
	{
		MonoBehaviour.print ("I walk around");
	}

}
public class GoAwayFrom : IAnimalAction
{
	GameObject other_;
	float distance_;
	private AnimalController entity_;
	public GoAwayFrom(GameObject other,float distance,AnimalController entity)
	{
		entity_ = entity;
		other_ = other;
		distance_ = distance;
	}
	public GoAwayFrom(GameObject other,AnimalController entity)
	{
		entity_ = entity;
		other_ = other;
		distance_ = 5f;
	}
	public void playAction()
	{
		Vector3 direction = entity_.transform.position - other_.transform.position;
		direction = direction.normalized * distance_;
		entity_.setMovement (new Run (direction + entity_.transform.position,entity_));
	}
}

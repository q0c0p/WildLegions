using UnityEngine;
using System.Collections;

public interface AnimalAction {
	void playAction(AnimalController entity);
}
public class Eat : AnimalAction
{
	public void playAction(AnimalController entity)
	{
		MonoBehaviour.print ("I eat !"+entity.animalName);
	}
}
public class Attack : AnimalAction
{
	public void playAction(AnimalController entity)
	{
		MonoBehaviour.print ("Attack!");
	}
}
public class Follow : AnimalAction
{
	public void playAction(AnimalController entity)
	{
		MonoBehaviour.print ("I follow my master !");
	}
}
public class WalkAround : AnimalAction
{
	public void playAction(AnimalController entity)
	{
		MonoBehaviour.print ("I walk around");
	}
}
public class GoAwayFrom : AnimalAction
{
	GameObject other_;
	float distance_;
	public GoAwayFrom(GameObject other,float distance)
	{
		other_ = other;
		distance_ = distance;
	}
	public GoAwayFrom(GameObject other)
	{
		other_ = other;
		distance_ = 2f;
	}
	public void playAction(AnimalController entity)
	{
		Vector3 direction = entity.transform.position - other_.transform.position;
		direction = direction.normalized * distance_;
		entity.setMovement (new Run (direction + entity.transform.position));
	}
}


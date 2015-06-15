using UnityEngine;
using System.Collections;

public interface IAnimalAction {
	void playAction();
	void stopAction();
}

public abstract class AnimalAction : IAnimalAction
{
	
	protected AnimalController entity_;
	public virtual void playAction()
	{

	}
	public void stopAction()
	{

	}
}

public class Eat : AnimalAction
{
	public Eat (AnimalController entity)
	{ 
		entity_ = entity;
	}

	public override void playAction()
	{
		MonoBehaviour.print ("I eat !"+entity_.animalName);
	}
}
public class Attack : AnimalAction
{
	public Attack (AnimalController entity)
	{
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("Attack!"+entity_.animalName);
	}
}
public class Follow : AnimalAction
{
	public Follow (AnimalController entity)
	{
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("I follow my master !"+entity_.animalName);
	}

}
public class WalkAround : AnimalAction
{
	public WalkAround (AnimalController entity)
	{
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("I walk around and i am "+entity_.animalName);
	}

}
public class GoAwayFrom : AnimalAction
{
	GameObject other_;
	float distance_;
	public GoAwayFrom(GameObject other,AnimalController entity,float distance)
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
	public override void playAction()
	{
		Vector3 direction = entity_.transform.position - other_.transform.position;
		direction = direction.normalized * distance_;
		entity_.setMovement (new Run (direction + entity_.transform.position,entity_));
	}

}


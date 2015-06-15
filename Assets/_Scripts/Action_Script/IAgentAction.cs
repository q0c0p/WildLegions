using UnityEngine;
using System.Collections;

public interface IAgentAction {
	void playAction();
	void stopAction();
	IMovement getMovement();
}

public abstract class AnimalAction : IAgentAction
{
	
	protected GameObject entity_;
	protected IMovement movement_;
	
	public virtual void playAction()
	{
		if(!movement_.isFinished())
			movement_.move ();
	}
	public void stopAction()
	{

	}
	public IMovement getMovement()
	{
		return movement_;
	}
}

public class Eat : AnimalAction
{
	public Eat (GameObject entity)
	{ 
		entity_ = entity;
	}

	public override void playAction()
	{
		MonoBehaviour.print ("I eat !");
	}
}
public class Attack : AnimalAction
{
	public Attack (GameObject entity)
	{
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("Attack!");
	}
}
public class Follow : AnimalAction
{
	public Follow (GameObject entity)
	{
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("I follow my master !");
	}

}
public class WalkAround : AnimalAction
{
	public WalkAround (GameObject entity)
	{
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("I walk around");
	}

}
public class GoAwayFrom : AnimalAction
{
	private GameObject other_;
	float distance_;

	public GoAwayFrom(GameObject entity, GameObject other , float distance)
	{
		entity_ = entity;
		other_ = other;
		distance_ = distance;
		startAction ();
	}
	public GoAwayFrom(GameObject entity,GameObject other)
	{
		entity_ = entity;
		other_ = other;
		distance_ = 10f;
		startAction ();
	}
	private void startAction()
	{
		/* A movement to the opposite of the other game object */
		Vector3 direction = entity_.transform.position - other_.transform.position;
		direction = direction.normalized * distance_;
		movement_ = new LinearMovement (entity_,direction + entity_.transform.position);
	}
}


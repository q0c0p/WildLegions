using UnityEngine;
using System.Collections;

public interface IMovement{
	// Use this for initialization
	void move();
	bool isFinished();
}

public abstract class MovementTo : IMovement
{
	public float speed_ = 3f;
	public float epsilon = 0.5f;
	protected GameObject entity_;
	protected Vector3 destination_;
	public virtual void move()
	{
	}
	public virtual bool isFinished()
	{
		return (Vector3.Distance (entity_.transform.position, destination_) < epsilon);
	}
}

public class LinearMovement : MovementTo
{
	public LinearMovement(GameObject entity , Vector3 destination)
	{
		destination.y = 0;
		entity_ = entity;
		destination_ = destination;
	}
	public override void move()
	{
		//entity_.transform.position = Vector3.Lerp (start_, destination_, speed_ * Time.deltaTime);
		entity_.transform.position += (destination_-entity_.transform.position).normalized * Time.deltaTime *  speed_;
	}
}
public class LerpedMovement : MovementTo
{
	public LerpedMovement(GameObject entity , Vector3 destination)
	{
		destination.y = 0;
		entity_ = entity;
		destination_ = destination;
	}
	public override void move()
	{
		entity_.transform.position = Vector3.Lerp (entity_.transform.position, destination_, speed_ * Time.deltaTime);
	}
}


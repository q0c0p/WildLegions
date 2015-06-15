using UnityEngine;
using System.Collections;

public interface IMovement{
	// Use this for initialization
	void move();
	bool isFinished();
}

public class LinearMovement : IMovement
{
	protected float speed_ = 7f;
	protected GameObject entity_;
	Vector3 destination_;
	Vector3 start_;
	public LinearMovement(GameObject entity , Vector3 destination)
	{
		destination.y = 0;
		entity_ = entity;
		start_ = entity_.transform.position;
		destination_ = destination;
	}
	public void move()
	{
		//entity_.transform.position = Vector3.Lerp (start_, destination_, speed_ * Time.deltaTime);
		entity_.transform.position += (destination_-start_) * Time.deltaTime;
	}
	public bool isFinished()
	{
		return (Vector3.Distance (entity_.transform.position, destination_) < 0.5);
	}
}
public class LerpedMovement : IMovement
{
	protected float speed_ = 7f;
	protected GameObject entity_;
	Vector3 destination_;
	Vector3 start_;
	public LerpedMovement(GameObject entity , Vector3 destination)
	{
		destination.y = 0;
		entity_ = entity;
		start_ = entity_.transform.position;
		destination_ = destination;
	}
	public void move()
	{
		//entity_.transform.position = Vector3.Lerp (start_, destination_, speed_ * Time.deltaTime);
		entity_.transform.position += (destination_-start_) * Time.deltaTime;
	}
	public bool isFinished()
	{
		return (Vector3.Distance (entity_.transform.position, destination_) < 0.5);
	}
}


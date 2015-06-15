using UnityEngine;
using System.Collections;

public interface IAnimalMovement{
	// Use this for initialization
	void move();
	void stop();
}

public class Run : IAnimalMovement
{
	protected float speed_;
	protected AnimalController entity_;
	private IEnumerator coroutine_;
	Vector3 destination_;
	public Run(Vector3 destination, AnimalController entity)
	{
		entity_ = entity;
		destination_ = destination;
	}
	public void move()
	{
		coroutine_ = Movement (destination_);
		speed_ = 2;
		entity_.StartCoroutine(coroutine_);
	}
	public void stop()
	{
		entity_.StopCoroutine (coroutine_);
	}
	IEnumerator Movement (Vector3 target)
	{
		target.y = 0;
		while(Vector3.Distance(entity_.transform.position, target) > 0.05f)
		{
			entity_.transform.position = Vector3.Lerp(entity_.transform.position, target, speed_ * Time.deltaTime);
			yield return null;
		}

	}
}


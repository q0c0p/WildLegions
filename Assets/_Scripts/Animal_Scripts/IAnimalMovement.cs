using UnityEngine;
using System.Collections;

public interface IAnimalMovement{
	// Use this for initialization
	void move();
}

public class Run : IAnimalMovement
{
	protected float speed;
	protected AnimalController entity_;
	Vector3 destination_;
	public Run(Vector3 destination, AnimalController entity)
	{
		entity_ = entity;
		destination_ = destination;
	}
	public void move()
	{
		speed = 2;
		entity_.StartCoroutine(Movement(destination_));
	}
	IEnumerator Movement (Vector3 target)
	{
		target.y = 0;
		while(Vector3.Distance(entity_.transform.position, target) > 0.05f)
		{
			entity_.transform.position = Vector3.Lerp(entity_.transform.position, target, speed * Time.deltaTime);
			yield return null;
		}
	}
}


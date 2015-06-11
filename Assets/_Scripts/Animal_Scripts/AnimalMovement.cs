using UnityEngine;
using System.Collections;

public interface AnimalMovement{
	// Use this for initialization
	void move(AnimalController entity);
}

public class Run : AnimalMovement
{
	protected float speed;
	protected AnimalController entity_;
	Vector3 destination_;
	public Run(Vector3 destination)
	{
		destination_ = destination;
	}
	public void move(AnimalController entity)
	{
		entity_ = entity;
		speed = 0;
		entity_.StartCoroutine("Movement", destination_);
	}
	IEnumerator Movement (Vector3 target)
	{
		while(Vector3.Distance(entity_.transform.position, target) > 0.05f)
		{
			entity_.transform.position = Vector3.Lerp(entity_.transform.position, target, speed * Time.deltaTime);
			yield return null;
		}
	}
}


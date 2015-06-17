using UnityEngine;
using System.Collections;

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
		movement_ = new LerpedMovement (entity_,direction + entity_.transform.position);
	}
}
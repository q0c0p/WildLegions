using UnityEngine;
using System.Collections;

public class GoAwayFrom : AnimalAction
{
	private GameObject other_;
	private NavMeshAgent nav_;
	float distance_;
	
	public GoAwayFrom(GameObject entity, GameObject other , float distance)
	{
		entity_ = entity;
		other_ = other;
		distance_ = distance;
		nav_ = entity_.GetComponent<NavMeshAgent> ();
		startAction ();
	}
	public GoAwayFrom(GameObject entity,GameObject other)
	{
		entity_ = entity;
		other_ = other;
		distance_ = 10f;
		nav_ = entity_.GetComponent<NavMeshAgent> ();
		startAction ();
	}
	private void startAction()
	{
		/* A movement to the opposite of the other game object */
		MonoBehaviour.print ("You scaring me");
		Vector3 direction = entity_.transform.position - other_.transform.position;
		direction = direction.normalized * distance_;
		nav_.SetDestination(direction);
	}
	public override bool sameAs(AnimalAction action)
	{
		if (action is GoAwayFrom)
			return true;
		return false;
	}
}
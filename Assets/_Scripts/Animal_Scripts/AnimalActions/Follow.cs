using UnityEngine;
using System.Collections;

public class Follow : AnimalAction
{
	private GameObject other_;
	private Vector3 target_;
	private NavMeshAgent nav_;

	public Follow (GameObject entity, GameObject other)
	{
		entity_ = entity;
		other_ = other;
		target_ = other_.transform.position;
		nav_ = entity_.GetComponent<NavMeshAgent>();
		MonoBehaviour.print ("I follow you my master!");
		startAction ();
	}
	public override void playAction()
	{
		if(Vector3.Distance(other_.transform.position, target_) > 1)
		{
			target_ = other_.transform.position;
			startAction ();
		}
		if (Vector3.Distance (entity_.transform.position, target_) < 4) {
			nav_.Stop();
		}
	}
	public void startAction()
	{
		nav_.SetDestination (other_.transform.position);
	}
	public override bool sameAs(AnimalAction action)
	{
		if (action is Follow)
			return true;
		return false;
	}
}
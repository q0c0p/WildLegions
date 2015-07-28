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
		if(other_.transform.position != target_)
		{
			target_ = other_.transform.position;
			startAction ();
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
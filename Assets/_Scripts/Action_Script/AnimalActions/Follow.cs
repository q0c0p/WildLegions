using UnityEngine;
using System.Collections;

public class Follow : AnimalAction
{
	private GameObject other_;
	private Vector3 target_;

	public Follow (GameObject entity, GameObject other)
	{
		entity_ = entity;
		other_ = other;
		target_ = other_.transform.position;
		startAction ();
	}
	public override void playAction()
	{
		if(other_.transform.position != target_)
		{
			target_ = other_.transform.position;
			startAction ();
		}
		if( !movement_.isFinished())
			movement_.move ();
	}
	public void startAction()
	{
		movement_ = new LinearMovement (entity_,target_);
		movement_.setEpsilon (5f);
	}
}
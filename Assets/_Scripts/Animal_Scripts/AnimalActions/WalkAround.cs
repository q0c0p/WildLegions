using UnityEngine;
using System.Collections;

public class WalkAround : AnimalAction
{
	public WalkAround (GameObject entity)
	{
		entity_ = entity;
		startAction();
	}
	public override void playAction()
	{
		if (movement_ != null) {
			if(!movement_.isFinished())
				movement_.move ();
			else
				startAction();
		}

	}
	private void startAction()
	{
		Vector3 gotoSomewhere = entity_.transform.position + Random.insideUnitSphere * 20;
		gotoSomewhere.y = 0;
		movement_ = new LinearMovement (entity_, gotoSomewhere);
	}
	
}
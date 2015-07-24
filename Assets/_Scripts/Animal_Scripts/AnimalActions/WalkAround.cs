using UnityEngine;
using System.Collections;

public class WalkAround : AnimalAction
{
	public float coef_ = 2;
	private NavMeshAgent nav_;

	public WalkAround (GameObject entity)
	{
		entity_ = entity;
		nav_ = entity_.GetComponent<NavMeshAgent> ();
		startAction();
	}
	public override void playAction()
	{
	}
	private void startAction()
	{
		Vector3 gotoSomewhere = entity_.transform.position + Random.insideUnitSphere * coef_;
		gotoSomewhere.y = 0;
		nav_.SetDestination (gotoSomewhere);
	}
	
}
using UnityEngine;
using System.Collections;

public class WalkAround : AnimalAction
{
	private float coef_ = 20;
	private NavMeshAgent nav_;
	private NpcAnimationAdapter anim_;
	private Vector3 gotoSomewhere_;

	public WalkAround (GameObject entity)
	{
		entity_ = entity;
		nav_ = entity_.GetComponent<NavMeshAgent> ();

		anim_ = entity_.GetComponent<AnimalController> ().anim_;
		startAction();
	}
	public override void playAction()
	{
		if (Vector3.Distance (gotoSomewhere_, entity_.transform.position) < 0.5)
			startAction ();
	}

	public void setCoef(float coef)
	{
		coef_ = coef;
	}

	private void startAction()
	{
		Vector3 gotoSomewhere = entity_.transform.position + Random.insideUnitSphere * coef_;
		gotoSomewhere.y = 0;
		gotoSomewhere_ = gotoSomewhere;
		nav_.SetDestination (gotoSomewhere);
		anim_.Walk (true);
	}

	public override bool sameAs(AnimalAction action)
	{
		if (action is WalkAround)
			return true;
		return false;
	}
	
}
using UnityEngine;
using System.Collections;

public class WalkAround : AnimalAction
{
	private float coef_ = 20;
	private NavMeshAgent nav_;
	private NpcAnimationAdapter anim_;

	public WalkAround (GameObject entity)
	{
		entity_ = entity;
		nav_ = entity_.GetComponent<NavMeshAgent> ();

		anim_ = entity_.GetComponent<AnimalController> ().anim_;
		MonoBehaviour.print ( anim_);
		startAction();
	}
	public override void playAction()
	{
	}

	public void setCoef(float coef)
	{
		coef_ = coef;
	}

	private void startAction()
	{
		MonoBehaviour.print ("I walk around");
		Vector3 gotoSomewhere = entity_.transform.position + Random.insideUnitSphere * coef_;
		gotoSomewhere.y = 0;
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
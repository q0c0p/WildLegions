using UnityEngine;
using System.Collections;

public class LookFor : AnimalAction {

	WalkAround action_;

	public LookFor(GameObject entity)
	{
		entity_ = entity;
		startAction ();
	}
	private void startAction()
	{
		action_ = new WalkAround (entity_);
		action_.coef_ = 20;
	}
	public override void playAction()
	{

		action_.playAction ();
	}
	
}

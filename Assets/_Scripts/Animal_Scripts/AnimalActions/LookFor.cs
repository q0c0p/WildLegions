using UnityEngine;
using System.Collections;

public class LookFor : AnimalAction {

	WalkAround action_;

	public LookFor(GameObject entity, string tag)
	{
		entity_ = entity;
		entity_.GetComponentInChildren<ExternalPerception> ().setInterestTag (tag);
		startAction ();
	}
	public LookFor(GameObject entity, GameObject other)
	{
		entity_ = entity;
		entity_.GetComponentInChildren<ExternalPerception> ().setInterestGO (other);
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

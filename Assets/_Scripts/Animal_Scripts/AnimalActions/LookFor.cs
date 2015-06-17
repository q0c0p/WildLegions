using UnityEngine;
using System.Collections;

public class LookFor : AnimalAction {

	WalkAround action_;

	public LookFor(GameObject entity, string tag)
	{
		entity_ = entity;
		entity_.GetComponentInChildren<ExternalPerception> ().setInterestTag (tag);
		action_ = new WalkAround (entity);
	}
	public LookFor(GameObject entity, GameObject other)
	{
		entity_ = entity;
		entity_.GetComponentInChildren<ExternalPerception> ().setInterestGO (other);
		action_ = new WalkAround (entity);
	}
	public override void playAction()
	{
		action_.playAction ();
	}
	
}

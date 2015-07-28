using UnityEngine;
using System.Collections;

public class LookFor : AnimalAction {

	WalkAround action_;
	GameObject interestGO_;
	string interestString_;

	public LookFor(GameObject entity, GameObject interest)
	{
		interestGO_ = interest;
		entity_ = entity;
		entity_.GetComponentInChildren<ExternalPerception>().setInterestGO(interestGO_);
		startAction ();
	}
	public LookFor(GameObject entity, string interest)
	{
		interestString_ = interest;
		entity_ = entity;
		entity_.GetComponentInChildren<ExternalPerception>().setInterestTag(interestString_);
		startAction ();
	}
	private void startAction()
	{
		MonoBehaviour.print ("I start looking for");
		action_ = new WalkAround (entity_);
		action_.setCoef(8);
	}
	public override void playAction()
	{
		action_.playAction ();
	}
	public override bool sameAs(AnimalAction action)
	{
		if (action is LookFor)
			return true;
		return false;
	}
}

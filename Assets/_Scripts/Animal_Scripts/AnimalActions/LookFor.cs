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
		startAction ();
	}
	public LookFor(GameObject entity, string interest)
	{
		interestString_ = interest;
		entity_ = entity;
		startAction ();
	}
	private void startAction()
	{
		MonoBehaviour.print ("I start looking for");
		action_ = new WalkAround (entity_);
		action_.coef_ = 20;
	}
	public override void playAction()
	{
		action_.playAction ();
	}
	
}

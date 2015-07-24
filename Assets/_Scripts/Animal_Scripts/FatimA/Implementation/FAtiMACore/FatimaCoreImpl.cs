using UnityEngine;
using System.Collections;

public class FatimaCoreImpl : FatimaCoreAbstract {
	private GameObject entity_;
	public FatimaCoreImpl(GameObject entity)
	{
		entity_ = entity;
		addAppraisalComponent (new MotivationalComponent());
		addAffectDerivationComponent (new AffectDerivationComponentImpl());
	}
	protected override Action actionSelection ()
	{
		MonoBehaviour.print ("it is time to choose an action");
		return new WalkAround (entity_);
	}
	protected override Fatima.AppraisalFrame newAppraisalFrame(FatimaEvent pevent)
	{
		return new AppraisalFrameImpl(pevent);
	}
}

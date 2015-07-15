using UnityEngine;
using System.Collections;

public class FatimaCoreImpl : FatimaCoreAbstract {
	public FatimaCoreImpl()
	{
		addAppraisalComponent (new MotivationalComponent());
	}
	protected override Action actionSelection ()
	{
		throw new System.NotImplementedException ();
	}
	protected override Fatima.AppraisalFrame newAppraisalFrame()
	{
		return new AppraisalFrameImpl();
	}

}

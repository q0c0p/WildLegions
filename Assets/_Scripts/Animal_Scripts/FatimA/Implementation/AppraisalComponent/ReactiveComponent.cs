using UnityEngine;
using System.Collections;


/**
 * This component is responsible of the threaten events
 * it will then generate some fear 
 * */
public class ReactiveComponent : AppraisalComponentAbstarct {


	public ReactiveComponent()
	{
	}
	public override void startAppraisal(FatimaEvent pevent, Fatima.AppraisalFrame aF)
	{
		if (pevent is ThreatEvent) {
			aF.add (new Desirability (-8));
			aF.add (new Like(-5));
			setAppraisalFrame(aF);
		}
	}
}

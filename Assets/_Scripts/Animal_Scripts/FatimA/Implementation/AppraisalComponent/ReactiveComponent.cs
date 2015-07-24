using UnityEngine;
using System.Collections;


/**
 * This component is responsible of the threaten events
 * it will then generate some fear 
 * */
public class ReactiveComponent : Fatima.AppraisalComponent {

	private Fatima.AppraisalFrame appraisalFrame_;

	public ReactiveComponent()
	{
	}
	public void update()
	{	
	}
	public void update(FatimaEvent pevent)
	{
		
	}
	public void startAppraisal(FatimaEvent pevent, Fatima.AppraisalFrame aF)
	{
		if (pevent is ThreatEvent) {
			appraisalFrame_ = aF;
			appraisalFrame_.add (new Desirability (-8));
			appraisalFrame_.add (new Like(-5));
		}
	}
	public Fatima.AppraisalFrame continuousAppraisal()
	{
		return null;
	}
}

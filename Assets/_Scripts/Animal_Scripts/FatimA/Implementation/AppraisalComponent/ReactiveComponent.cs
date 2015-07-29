using UnityEngine;
using System.Collections;
using System;


/**
 * This component is responsible of the threaten events
 * it will then generate some fear 
 * */
public class ReactiveComponent : AppraisalComponentAbstract {


	public override void update()
	{
		Fatima.AppraisalVariable tmpAppRemove = null;
		Fatima.AppraisalVariable tmpAppNew = null;
		if (getAppraisalFrame () != null) {
			foreach (Fatima.AppraisalVariable appVariable in getAppraisalFrame().getFrameContent()) 
			{
				if (appVariable is Like) {
					tmpAppRemove = appVariable;
					if(Math.Abs(appVariable.getValue())>=1)
					{
						if (appVariable.getValue () > 0) {
							tmpAppNew = new Like(appVariable.getValue () - 10*Time.deltaTime);
						} else {
							tmpAppNew = new Like(appVariable.getValue () + 10*Time.deltaTime);
						}
					}
				}
			}
			if(tmpAppRemove != null)
			{
				getAppraisalFrame().getFrameContent().Remove(tmpAppRemove);
				if(tmpAppNew != null)
				{
					getAppraisalFrame().add(tmpAppNew);
				}
			}

		}
	}
	public ReactiveComponent()
	{
	}
	public override void startAppraisal(FatimaEvent pevent, Fatima.AppraisalFrame aF)
	{
		if (pevent is ThreatEvent) {
			aF.add (new Like(-9));
			setAppraisalFrame(aF);
		}
	}
}

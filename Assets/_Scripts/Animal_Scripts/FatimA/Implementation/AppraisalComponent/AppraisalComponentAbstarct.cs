﻿using UnityEngine;
using System.Collections;

public abstract class AppraisalComponentAbstarct : Fatima.AppraisalComponent {

	private Fatima.AppraisalFrame appraisalFrame_;

	protected void setAppraisalFrame(Fatima.AppraisalFrame pappraisalFrame)
	{
		appraisalFrame_ = pappraisalFrame;
	}
	protected Fatima.AppraisalFrame getAppraisalFrame()
	{
		return appraisalFrame_;
	}

	public AppraisalComponentAbstarct()
	{
	}

	public void update()
	{	
	}
	public void update(FatimaEvent pevent)
	{
		
	}

	public abstract void startAppraisal (FatimaEvent pevent, Fatima.AppraisalFrame aF);

	public Fatima.AppraisalFrame continuousAppraisal()
	{
		return appraisalFrame_;
	}
}

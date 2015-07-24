﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fatima;

/**
 * This component models the basic agent's drives (=needs) such as energy, health... 
 * When updated by an event, it evaluates its desirability (does it increases or decreases a need) (appraisal variable) 
 * and sends it to the current appraisal frame. 
 * */

public class MotivationalComponent : AppraisalComponent {

	private Fatima.AppraisalFrame appraisalFrame_;
	
	public MotivationalComponent()
	{
	}
	/**
	 * not yet implemented 
	 * this should update the hungriness
	 * */
	public void update()
	{
	}
	public void update(FatimaEvent pevent)
	{
	}
	/**
	 * here we gonna start the appraisal of an event and store the appraisal variables into a appraisal frame
	 * for this component we gonna make appraisal frame that treats the specials needs
	 * */
	public void startAppraisal(FatimaEvent pevent, AppraisalFrame aF)
	{
		if (pevent is HungerEvent || pevent is TiredEvent) {
			appraisalFrame_ = aF;
			appraisalFrame_.add (new Desirability (4));
		}
	}

	public AppraisalFrame continuousAppraisal()
	{
		return appraisalFrame_;
	}	
}

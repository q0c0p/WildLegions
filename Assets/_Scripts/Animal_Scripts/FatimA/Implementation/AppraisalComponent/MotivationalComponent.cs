using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fatima;

/**
 * This component models the basic agent's drives (=needs) such as energy, health... 
 * When updated by an event, it evaluates its desirability (does it increases or decreases a need) (appraisal variable) 
 * and sends it to the current appraisal frame. 
 * */

public class MotivationalComponent : AppraisalComponentAbstarct {

	public MotivationalComponent()
	{
	}

	/**
	 * here we gonna start the appraisal of an event and store the appraisal variables into a appraisal frame
	 * for this component we gonna make appraisal frame that treats the specials needs
	 * */
	public override void startAppraisal(FatimaEvent pevent, AppraisalFrame aF)
	{
		if (pevent is HungerEvent || pevent is TiredEvent) {
			aF.add (new Desirability (4));
			setAppraisalFrame(aF);
		}
	}
}

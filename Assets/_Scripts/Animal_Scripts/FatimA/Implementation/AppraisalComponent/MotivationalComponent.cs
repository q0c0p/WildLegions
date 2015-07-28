using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fatima;

/**
 * This component models the basic agent's drives (=needs) such as energy, health... 
 * When updated by an event, it evaluates its desirability (does it increases or decreases a need) (appraisal variable) 
 * and sends it to the current appraisal frame. 
 * */

public class MotivationalComponent : AppraisalComponentAbstract {

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
		else if(pevent is StarvingEvent)
		{
			aF.add (new Desirability (6));
			setAppraisalFrame(aF);
		}
		else if(pevent is FindSmthEvent)
		{
			// really high value to lead him to the food 
			aF.add (new GoalConduciveness(8));
			aF.add (new Desirability (4));
			setAppraisalFrame(aF);
		}
		else if(pevent is GetFoodEvent)
		{
			aF.add(new GoalSuccess(10));
			setAppraisalFrame(aF);
		}
	}
}

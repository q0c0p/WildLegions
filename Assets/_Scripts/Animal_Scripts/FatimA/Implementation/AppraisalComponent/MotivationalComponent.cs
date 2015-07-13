using UnityEngine;
using System.Collections;
using Fatima;

/**
 * This component models the basic agent's drives (=needs) such as energy, health... 
 * When updated by an event, it evaluates its desirability (does it increases or decreases a need) (appraisal variable) 
 * and sends it to the current appraisal frame. 
 * */
public class MotivationalComponent : AppraisalComponent {

	private AppraisalVariable desirability_;

	MotivationalComponent()
	{
	}
	public void update()
	{

	}
	public void update(FatimaEvent pevent)
	{

	}
	public void startAppraisal(FatimaEvent evenement, AppraisalFrame aF)
	{

	}
	public AppraisalFrame continuousAppraisal()
	{
		return null;
	}
}

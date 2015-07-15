using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fatima;

/**
 * This component models the basic agent's drives (=needs) such as energy, health... 
 * When updated by an event, it evaluates its desirability (does it increases or decreases a need) (appraisal variable) 
 * and sends it to the current appraisal frame. 
 * */

public class MotivationalComponent : AppraisalComponent {

	private AppraisalVariable desirability_;
	private List<AppraisalFrame> appraisalFrame_ = new List<AppraisalFrame>();
	
	public MotivationalComponent()
	{
	}
	/**
	 * not yet implemented 
	 * this should 
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
	public void startAppraisal(FatimaEvent evenement, AppraisalFrame aF)
	{
		eventNeedManager (evenement);
	}
	public AppraisalFrame continuousAppraisal()
	{
		return null;
	}


	/**
	 * This function deals with the caracteristic of an event 
	 * */
	private void eventNeedManager(FatimaEvent pevent)
	{
		if(pevent is HungerEvent)
			MonoBehaviour.print ("coucou je suis un event hunger");
		else if(pevent is TiredEvent)
			MonoBehaviour.print ("coucou je suis un event Tired");
	}
}

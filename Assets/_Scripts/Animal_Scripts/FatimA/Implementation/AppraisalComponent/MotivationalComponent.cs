using UnityEngine;
using System.Collections;
using Fatima;

/**
 * This component models the basic agent's drives (=needs) such as energy, health... 
 * When updated by an event, it evaluates its desirability (appraisal varible) and sends it to the current appraisal frame. 
 * */
public class MotivationalComponent : AppraisalComponent {

	private AppraisalVariable desirability_;

	void update();
	void update(FatimaEvent pevent);
	void startAppraisal(FatimaEvent evenement, AppraisalFrame aF);
	AppraisalFrame continuousAppraisal();
}

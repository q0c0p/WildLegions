using System;
using UnityEngine;
using System.Collections;

public class DeliberativeComponent : BehaviorComponentAbstract
{
	private Fatima.Memory memory_;
	private Fatima.AffectiveState affectiveState_;
	private GameObject entity_;


	public DeliberativeComponent (Fatima.Memory pmemory, Fatima.AffectiveState paffectiveState, GameObject pentity)
	{
		memory_ = pmemory;
		affectiveState_ = paffectiveState;
		entity_ = pentity;
	}


	/**
	 * This implementation is a component wich isn't really personnal it affect an action with regard to 
	 * the affective state the greater emotion win of the moment and chek the memory to know when the event occurs
	 * After he put a Action and attribute a grade for the action selection 
	 * */

	public override void actionSelection ()
	{
		float value = 3; /// the animal will react if the value is more than 3
		Fatima.Emotion tmpEmotion = null;
		foreach(Fatima.Emotion emotion in affectiveState_.getEmotionalSet())
			if(Math.Abs(emotion.getIntensity()) >= value)
			{
				tmpEmotion = emotion;
				value = Math.Abs(emotion.getIntensity());
			}
		if (tmpEmotion == null) {
			setAction(new WalkAround(entity_));
			setValue(3);
		}
		if (tmpEmotion is Fear) {
			setAction(new GoAwayFrom(entity_,tmpEmotion.getAppraisalFrame().getEvent().getWhoGO()));
			setValue(tmpEmotion.getIntensity());
		}
		else if (tmpEmotion is Hate) {
			setAction(new Attack(entity_,tmpEmotion.getAppraisalFrame().getEvent().getWhoGO()));
			setValue(tmpEmotion.getIntensity());
		}
		else if (tmpEmotion is Interest) {

			if(tmpEmotion.getAppraisalFrame().getEvent() is HungerEvent)
			{
				setAction(new LookFor(entity_,"Food"));
				setValue(tmpEmotion.getIntensity());
			}
			else if (tmpEmotion.getAppraisalFrame().getEvent() is TiredEvent)
			{
				///to be continued
			}
		}
		else if (tmpEmotion is Love) {
			setAction(new Follow(entity_,tmpEmotion.getAppraisalFrame().getEvent().getWhoGO()));
			setValue(tmpEmotion.getIntensity());
		}
		else if (tmpEmotion is Trust) {
			///to be continued
		}
	}
}



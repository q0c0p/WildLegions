using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
			return ;
		}
		if (tmpEmotion is Fear) {
			setAction (new GoAwayFrom (entity_, tmpEmotion.getAppraisalFrame ().getEvent ().getWhoGO ()));
			setValue (tmpEmotion.getIntensity ());
		} else if (tmpEmotion is Hate) {
			setAction (new Attack (entity_, tmpEmotion.getAppraisalFrame ().getEvent ().getWhoGO ()));
			setValue (tmpEmotion.getIntensity ());
		} else if (tmpEmotion is Interest) {

			if (tmpEmotion.getAppraisalFrame ().getEvent () is HungerEvent) {
				setAction (new LookFor (entity_, "Food"));
				setValue (tmpEmotion.getIntensity ());
			} else if (tmpEmotion.getAppraisalFrame ().getEvent () is TiredEvent) {
				///to be continued
			}
		} else if (tmpEmotion is Love) {
			setAction (new Follow (entity_, tmpEmotion.getAppraisalFrame ().getEvent ().getWhoGO ()));
			setValue (tmpEmotion.getIntensity ());
		} else if (tmpEmotion is Hope) {
			setAction (new GoToSmth (entity_, tmpEmotion.getAppraisalFrame().getEvent().getWhoGO()));
			setValue (tmpEmotion.getIntensity ());
		}else if (tmpEmotion is Satisfaction){
			if(tmpEmotion.getAppraisalFrame().getEvent() is GetFoodEvent)
			{
				setAction (new Eat (entity_, tmpEmotion.getAppraisalFrame ().getEvent ().getWhoGO ()));
				setValue (tmpEmotion.getIntensity ());
			}
			if(tmpEmotion.getAppraisalFrame().getEvent() is EatFoodEvent)
			{
				List<Fatima.Emotion> toRemove = new List<Fatima.Emotion>();
				foreach(Fatima.Emotion emotion in affectiveState_.getEmotionalSet())
				{
					if(emotion is Hope)
					{
						toRemove.Add(emotion);
					}
					if(emotion is Satisfaction)
					{
						if(emotion.getAppraisalFrame ().getEvent () is GetFoodEvent || 
						   emotion.getAppraisalFrame ().getEvent () is EatFoodEvent )
						{
							toRemove.Add(emotion);
						}
					}
					if(emotion is Interest)
					{
						if(emotion.getAppraisalFrame ().getEvent () is HungerEvent)
						{
							toRemove.Add(emotion);
						}
					}
				}
				toRemove.Add (tmpEmotion);
				foreach(Fatima.Emotion emotion in toRemove)
				{
					affectiveState_.getEmotionalSet().Remove(emotion);
				}
			}
		}
		else if (tmpEmotion is Trust) {
			///to be continued
		}
	}
}



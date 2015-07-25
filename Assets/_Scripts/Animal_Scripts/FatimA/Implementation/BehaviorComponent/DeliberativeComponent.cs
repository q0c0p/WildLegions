using System;

public class DeliberativeComponent : BehaviorComponentAbstract
{
	private Fatima.Memory memory_;
	private Fatima.AffectiveState affectiveState_;


	public DeliberativeComponent (Fatima.Memory pmemory, Fatima.AffectiveState paffectiveState)
	{
		memory_ = pmemory;
		affectiveState_ = paffectiveState;
	}


	/**
	 * This implementation is a component wich isn't really personnal it affect an action with regard to 
	 * the affective state the greater emotion win of the moment and chek the memory to know when the event occurs
	 * After he put a Action and attribute a grade for the action selection 
	 * */

	public override void actionSelection ()
	{
		float value = 0;
		Fatima.Emotion tmpEmotion = null;
		foreach(Fatima.Emotion emotion in affectiveState_.getEmotionalSet())
			if(Math.Abs(emotion.getIntensity()) >= value)
			{
				tmpEmotion = emotion;
				value = Math.Abs(emotion.getIntensity());
			}
		if (tmpEmotion is Fear) {
		}
		else if (tmpEmotion is Hate) {
		}
		else if (tmpEmotion is Interest) {
		}
		else if (tmpEmotion is Love) {
		}
		else if (tmpEmotion is Trust) {
		}
	}
}



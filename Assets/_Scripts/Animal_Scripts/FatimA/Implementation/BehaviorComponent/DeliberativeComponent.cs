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
	 * This implementation is a component wich isn't really personnal it affect an action between 
	 * the affective state of the moment and chek the memory to know when the event occurs
	 * */
	public override void actionSelection ()
	{
		foreach(Fatima.Emotion emotion in affectiveState_.getEmotionalSet())
		{
			emotion.getAppraisalFrame().getFrameContent();
		}
	}
}



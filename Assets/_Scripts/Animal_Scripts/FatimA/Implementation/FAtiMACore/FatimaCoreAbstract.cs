using UnityEngine;
using System.Collections.Generic;

public abstract class FatimaCoreAbstract : Fatima.FatimaCore {

	protected Action action_; 	
	protected List<Fatima.AppraisalComponent> appraisalComponents_ = new List<Fatima.AppraisalComponent>();
	protected List<Fatima.BehaviorComponent> behaviorComponents_ = new List<Fatima.BehaviorComponent>();
	protected List<Fatima.AffectDerivationComponent> affectDerivationComponents_ = new List<Fatima.AffectDerivationComponent>(); 
	protected Fatima.AffectiveState affectiveState_ ;
	protected Fatima.Memory memory_ = new MemoryImpl();

	public void update()
	{
		fatimaPseudoCodeCore(null);
	}
	public void sendEvent(FatimaEvent pevent)
	{
		fatimaPseudoCodeCore(pevent);
	}
	public Action getAction()
	{
		return action_;
	}
	protected void addAppraisalComponent(Fatima.AppraisalComponent aC)
	{
		appraisalComponents_.Add (aC);
	}
	protected void addAffectDerivationComponent(Fatima.AffectDerivationComponent aD)
	{
		affectDerivationComponents_.Add (aD);
	}
	protected void addBehaviorComponent(Fatima.BehaviorComponent bC)
	{
		behaviorComponents_.Add (bC);
	}


	/**
	 * The Fatima pseudo code translate in C#
	 * */
	protected void fatimaPseudoCodeCore(FatimaEvent pevent)
	{
		updateComponents ();
		/* If a new event is perceived */
		if (pevent != null) {
			if(!memory_.isInMemory(pevent))
			{
				memory_.update(pevent);
				updateComponents(pevent);
				Fatima.AppraisalFrame aF = newAppraisalFrame(pevent);

				foreach(Fatima.AppraisalComponent aC in appraisalComponents_)
				{
					aC.startAppraisal(pevent, aF);
					updateEmotion(aF);
				}
			}
		}
		foreach(Fatima.AppraisalComponent aC in appraisalComponents_)
		{
			Fatima.AppraisalFrame aF = aC.continuousAppraisal();
			updateEmotion(aF);
		}
		foreach (Fatima.BehaviorComponent bC in behaviorComponents_) {
			bC.actionSelection();
		}
		action_ = actionSelection ();
	}

	/**
	 * The method which update emotion describe in the paper
	 * */

	protected void updateEmotion(Fatima.AppraisalFrame aF)
	{
		if (aF.hasChanged ()) {
			foreach(Fatima.AffectDerivationComponent aD in affectDerivationComponents_)
			{
				Fatima.Emotion emotionTmp = aD.affectDerivation(aF);
				affectiveState_.addEmotion(emotionTmp);
			}
		}
	}


	/**
	 * The method which select the action at the end of the responsability chain 
	 * you must override it when you implement FAtiMA
	 * */

	protected abstract Action actionSelection();

	/**
	 * The method which create a new appraisal frame
	 * you must override it when you implement FAtiMA
	 * */
	protected abstract Fatima.AppraisalFrame newAppraisalFrame (FatimaEvent pevent);


	/* update components */
	private void updateComponents()
	{
		foreach(Fatima.Component components in appraisalComponents_)
		{
			components.update();
		}
		foreach(Fatima.Component components in behaviorComponents_)
		{
			components.update();
		}
		foreach(Fatima.Component components in affectDerivationComponents_)
		{
			components.update();
		}
	}
	private void updateComponents(FatimaEvent pevent)
	{
		foreach(Fatima.Component components in appraisalComponents_)
		{
			components.update();
		}
		foreach(Fatima.Component components in behaviorComponents_)
		{
			components.update();
		}
		foreach(Fatima.Component components in affectDerivationComponents_)
		{
			components.update();
		}
	}

}

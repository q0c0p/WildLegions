using System;
using UnityEngine;
using System.Collections;


public class FatimaCoreImpl : FatimaCoreAbstract {
	private GameObject entity_;

	/**
	 * The constructor of the first implementation of Fatima 
	 * one Tip to be safe the order of initialisation
	 * first Affective state and Memory
	 * after the component because some of them may need the memory and the affective state to work
	 * */

	public FatimaCoreImpl(GameObject entity)
	{
		entity_ = entity;
		setAffectiveState (new AffectiveStateImpl());
		setMemory (new MemoryImpl ());
		addAppraisalComponent (new MotivationalComponent());
		addAffectDerivationComponent (new AffectDerivationComponentImpl());
		addBehaviorComponent (new DeliberativeComponent(getMemory(),getAffectiveState(),entity_) );
	}
	protected override Action actionSelection ()
	{
		float value = 0;
		Action tmpAction = null;
		foreach (Fatima.BehaviorComponent bc in getBehaviorComponent()) {
			if(value <= Math.Abs(bc.getValue()))
			{
				value = bc.getValue();
				tmpAction = bc.getAction();
			}
		}
		return tmpAction;
	}
	protected override Fatima.AppraisalFrame newAppraisalFrame(FatimaEvent pevent)
	{
		return new AppraisalFrameImpl(pevent);
	}


}

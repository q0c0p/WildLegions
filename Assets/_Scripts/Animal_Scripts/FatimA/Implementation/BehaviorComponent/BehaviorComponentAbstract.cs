using UnityEngine;
using System.Collections;

public abstract class BehaviorComponentAbstract : Fatima.BehaviorComponent {


	protected AnimalAction action_ = null;
	protected float valueOfAction = 0;

	public BehaviorComponentAbstract()
	{
	}
	/**
	 * not yet implemented 
	 * this should update the hungriness
	 * */
	public void update()
	{
	}
	/**
	 * not yet implemented 
	 * this should update the hungriness
	 * */
	public void update(FatimaEvent pevent)
	{
	}


	public abstract void actionSelection();

	public Action getAction()
	{
		return action_;
	}

	public float getValue()
	{
		return valueOfAction;
	}

	protected void setAction(AnimalAction paction)
	{
		action_ = paction;
	}
	
	protected void setValue(float pvalue)
	{
		valueOfAction = pvalue;
	}
	
}

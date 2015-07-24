using UnityEngine;
using System.Collections;

public abstract class BehaviorComponentAbstract : Fatima.BehaviorComponent {



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
	
}

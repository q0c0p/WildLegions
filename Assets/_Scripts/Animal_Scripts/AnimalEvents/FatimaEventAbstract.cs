using UnityEngine;
using System.Collections;
/**
 * This is the abstract implementation of event it is usefull to make it because we need 
 * to have some precision about the event for now the unique identifier
 * */
public abstract class FatimaEventAbstract : FatimaEvent
{
	static long autoIncId;
	private long id_;
	private GameObject goTrigger_;

	/**
	 * we use it into the FatimaEvent to reference a unique id for an event
	 * */

	protected FatimaEventAbstract ()
	{
		autoIncId++;
		id_ = autoIncId;
	}

	/**
	 * This method returns the unique identifier 
	 * */

	public long getId()
	{
		return id_;
	}
	
	
	/**
	 * This method is use to return a GameObject of object that trigger the event
	 * */

	public GameObject getWhoGO()
	{
		return goTrigger_;
	}

	/**
	 * this method set the GameObject that trigger the event
	 * */

	protected void setWhoGO(GameObject pGo)
	{
		goTrigger_ = pGo;
	}
}


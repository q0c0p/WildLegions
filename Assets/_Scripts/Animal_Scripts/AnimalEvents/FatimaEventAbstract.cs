
using System;
/**
 * This is the abstract implementation of event it is usefull to make it because we need 
 * to have some precision about the event for now the unique identifier
 * */
public abstract class FatimaEventAbstract : FatimaEvent
{
	static long autoIncId;
	private long id_;
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
}


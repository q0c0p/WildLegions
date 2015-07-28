using UnityEngine;
using System.Collections;

public abstract class AnimalAction : Action
{
	
	protected GameObject entity_;
	static long autoIncId;
	private long id_;
	public void setId()
	{
		autoIncId++;
		id_ = autoIncId;
	}
	public FatimaEvent getEvent()
	{
		return null;
	}

	public virtual void playAction()
	{
	}

	public virtual void stopAction()
	{
		
	}
	public long getId()
	{
		return id_;
	}
	public virtual bool sameAs(AnimalAction action)
	{
		return false;
	}
}







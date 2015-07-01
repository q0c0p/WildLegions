using UnityEngine;
using System.Collections;

public abstract class AnimalAction : IAgentAction
{
	
	protected GameObject entity_;
	protected IMovement movement_;
	static long autoIncId;
	private long id_;
	public void setId()
	{
		autoIncId++;
		id_ = autoIncId;
	}

	public virtual void playAction()
	{
		/*
		if (movement_ != null) {
			if (!movement_.isFinished ())
				movement_.move ();
			else
				movement_ = null;
		}
		*/
	}

	public virtual IPerception isPerceived()
	{
		return null;
	}
	public virtual void stopAction()
	{
		
	}
	public IMovement getMovement()
	{
		return movement_;
	}
	public long getId()
	{
		return id_;
	}
}







using UnityEngine;
using System.Collections;

public abstract class AnimalAction : IAgentAction
{
	
	protected GameObject entity_;
	protected IMovement movement_;
	
	public virtual void playAction()
	{
		if (movement_ != null) {
			if (!movement_.isFinished ())
				movement_.move ();
			else
				movement_ = null;
		}
	}
	public virtual void stopAction()
	{
		
	}
	public IMovement getMovement()
	{
		return movement_;
	}
}







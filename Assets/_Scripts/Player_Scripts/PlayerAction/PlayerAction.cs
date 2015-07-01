using UnityEngine;
using System.Collections;

public abstract class PlayerAction : IAgentAction {
	static long autoIncId;
	private long id_;
	public void setId()
	{
		autoIncId++;
		id_ = autoIncId;
	}
	public void playAction()
	{
	}
	public void stopAction()
	{
	}
	public virtual IPerception isPerceived()
	{
		return null;
	}
	public IMovement getMovement()
	{
		return null;
	}
	public long getId()
	{
		return id_;
	}
}

public class PlayerAttack : PlayerAction
{
	public PlayerAttack()
	{
		setId ();
	}
	public override IPerception isPerceived()
	{
		return null;
	}
}

public class PlayerFeed : PlayerAction
{
	public PlayerFeed()
	{
		setId ();
	}
	public override IPerception isPerceived()
	{
		return null;
	}
}


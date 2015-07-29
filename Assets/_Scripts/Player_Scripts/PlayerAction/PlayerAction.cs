using UnityEngine;
using System.Collections;

public abstract class PlayerAction : Action {
	static long autoIncId;
	private long id_;
	protected FatimaEvent event_;
	protected GameObject go_;
	public PlayerAction(GameObject pgo)
	{
		go_ = pgo;
		setId ();
	}
	public void setId()
	{
		autoIncId++;
		id_ = autoIncId;
	}
	public virtual void playAction()
	{
	}
	public virtual void stopAction()
	{
	}
	public virtual FatimaEvent getEvent()
	{
		return event_;
	}
	public virtual long getId()
	{
		return id_;
	}
}






using UnityEngine;
using System.Collections;

public abstract class PlayerAction : Action {
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
	public FatimaEvent getEvent()
	{
		return null;
	}
	public long getId()
	{
		return id_;
	}
}






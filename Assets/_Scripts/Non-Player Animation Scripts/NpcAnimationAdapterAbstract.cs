using UnityEngine;
using System.Collections;

public abstract class NpcAnimationAdapterAbstract : NpcAnimationAdapter {
	
	protected GameObject entity_;

	public NpcAnimationAdapterAbstract(GameObject entity)
	{
		entity_ = entity;
	}

	public virtual void Walk(bool isWalking) {}
	public virtual void Run(bool isRunnig){}
	public virtual void Jump(){}
	public virtual void Idle(bool isIdle){}
	public virtual void Eat(){}
	public virtual void Attack(){}
	public virtual void Scream(){}
	public virtual void Dance(bool isDancing){}
	public virtual void Sleep(bool isSleeping){}

}

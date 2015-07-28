using UnityEngine;
using System.Collections;

public class KittenAnimationAdapterImpl : NpcAnimationAdapterAbstract  {

	Animator anim;

	public KittenAnimationAdapterImpl(GameObject entity) : base(entity)
	{
		anim = entity_.GetComponent<Animator> ();
	}

	public override void Walk(bool isWalking) {
		anim.SetBool ("isWalking", isWalking);
	}
	public override void Run(bool isRunning){
		anim.SetBool ("isRunning", isRunning);
	}
	public override void Jump(){
		anim.SetTrigger ("jumps");
	}
	public override void Idle(bool isIdle){
		anim.SetBool ("isIdle", isIdle);
	}
	public override void Scream(){
		anim.SetTrigger ("meows");
	}
}

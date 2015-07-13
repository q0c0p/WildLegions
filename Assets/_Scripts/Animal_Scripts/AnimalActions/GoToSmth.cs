using UnityEngine;
using System.Collections;

public class GoToSmth : AnimalAction {

	GameObject other_;
	AnimalAction current_;

	public GoToSmth(GameObject entity, GameObject other)
	{
		entity_ = entity;
		other_ = other;
		current_ = new Follow (entity,other);
	}
	public override void playAction ()
	{
		current_.playAction ();
	}
}

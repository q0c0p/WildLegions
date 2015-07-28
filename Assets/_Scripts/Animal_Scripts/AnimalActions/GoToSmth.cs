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
		MonoBehaviour.print ("I go to someone");
	}
	public override void playAction ()
	{
		current_.playAction ();
	}
	public override bool sameAs(AnimalAction action)
	{
		if (action is GoToSmth)
			return true;
		return false;
	}
}

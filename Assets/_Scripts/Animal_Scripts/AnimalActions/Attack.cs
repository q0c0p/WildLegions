using UnityEngine;
using System.Collections;

public class Attack : AnimalAction
{
	private GameObject other_;
	public Attack (GameObject entity,GameObject other)
	{
		other_ = other;
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("Attack!");
	}
	public override bool sameAs(AnimalAction action)
	{
		if (action is Attack)
			return true;
		return false;
	}

}
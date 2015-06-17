using UnityEngine;
using System.Collections;

public class Attack : AnimalAction
{
	public Attack (GameObject entity)
	{
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("Attack!");
	}
}
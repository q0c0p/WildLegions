using UnityEngine;
using System.Collections;

public class WalkAround : AnimalAction
{
	public WalkAround (GameObject entity)
	{
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("I walk around");
	}
	
}
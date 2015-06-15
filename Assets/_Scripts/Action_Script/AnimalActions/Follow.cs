using UnityEngine;
using System.Collections;

public class Follow : AnimalAction
{
	public Follow (GameObject entity, GameObject other)
	{
		entity_ = entity;
	}
	public override void playAction()
	{
		MonoBehaviour.print ("I follow my master !");
	}
	
}
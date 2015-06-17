using UnityEngine;
using System.Collections;

public class Eat : AnimalAction
{
	public Eat (GameObject entity)
	{ 
		entity_ = entity;
	}
	
	public override void playAction()
	{
		MonoBehaviour.print ("I eat !");
	}
}


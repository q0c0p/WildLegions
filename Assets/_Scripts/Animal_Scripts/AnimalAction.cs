using UnityEngine;
using System.Collections;

public interface AnimalAction {
	void playAction(AnimalController entity, GameObject other);
}
public class Eat : AnimalAction
{
	public void playAction(AnimalController entity, GameObject other)
	{
		MonoBehaviour.print ("I eat !"+entity.animalName);
	}
}
public class Attack : AnimalAction
{
	public void playAction(AnimalController entity, GameObject other)
	{
		MonoBehaviour.print ("Attack!");
	}
}
public class Follow : AnimalAction
{
	public void playAction(AnimalController entity, GameObject other)
	{
		MonoBehaviour.print ("I follow my master !");
	}
}
public class WalkAround : AnimalAction
{
	public void playAction(AnimalController entity, GameObject other)
	{
		MonoBehaviour.print ("I walk around");
	}
}


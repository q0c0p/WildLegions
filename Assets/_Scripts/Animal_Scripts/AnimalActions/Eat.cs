using UnityEngine;
using System.Collections;

public class Eat : AnimalAction
{
	GameObject food_;
	public Eat (GameObject entity, GameObject food)
	{ 
		entity_ = entity;
		food_ = food;
		playAction ();
	}
	
	public override void playAction()
	{
		MonoBehaviour.print ("I eat !");
		if (food_ != null) {
			entity_.GetComponent<Hungriness> ().globalHunger_ = 100f;
			food_.SetActive(false);
			MonoBehaviour.Destroy (food_);
			food_ = null;
		}

	}
	public override bool sameAs(AnimalAction action)
	{
		if (action is Attack)
			return true;
		return false;
	}
}


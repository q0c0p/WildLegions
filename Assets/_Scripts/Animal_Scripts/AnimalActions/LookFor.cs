using UnityEngine;
using System.Collections;

public class LookFor : AnimalAction {

	GameObject other_;
	string tag_;

	public LookFor(GameObject entity, string tag)
	{
		entity_ = entity;
		tag_ = tag;
		other_ = null;
	}
	public LookFor(GameObject entity, GameObject other)
	{
		entity_ = entity;
		other_ = other;
		tag_ = null;
	}
	
}

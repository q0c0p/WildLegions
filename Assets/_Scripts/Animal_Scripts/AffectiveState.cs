﻿using UnityEngine;
using System.Collections;

public class AffectiveState : MonoBehaviour {
	private float anger;
	private float love;
	private float fear;
	public AffectiveState(float panger, float plove, float pfear)
	{
		love = plove;
		fear = pfear;
		anger = panger;
	}

	public void update(IPerception perception)
	{
		anger+=perception.getAnger ();
		love+=perception.getLove ();
		fear+=perception.getFear ();
	}
	public float getLove()
	{
		return love;
	}
	public float getFear()
	{
		return fear;
	}
	public float getAnger()
	{
		return anger;
	}
}

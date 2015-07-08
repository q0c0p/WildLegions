using UnityEngine;
using System.Collections;

public class PerceptionImpl : IPerception {
	private float love;
	private float fear;
	private float anger;
	public PerceptionImpl(float plove, float pfear,float panger)
	{
		love = plove;
		fear = pfear;
		anger = panger;
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

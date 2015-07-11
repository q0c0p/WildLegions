using UnityEngine;
using System.Collections;

public class AffectiveState {
	private float anger;
	private float love;
	private float fear;

	public AffectiveState()
	{
		love = 0;
		fear = 0;
		anger = 0;
	}

	public AffectiveState(float panger, float plove, float pfear)
	{
		love = plove;
		fear = pfear;
		anger = panger;
		limitValues ();
	}

	private void limitValues()
	{
		if (anger < 0)
			anger = 0;
		if (anger > 10)
			anger = 10;
		if (love < 0)
			love = 0;
		if (love > 10)
			love = 10;
		if (fear < 0)
			fear = 0;
		if (fear > 10)
			fear = 10;
	}

	public void update(IPerception perception)
	{
		anger+=perception.getAnger ();
		love+=perception.getLove ();
		fear+=perception.getFear ();
		limitValues ();
	}
	public void copy(AffectiveState pcopy)
	{
		fear = pcopy.getFear ();
		anger = pcopy.getAnger ();
		love = pcopy.getLove ();
		limitValues ();
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

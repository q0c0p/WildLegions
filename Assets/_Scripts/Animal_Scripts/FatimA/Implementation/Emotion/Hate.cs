using UnityEngine;
using System.Collections;

public class Hate : EmotionAbstract {

	public Hate(float intensity, float valence, Fatima.AppraisalFrame appraisalFrame) : 
		base(intensity, valence, appraisalFrame)
	{
	}
	public override bool isDifferent(Fatima.Emotion pemotion)
	{
		if(pemotion is Hate)
			return false;
		return true;
	}
}

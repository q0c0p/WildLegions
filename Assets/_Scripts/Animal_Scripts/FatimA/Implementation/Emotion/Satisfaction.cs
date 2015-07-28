using UnityEngine;
using System.Collections;

public class Satisfaction : EmotionAbstract {
	public Satisfaction(float intensity, float valence, Fatima.AppraisalFrame appraisalFrame) : 
		base(intensity, valence, appraisalFrame)
	{
	}
	public override bool isDifferent(Fatima.Emotion pemotion)
	{
		if(pemotion is Satisfaction)
			return false;
		return true;
	}
}

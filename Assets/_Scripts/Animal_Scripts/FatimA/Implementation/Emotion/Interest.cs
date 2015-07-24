using UnityEngine;
using System.Collections;

public class Interest : EmotionAbstract {
	public Interest(float intensity, float valence, Fatima.AppraisalFrame appraisalFrame) : 
		base(intensity, valence, appraisalFrame)
	{
	}
	public override bool isDifferent(Fatima.Emotion pemotion)
	{
		if(pemotion is Interest)
			return false;
		return true;
	}
}

using UnityEngine;
using System.Collections;

public class Joy : EmotionAbstract {
	public Joy(float intensity, float valence, Fatima.AppraisalFrame appraisalFrame) : 
		base(intensity, valence, appraisalFrame)
	{
	}
	public override bool isDifferent(Fatima.Emotion pemotion)
	{
		if(pemotion is Joy)
			return false;
		return true;
	}
}

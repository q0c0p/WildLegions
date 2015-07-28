using UnityEngine;
using System.Collections;

public class Hope : EmotionAbstract {
	public Hope(float intensity, float valence, Fatima.AppraisalFrame appraisalFrame) : 
		base(intensity, valence, appraisalFrame)
	{
	}
	public override bool isDifferent(Fatima.Emotion pemotion)
	{
		if(pemotion is Hope)
			return false;
		return true;
	}

}

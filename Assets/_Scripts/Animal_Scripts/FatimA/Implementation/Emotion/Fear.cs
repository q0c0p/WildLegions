using UnityEngine;
using System.Collections;

public class Fear : EmotionAbstract {

	public Fear(float intensity, float valence, Fatima.AppraisalFrame appraisalFrame) : 
		base(intensity, valence, appraisalFrame)
	{
	}
	public override bool isDifferent(Fatima.Emotion pemotion)
	{
		if(pemotion is Fear)
			return false;
		return true;
	}
}

using UnityEngine;
using System.Collections;

public class Love : EmotionAbstract {
	public Love(float intensity, float valence, Fatima.AppraisalFrame appraisalFrame) : 
		base(intensity, valence, appraisalFrame)
	{
	}
	public override bool isDifferent(Fatima.Emotion pemotion)
	{
		if(pemotion is Love)
			return false;
		return true;
	}
}

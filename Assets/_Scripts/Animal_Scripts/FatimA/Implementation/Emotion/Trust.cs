using UnityEngine;
using System.Collections;

public class Trust : EmotionAbstract {

	public Trust(float intensity, float valence, Fatima.AppraisalFrame appraisalFrame) : 
		base(intensity, valence, appraisalFrame)
	{
	}
	public override bool isDifferent(Fatima.Emotion pemotion)
	{
		if(pemotion is Trust)
			return false;
		return true;
	}
}

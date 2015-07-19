using UnityEngine;
using System.Collections;

public class EmotionAbstract : MonoBehaviour {
	private float intensity_;
	private float valence_;
	private Fatima.AppraisalFrame appraisalFrame_;

	public EmotionAbstract(float pintensity, float pvalence, Fatima.AppraisalFrame pappraisalFrame)
	{
		intensity_ = pintensity;
		valence_ = pvalence;
		appraisalFrame_ = pappraisalFrame;
	}

	float getIntensity()
	{
		return intensity_;
	}
	float getValence()
	{
		return valence_;
	}
	Fatima.AppraisalFrame getAppraisalFrame()
	{
		return appraisalFrame_;
	}
}

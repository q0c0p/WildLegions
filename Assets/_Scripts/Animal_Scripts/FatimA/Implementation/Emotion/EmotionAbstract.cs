using UnityEngine;
using System.Collections;

public class EmotionAbstract : Fatima.Emotion {
	private float intensity_;
	private float valence_;
	private Fatima.AppraisalFrame appraisalFrame_;

	public EmotionAbstract(float pintensity, float pvalence, Fatima.AppraisalFrame pappraisalFrame)
	{
		intensity_ = pintensity;
		valence_ = pvalence;
		appraisalFrame_ = pappraisalFrame;
	}

	public float getIntensity()
	{
		return intensity_;
	}
	public float getValence()
	{
		return valence_;
	}
	public Fatima.AppraisalFrame getAppraisalFrame()
	{
		return appraisalFrame_;
	}
}

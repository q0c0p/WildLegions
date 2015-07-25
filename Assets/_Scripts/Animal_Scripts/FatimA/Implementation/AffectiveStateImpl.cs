using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AffectiveStateImpl : Fatima.AffectiveState {
	private List<Fatima.Emotion> emotionalSet = new List<Fatima.Emotion>();
	public AffectiveStateImpl()
	{
	}

	/**
	 * In this basic implementation you add an emotion if this emotion doesn't exist 
	 * If she exist you replace it 
	 * This implementation should evolve 
	 * */
	public void addEmotion(Fatima.Emotion pemotion)	
	{
		Fatima.Emotion emotionInList = null;
		foreach (Fatima.Emotion emotion in emotionalSet) 
			if(!pemotion.isDifferent(emotion))
				emotionInList = emotion;
		if (emotionInList != null)
			emotionalSet.Remove (emotionInList);
		emotionalSet.Add(pemotion);
	}
	/**
	 * You may also need to get the emotions that compose actually the affective state
	 * */
	public List<Fatima.Emotion> getEmotionalSet()
	{
		return emotionalSet;
	}
}

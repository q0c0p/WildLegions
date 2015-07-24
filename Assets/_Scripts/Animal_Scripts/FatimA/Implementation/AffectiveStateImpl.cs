using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AffectiveStateImpl : Fatima.AffectiveState {
	private List<Fatima.Emotion> emotionalSet = new List<Fatima.Emotion>();
	public AffectiveStateImpl()
	{
	}
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
}

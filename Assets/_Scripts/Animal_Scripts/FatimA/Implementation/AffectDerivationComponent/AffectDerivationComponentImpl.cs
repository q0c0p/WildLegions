using UnityEngine;
using System.Collections;
using System;



/**
 * This class is an implementation to derive emotions from appraisal.
 * This is a general class for a lambda person.
 * You can also make more specifics component like a goodAppraisal derivation or a more devils way }:>
 * */


public class AffectDerivationComponentImpl : Fatima.AffectDerivationComponent {

	/**
	 * This module is a basic implementation so there is no update to make 
	 */
	public void update()
	{
	}


	/**
	 * This module is a basic implementation so there is no update to make 
	 */
	public void update (FatimaEvent pevent)
	{
	} 

	public AffectDerivationComponentImpl()
	{

	}
	/**
	 * This implementation of the function is more a basic translation between 
	 * AppraisalVariables and Emotions but you can derive a more specific AffectDerivationComponent.
	 * */
	public Fatima.Emotion affectDerivation(Fatima.AppraisalFrame aF)
	{

		Fatima.AppraisalVariable currentAV = null;
		float maxValue=0;
		foreach (Fatima.AppraisalVariable av in aF.getFrameContent()) 
			if(Math.Abs(av.getValue()) >= maxValue)
			{
				maxValue = Math.Abs(av.getValue());
				currentAV = av;
			}
		
		if (currentAV is Desirability) {
			MonoBehaviour.print ("I want something");
			return new Interest(currentAV.getValue(), currentAV.getValue(),aF);
		}
		return null;
	}
}

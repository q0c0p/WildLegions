using UnityEngine;
using System.Collections;

/**
 * This appraisal variable show the desirability for food
 * it is usually create by a hungryness event
 * */
public class DesirabilityForFood : AppraisalVariableAbstract {

	public DesirabilityForFood(float pvalue)
	{
		setValue (pvalue);
	}
}
